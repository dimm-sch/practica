use master

-- use master; alter database Student set single_user with rollback immediate; drop database Student

IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = 'Student'
)
CREATE DATABASE Student
GO

create table Students (
	studentId int primary key identity,
	studentName nvarchar(50) not null,
	studentSurname nvarchar(50) not null,
	studentBirthdate date not null,
	studentAdmissionYear int not null,
	studentSpecialtyId int not null,
	studentSex char(1) check (studentSex = 'm' or studentSex = 'f') not null,
	studentStudies varchar(8) check (studentStudies = 'buget' or studentStudies = 'contract') not null,
	studentRequiresHostel bit not null
);

create table Specialties (
	specialtyId int primary key identity,
	specialtyName varchar(50) unique not null
);


alter table Studenti
add constraint FK_Student_Specialty
foreign key references Specialties(specialtyId)

go
create view vStudents
as
select studentId [Id], studentName [Name], studentSurname [Surname], studentBirthdate [Birthdate], studentAdmissionYear [AdmissionYear],
		specialtyName [Specialty], studentSex [Sex], studentStudies [Studies], studentRequiresHostel [RequiresHostel]
 from Students st
 inner join Specialties sp on (st.studentSpecialtyId = sp.specialtyId)

go
create procedure sp_addSpecialty
	@name varchar(50)
as
	insert into Specialties(specialtyName) values (@name);

go
create procedure sp_addStudent
	@name nvarchar(50),
	@surname varchar(50),
	@birthdate date,
	@admissionYear int,
	@specialtyId int,
	@sex char(1),
	@studies varchar(8),
	@requiresHostel bit
as
	insert into Students(studentName, studentSurname, studentBirthdate, studentAdmissionYear, studentSpecialtyId, studentSex, studentStudies, studentRequiresHostel) 
	values (@name, @surname, @birthdate, @admissionYear, @specialtyId, @sex, @studies, @requiresHostel);