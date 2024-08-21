using StudentManagementApp.StudentDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDatabaseDataSet.Student);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentBindingSource.RemoveCurrent();

        }

        private void btnAdd_Click_Click(object sender, EventArgs e)
        {
            var newRow = studentBindingSource.AddNew();
        }

        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            Validate();
            studentBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(studentDatabaseDataSet);
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {  try
            {
                this.Validate();
                this.studentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.studentDatabaseDataSet); // This line should now work correctly
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
