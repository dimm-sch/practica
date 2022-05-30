using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace forms_librarie_app
{
    class StudentDatabase
    {

        private static SqlConnection connection = null;

        static StudentDatabase()
        {
            string hostname = Dns.GetHostName();
            string serverName = ("win-7".Equals(hostname)) ? "sqlserver" : "sqlexpress";
            string dataSource = hostname + "\\" + serverName;
            string database = "Student";
            string connectionString = "Data Source=" + dataSource + "; Database=" + database + "; Integrated Security = true;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static HashSet<string> getSpecialties()
        {
            SqlCommand command = new SqlCommand(
                "select specialtyName from Specialties", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            HashSet<string> specialties = new HashSet<string>();
            foreach (DataRow row in table.Rows)
            {
                string specialty = row.ItemArray[0].ToString().ToLower();
                specialties.Add(specialty);
            }

            return specialties;
        }

        public static int getSpecialtyId(string name)
        {
            SqlCommand command = new SqlCommand(
                $"select specialtyId from Specialties where specialtyName = '{name}'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            return (int)row.ItemArray[0];
        }

        public static int addSpecialty(string name)
        {
            SqlCommand command = new SqlCommand("sp_addSpecialty", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@name", name));
            command.ExecuteNonQuery();

            return getSpecialtyId(name);
        }

        public static void addStudent(string name, string surname, DateTime birthdate, int admissionYear, int specialtyId,
            string sex, string studies, bool requiresHostel)
        {
            SqlCommand command = new SqlCommand("sp_addStudent", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@surname", surname));
            command.Parameters.Add(new SqlParameter("@birthdate", birthdate));
            command.Parameters.Add(new SqlParameter("@admissionYear", admissionYear));
            command.Parameters.Add(new SqlParameter("@specialtyId", specialtyId));
            command.Parameters.Add(new SqlParameter("@sex", sex));
            command.Parameters.Add(new SqlParameter("@studies", studies));
            command.Parameters.Add(new SqlParameter("@requiresHostel", requiresHostel));

            command.ExecuteNonQuery();
        }

		public static bool existsStudent(string name, string surname, int admissionYear, string specialty)
		{
			string query = $"select * from vStudents " +
					$"where Name = '{name}' and Surname = '{surname}' and AdmissionYear = '{admissionYear}' " +
					$"and Specialty = '{specialty}'";
			SqlCommand command = new SqlCommand(query, connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			return table.Rows.Count > 0;
		}

		public static bool deleteStudent(string name, string surname, int admissionYear, string specialty)
		{
			string query = $"delete from Students where studentName = '{name}' " +
				$"and studentSurname = '{surname}' and studentAdmissionYear = '{admissionYear}' " +
				$"and studentSpecialtyId = '{getSpecialtyId(specialty)}'";
			SqlCommand command = new SqlCommand(query, connection);
			int commandResult = command.ExecuteNonQuery();
			return commandResult == 1 ? true : false;
		}

		public static DataTable searchStudent(string input) 
		{
			string query = $"select * from vStudents where concat(Name,' ',Surname) like " +
				$"'%{input}%' or Name like '%{input}%' or Surname like '%{input}%'";
			SqlCommand command = new SqlCommand(query, connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}
    }
}
