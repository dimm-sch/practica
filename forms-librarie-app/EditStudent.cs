using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_librarie_app
{
	public partial class EditStudent : Form
	{
		public EditStudent()
		{
			InitializeComponent();
		}

		private void btnSubmitEditStudent_Click(object sender, EventArgs e)
		{
			bool exists = StudentDatabase.existsStudent(tbName.Text, tbSurname.Text, (int)nudYear.Value, cbSpeciality.Text);

			if (!exists)
			{
				MessageBox.Show("Studentul dat nu exista in baza de date!");
				return;
			}

			string specialty = inSpecialty.Text.ToLower();
			int specialtyId = -1;
			var specs = StudentDatabase.getSpecialties();

			if (specs.Contains(specialty))
			{
				specialtyId = StudentDatabase.getSpecialtyId(specialty);
			}
			else
			{
				specialtyId = StudentDatabase.addSpecialty(specialty);
			}

			string name = inName.Text;
			string surname = inSurname.Text;
			DateTime birthdate = inDate.Value;
			int admissionYear = (int)inYear.Value;
			string sex = gbSex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
			string formattedSex = (sex.Equals("Masculin") ? "m" : "f");
			string studies = gbStudies.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
			bool requiresHostel = cbRequiresHostel.Checked;


			string targetName = tbName.Text;
			string targetSurname = tbSurname.Text;
			int targetAdmissionYear = (int)nudYear.Value;
			string targetSpecialty = cbSpeciality.Text;
			StudentDatabase.deleteStudent(targetName, targetSurname, targetAdmissionYear, targetSpecialty);

			StudentDatabase.addStudent(name, surname, birthdate, admissionYear, specialtyId,
				formattedSex, studies, requiresHostel);
			MessageBox.Show("Datele studentului au fost modificate cu succes!");
		}
	}
}
