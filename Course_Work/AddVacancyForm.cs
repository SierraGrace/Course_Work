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
    public partial class AddVacancyForm : Form
    {
        static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = VacancyDatabase.mdb";
        OleDbConnection myConnection;

        public AddVacancyForm()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(codeBox.Text);
            int salary = Convert.ToInt32(salaryBox.Text);

            string name = vacancyName.Text;
            string description = descBox.Text;
            string company = compName.Text;

            string query = "INSERT INTO Vacancies (Код, Назва, Опис, Зарплата, Компанія) VALUES (" + code + ", '" + name + "', '" + description + "'," + salary + ", '" + company + "')";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            MessageBox.Show("Вакансію додано до бази!");
            this.Close();
        }

        private void AddVacancyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
