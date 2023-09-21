/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-06-8
 * Updated: 2023-06-22
 */

using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Levi.Verity.RRCAGApp
{

    /// <summary>
    /// A class that uses a data base to keep 
    /// track of cars coming in and out of the shop
    /// </summary>
    internal class VehicleDataClass : VehicleDataForm
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;

        /// <summary>
        /// this is the method with the subscription 
        /// for the method that loads everything
        /// </summary>
        public VehicleDataClass()
        {
            this.bindingSource = new BindingSource();

            this.Load += new EventHandler(ContactsForm_Load);

        }

        /// <summary>
        /// Loads everything in the class to run the program 
        /// </summary>
        void ContactsForm_Load(object sender, EventArgs e)
        {
           this.Text = "";

            RetrieveDataFromTheDatabase();

            BindControls();

            this.dgvVehicles.SelectionChanged += new EventHandler(dgvVehicles_SelectionChanged);
            this.mnuFileSave.Click += new EventHandler(FileSave_Click);
            this.mnuEditDelete.Click += new EventHandler(EditDelete_Click);
            this.mnuFileClose.Click += MnuFileClose_Click;

            this.dataset.Tables["VehicleStock"].RowChanged += new DataRowChangeEventHandler(AnalyzeHasChanges);
            this.dataset.Tables["VehicleStock"].ColumnChanged += new DataColumnChangeEventHandler(AnalyzeHasChanges);

            adapter.RowUpdated += new OleDbRowUpdatedEventHandler(dataAdapter_RowUpdated);
        }

        /// <summary>
        /// happens when anything is changed in the data base so 
        /// that the save button is enabled 
        /// </summary>
        private void AnalyzeHasChanges(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            bool hasChanges = this.dataset.HasChanges();
            if (hasChanges == true)
            {
                mnuFileSave.Enabled = true;            
                this.Text = "* Vehicle Data";               
            }
        }

        /// <summary>
        /// this is so when when i full row is selected you can delete it 
        /// </summary>
        private void dgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow != null && dgvVehicles.CurrentRow.Selected)
            {
                mnuEditDelete.Enabled = true;
            }
 
            else
            {
                mnuEditDelete.Enabled = false;
            }
        }

        /// <summary>
        /// this is the code that deletes the row 
        /// </summary>
        private void EditDelete_Click(object sender, EventArgs e)
        {

            String stockitem = this.dgvVehicles.SelectedCells[1].Value.ToString(); 
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete stock item " + stockitem + "?", "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvVehicles.SelectedRows[0];
                    dgvVehicles.Rows.Remove(selectedRow);
                    adapter.Update(dataset, "VehicleStock");
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while deleting the selected vehicle.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// this is how you close the file and if a
        /// save can be made a message box will pop up
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            if (mnuFileSave.Enabled == true)
            {
                DialogResult result = MessageBox.Show("Do you wish to save the changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.No;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.adapter.Update(this.dataset, "VehicleStock");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult results = MessageBox.Show("An error occurred while saving the changes. Do you still wish to close?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }

                }
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (Exception)
                {
                    DialogResult results = MessageBox.Show("An error occurred while saving the changes. Do you still wish to close?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (results == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            
        }

        /// <summary>
        /// this sets up the data base and calls in the file
        /// </summary>
        private void RetrieveDataFromTheDatabase()
        {
            this.connection = new OleDbConnection();

            this.connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = AMDatabase.mdb";

            this.connection.Open();

            OleDbCommand selectCommand;
            selectCommand = new OleDbCommand();

            selectCommand.CommandText = "SELECT * FROM VehicleStock;";
            selectCommand.Connection = this.connection;

            this.adapter = new OleDbDataAdapter();
            this.adapter.SelectCommand = selectCommand;

            this.dataset = new DataSet();

            this.adapter.Fill(this.dataset, "VehicleStock");

            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder();
            commandBuilder.DataAdapter = this.adapter;

            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

            this.adapter.InsertCommand = commandBuilder.GetInsertCommand();
            this.adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            this.adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
        }

        /// <summary>
        /// this is the code that saves changes when you click save 
        /// </summary>
        private void FileSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVehicles.EndEdit();
                bindingSource.EndEdit();

                this.adapter.Update(this.dataset, "VehicleStock");

                this.mnuFileSave.Enabled = false;
                this.Text = "";
            }
            catch(Exception)
            {
                DialogResult result = MessageBox.Show("An error occurred while saving the changes to the vehicle data.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        /// <summary>
        /// this is all the data biding and where i hid the rows 
        /// </summary>
        private void BindControls()
        {
            this.bindingSource = new BindingSource();
            this.bindingSource.DataSource = this.dataset.Tables["VehicleStock"];
            this.dgvVehicles.DataSource = this.bindingSource;
            this.dgvVehicles.Columns["ID"].Visible = false;
            this.dgvVehicles.Columns["SoldBy"].Visible = false;
        }

        /// <summary>
        /// Event handler for the RowUpdated event of the DataAdapter
        /// </summary>
        void dataAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // When the update is an Insert (new record)
            if (e.StatementType == StatementType.Insert)
            {
                // Creates a new command
                // @@IDENTITY - a database value that returns the last-inserted identity 
                // (AutoNumber) value from the last statement
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", connection);

                // Assigns the ID value of the new row in the database to the DataColumn "ID" 
                // of the new
                // DataRow in the DataTable
                // ***
                // ExecuteScalar - Executes the command and returns the value of first column 
                // of the first row returned
                // e.Row - reference to the DataRow being updated from the DataTable.
                // e.Row["ID"] - reference to the "ID" DataColumn in the DataRow.
                e.Row["ID"] = (int)cmd.ExecuteScalar();
            }
        }
    }
}
