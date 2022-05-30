using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_librarie_app
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            rBtnBudget.Checked = true;
            rBtnMale.Checked = true;
      
        }

        private string getFormattedStudentInfo()
        {
            string nl = "\r\n";
            string sex = gbSex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            string studies = gbStudies.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            string requiresHostel = (cbRequiresHostel.Checked ? "Necesar cămin" : "Nu e necesar cămin");

            string result = $"Nume: {tbName.Text}{nl}Prenume: {tbSurname.Text}{nl}Data nașterii: {dtpDate.Text}{nl}" +
                $"Anul admiterii: {nudYear.Value}{nl}Specialitatea: {cbSpeciality.Text}{nl}Sex: {sex}{nl}" +
                $"Studii: {studies}{nl}{requiresHostel}";

            return result;
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            if (!validateStudentName())
            {
                MessageBox.Show("Completați numele și prenumele!");
                return;
            }

            tbResult.Text = getFormattedStudentInfo();

        }

        private bool validateStudentName()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text)
                || string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                return false;
            }

            return true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string toExport = tbResult.Text;
            if (string.IsNullOrWhiteSpace(toExport)){
                MessageBox.Show("Mai întâi afișați datele în spațiul rezervat!");
                return;
            }
            File.WriteAllText("../../../student_export.txt", toExport);
            MessageBox.Show("Datele au fost exportate în: " + Path.GetFullPath("../../../student_export.txt"));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!validateStudentName())
            {
                MessageBox.Show("Completați numele și prenumele!");
                return;
            }

            string specialty = cbSpeciality.Text.ToLower();
            int specialtyId = -1;
            var specs = StudentDatabase.getSpecialties();

            if (specs.Contains(specialty))
            {
                specialtyId = StudentDatabase.getSpecialtyId(specialty);
            } else
            {
                specialtyId = StudentDatabase.addSpecialty(specialty);
            }

            string name = tbName.Text;
            string surname = tbSurname.Text;
			DateTime birthdate = dtpDate.Value;
			int admissionYear = (int)nudYear.Value;
			string sex = gbSex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
			string formattedSex = (sex.Equals("Masculin") ? "m" : "f");
			string studies = gbStudies.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
			bool requiresHostel = cbRequiresHostel.Checked;

			StudentDatabase.addStudent(name, surname, birthdate, admissionYear, specialtyId,
				formattedSex, studies, requiresHostel);
			MessageBox.Show("Studentul a fost adaugat cu succes!");
		}

		private void btnEditStudent_Click(object sender, EventArgs e)
		{
			EditStudent es = new EditStudent();
			es.Show();
		}

		private void btnDeleteStudent_Click(object sender, EventArgs e)
		{
			if (!validateStudentName())
			{
				MessageBox.Show("Completați numele și prenumele!");
				return;
			}

			bool successfulDeletion = StudentDatabase.deleteStudent(tbName.Text, tbSurname.Text, (int)nudYear.Value, cbSpeciality.Text);
			if (successfulDeletion)
			{
				MessageBox.Show($"Studentul {tbName.Text} {tbSurname.Text} a fost șters cu succes!");
			} else
			{
				string nl = "\r\n";
				string errorMessage = $"Nu a fost găsit nici-un student care să corespundă următoarelor date:{nl}" +
					$" - Nume: {tbName.Text}{nl} - Prenume: {tbSurname.Text}{nl}" +
					$" - Anul admiterii: {(int)nudYear.Value}{nl} - Specialitatea: {cbSpeciality.Text}";
				MessageBox.Show(errorMessage);
			}
			
		}

		private void btnDeleteHelp_Click(object sender, EventArgs e)
		{
			string nl = "\r\n";
			string message = $"Butonul 'Șterge' va șterge studentul din baza de date" +
				$" în baza următoarelor câmpuri de mai sus:{nl} - Nume{nl} - Prenume{nl} - Anul admiterii{nl} - Specialitatea{nl}";
			MessageBox.Show(message);
		}

		private void btnSearchStudent_Click(object sender, EventArgs e)
		{
			SearchStudent ss = new SearchStudent();
			ss.Show();
		}
	}
}
