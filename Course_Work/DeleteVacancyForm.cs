using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Course_Work
{
    public partial class DeleteVacancyForm : Form
    {
        static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Користувач\\Documents\\Studying\\Professional Practice Software Engineering\\Course_Work\\Course_Work\\Course_Work\\VacancyDatabase.mdb";
        OleDbConnection myConnection;

        public DeleteVacancyForm()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string code = codeBox.Text;

            string query = "DELETE FROM Vacancies WHERE Код = " + code;

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Вакансію виделено з бази!");
            this.Close();
        }

        private void DeleteVacancyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
