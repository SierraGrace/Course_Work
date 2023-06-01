namespace Course_Work
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компаніяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancyDatabaseDataSet = new Course_Work.VacancyDatabaseDataSet();
            this.vacanciesTableAdapter = new Course_Work.VacancyDatabaseDataSetTableAdapters.VacanciesTableAdapter();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Робота мрії";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(577, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 58);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Q";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(707, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 58);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(772, 36);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(59, 58);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "-";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.назваDataGridViewTextBoxColumn,
            this.описDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn,
            this.компаніяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vacanciesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 342);
            this.dataGridView1.TabIndex = 4;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            this.назваDataGridViewTextBoxColumn.Width = 125;
            // 
            // описDataGridViewTextBoxColumn
            // 
            this.описDataGridViewTextBoxColumn.DataPropertyName = "Опис";
            this.описDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.описDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описDataGridViewTextBoxColumn.Name = "описDataGridViewTextBoxColumn";
            this.описDataGridViewTextBoxColumn.Width = 125;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // компаніяDataGridViewTextBoxColumn
            // 
            this.компаніяDataGridViewTextBoxColumn.DataPropertyName = "Компанія";
            this.компаніяDataGridViewTextBoxColumn.HeaderText = "Компанія";
            this.компаніяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.компаніяDataGridViewTextBoxColumn.Name = "компаніяDataGridViewTextBoxColumn";
            this.компаніяDataGridViewTextBoxColumn.Width = 125;
            // 
            // vacanciesBindingSource
            // 
            this.vacanciesBindingSource.DataMember = "Vacancies";
            this.vacanciesBindingSource.DataSource = this.vacancyDatabaseDataSet;
            // 
            // vacancyDatabaseDataSet
            // 
            this.vacancyDatabaseDataSet.DataSetName = "VacancyDatabaseDataSet";
            this.vacancyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacanciesTableAdapter
            // 
            this.vacanciesTableAdapter.ClearBeforeFill = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(642, 36);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(59, 58);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "О";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 474);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Робота мрії";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VacancyDatabaseDataSet vacancyDatabaseDataSet;
        private System.Windows.Forms.BindingSource vacanciesBindingSource;
        private VacancyDatabaseDataSetTableAdapters.VacanciesTableAdapter vacanciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компаніяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refreshButton;
    }
}

