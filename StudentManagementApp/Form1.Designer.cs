namespace StudentManagementApp
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDatabaseDataSet = new StudentManagementApp.StudentDatabaseDataSet();
            this.studentDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new StudentManagementApp.StudentDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.btnAdd_Click = new System.Windows.Forms.Button();
            this.btnUpdate_Click = new System.Windows.Forms.Button();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            this.btnSave_Click = new System.Windows.Forms.Button();
            this.tableAdapterManager = new StudentManagementApp.StudentDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(126, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDatabaseDataSet;
            // 
            // studentDatabaseDataSet
            // 
            this.studentDatabaseDataSet.DataSetName = "StudentDatabaseDataSet";
            this.studentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDatabaseDataSetBindingSource
            // 
            this.studentDatabaseDataSetBindingSource.DataSource = this.studentDatabaseDataSet;
            this.studentDatabaseDataSetBindingSource.Position = 0;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd_Click
            // 
            this.btnAdd_Click.Location = new System.Drawing.Point(140, 285);
            this.btnAdd_Click.Name = "btnAdd_Click";
            this.btnAdd_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Click.TabIndex = 1;
            this.btnAdd_Click.Text = "Add";
            this.btnAdd_Click.UseVisualStyleBackColor = true;
            this.btnAdd_Click.Click += new System.EventHandler(this.btnAdd_Click_Click);
            // 
            // btnUpdate_Click
            // 
            this.btnUpdate_Click.Location = new System.Drawing.Point(288, 285);
            this.btnUpdate_Click.Name = "btnUpdate_Click";
            this.btnUpdate_Click.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_Click.TabIndex = 2;
            this.btnUpdate_Click.Text = "Update";
            this.btnUpdate_Click.UseVisualStyleBackColor = true;
            this.btnUpdate_Click.Click += new System.EventHandler(this.btnUpdate_Click_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.Location = new System.Drawing.Point(441, 285);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Click.TabIndex = 3;
            this.btnDelete_Click.Text = "Delete";
            this.btnDelete_Click.UseVisualStyleBackColor = true;
            this.btnDelete_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.Location = new System.Drawing.Point(588, 285);
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSave_Click.TabIndex = 4;
            this.btnSave_Click.Text = "Save";
            this.btnSave_Click.UseVisualStyleBackColor = true;
            this.btnSave_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentManagementApp.StudentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave_Click);
            this.Controls.Add(this.btnDelete_Click);
            this.Controls.Add(this.btnUpdate_Click);
            this.Controls.Add(this.btnAdd_Click);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentDatabaseDataSetBindingSource;
        private StudentDatabaseDataSet studentDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd_Click;
        private System.Windows.Forms.Button btnUpdate_Click;
        private System.Windows.Forms.Button btnDelete_Click;
        private System.Windows.Forms.Button btnSave_Click;
        private StudentDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;

    }
}

