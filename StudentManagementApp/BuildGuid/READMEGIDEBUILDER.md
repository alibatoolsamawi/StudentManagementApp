# Student Management App - Building Guide

This guide walks you through building a simple student management application using Visual Studio 2022 and SQL Server. It allows users to add, update, delete, and save student information in a database.

## Prerequisites

* **Visual Studio 2022:** Ensure you have Visual Studio 2022 installed.
* **SQL Server:** A local instance of SQL Server is required for database management.

## Building the App

### 1. Create a New Project

   - Open Visual Studio 2022.
   - Go to `File > New > Project`.
   - Select `Windows Forms App (.NET Framework)` from the templates.
   - Name your project `StudentManagementApp` and choose a location to save it.
   - Click `Create`.

### 2. Adding a Database

   - Right-click on your project in the Solution Explorer.
   - Select `Add > New Item`.
   - Choose `Service-based Database` and name it `StudentDatabase.mdf`.
   - Click `Add`.

### 3. Design the Database Schema

   - Double-click on `StudentDatabase.mdf` to open it in the Server Explorer.
   - Right-click on `Tables` and select `Add New Table`.
   - Add the following columns to your `Student` table:

     | Column Name | Data Type     | Description                       |
     |-------------|---------------|-----------------------------------|
     | Id          | int           | Primary Key (Auto Increment)       |
     | Name        | nvarchar(100) | Student Name                       |
     | Age         | int           | Student Age                        |
     | Email       | nvarchar(100) | Student Email Address              |

   - Save the table as `Student`.

### 4. Configure the DataSet

   - Right-click on your project and select `Add > New Item`.
   - Choose `DataSet` and name it `StudentDatabaseDataSet.xsd`.
   - Drag and drop the `Student` table from the Server Explorer to the DataSet designer.
   - Save the DataSet.

### 5. Adding TableAdapter and BindingSource

   - Open `StudentDatabaseDataSet.xsd`.
   - Right-click on the `Student` table.
   - Select `Add > TableAdapter`.
   - Follow the wizard to create `StudentTableAdapter`.
   - Add a `BindingSource` to your form by dragging `StudentTableAdapter` and `StudentDatabaseDataSet` from the Data Sources panel to the form.

### 6. Design the Form

   - Open `Form1` (default form name) in the designer view.
   - Drag a `DataGridView` onto the form and set its `DataSource` property to `StudentBindingSource`.
   - Add Buttons for Add, Update, Delete, and Save with appropriate text and click event handlers (`btnAdd_Click`, `btnUpdate_Click`, `btnDelete_Click`, and `btnSave_Click`).

### 7. Implementing Form Code

```csharp
using System;
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
            // Load data into the 'studentDatabaseDataSet.Student' table.
            this.studentTableAdapter.Fill(this.studentDatabaseDataSet.Student);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newRow = studentBindingSource.AddNew();
            // Optionally set default values
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Validate();
            studentBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(studentDatabaseDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                studentBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(studentDatabaseDataSet);
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
```

### 8. Adding Error Handling

- Ensure your button click event handlers (`btnAdd_Click`, `btnUpdate_Click`, etc.) include error handling (using `try...catch` blocks) to manage potential exceptions during database operations.
- Update the `btnSave_Click` method to handle exceptions and provide user feedback (e.g., display an error message on failure).

### 9. Database Table Creation (Optional)

If you haven't already created the `Student` table in your SQL Server, you can execute the following SQL script to create it:

```sql
CREATE TABLE [dbo].[Student]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY,
  [Name] NVARCHAR(100) NULL,
  [Age] INT NULL,
  [Email] NVARCHAR(100) NULL
)
```
### 10. Testing the App

- Run your application by pressing `F5` or clicking the Start button.
- Test each functionality (Add, Update, Delete, Save) to ensure everything works correctly.
- Verify that data is saved and retrieved accurately from the database.

### Additional Tips

- Ensure automatic data binding is set up correctly. Manual configuration shouldn't be needed if you follow these steps.
- Regularly save and back up your work.


Feel free to modify or add more details as needed!


