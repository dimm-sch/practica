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
            string database = "librarius";
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
                $"select specialtyId from Specialties where denumire = '{name}'", connection);
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

        public static void addStudent(string name, string surname, string birthdate, int admissionYear, int specialtyId,
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

    }
}
