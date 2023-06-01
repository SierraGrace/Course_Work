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

namespace Course_Work
{
    public partial class SearchForm : Form
    {
        static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = VacancyDatabase.mdb";
        OleDbConnection myConnection;

        public SearchForm()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchBox.Text;

            string query = "SELECT Код, Назва, Опис, Зарплата, Компанія FROM Vacancies WHERE Назва = '" + search + "'";

            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();

            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
