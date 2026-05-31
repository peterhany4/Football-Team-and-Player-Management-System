using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class AddEditPlayerForm : Form
    {
        mainForm mf;

        public AddEditPlayerForm(mainForm f1)
        {
            InitializeComponent();
            mf = f1;
        }

        private void playerTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void AddEditPlayerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.PlayerTable' table. You can move, or remove it, as needed.
            this.playerTableTableAdapter.Fill(this.database1DataSet.PlayerTable);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayer = new AddPlayerForm(this.playerTableTableAdapter);

            addPlayer.ShowDialog();

            this.playerTableTableAdapter.Fill(this.database1DataSet.PlayerTable);
            this.Validate();
            this.playerTableBindingSource.EndEdit();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            playerTableDataGridView.ReadOnly = !(playerTableDataGridView.ReadOnly);

            if (playerTableDataGridView.ReadOnly == false)
            {
                MessageBox.Show("Edit Mode is Enabled... Double click on the cell you want to edit!");
            }
            else
            {
                MessageBox.Show("Edit Mode is Disabled...");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.playerTableBindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this Player?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.playerTableBindingSource.RemoveCurrent();

                        this.playerTableBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.database1DataSet);

                        MessageBox.Show("Player deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving deletion to database: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no records left to delete.");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                this.playerTableBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.database1DataSet);

                MessageBox.Show("All changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save changes. Error: " + ex.Message);
            }
        }

        private void mainFormBtn_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Close();
        }
    }
}
