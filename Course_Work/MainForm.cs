using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            this.vacanciesTableAdapter.Fill(this.vacancyDatabaseDataSet.Vacancies);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddVacancyForm addForm = new AddVacancyForm();
            addForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.vacanciesTableAdapter.Fill(this.vacancyDatabaseDataSet.Vacancies);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DeleteVacancyForm delForm = new DeleteVacancyForm();
            delForm.Show();
        }
    }
}
