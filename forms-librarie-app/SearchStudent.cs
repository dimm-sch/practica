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
	public partial class SearchStudent : Form
	{
		public SearchStudent()
		{
			InitializeComponent();
		}

		private void btnSearchStudent_Click(object sender, EventArgs e)
		{
			string input = tbSearchBar.Text;

			if (string.IsNullOrWhiteSpace(input))
			{
				MessageBox.Show("Bara de căutare este goală!");
				return;
			}

			dgwSearchResult.DataSource = StudentDatabase.searchStudent(input);
		}
	}
}
