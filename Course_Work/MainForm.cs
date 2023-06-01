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
    public partial class MainForm : Form
    {
        static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = VacancyDatabase.mdb";
        OleDbConnection myConnection;

        public MainForm()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            this.vacanciesTableAdapter.Fill(this.vacancyDatabaseDataSet.Vacancies);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.vacanciesTableAdapter.Connection = myConnection;
            this.vacanciesTableAdapter.Fill(this.vacancyDatabaseDataSet.Vacancies);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddVacancyForm addForm = new AddVacancyForm();
            addForm.Show();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DeleteVacancyForm delForm = new DeleteVacancyForm();
            delForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
