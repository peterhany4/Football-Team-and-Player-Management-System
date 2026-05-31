using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Forms;

namespace App
{
    public partial class addEditTeamForm : Form
    {
        mainForm mf;
        public addEditTeamForm(mainForm f1)
        {
            InitializeComponent();
            mf = f1;
        }

        private void teamTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void addEditTeamForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TeamTable' table. You can move, or remove it, as needed.
            this.teamTableTableAdapter.Fill(this.database1DataSet.TeamTable);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeam = new AddTeamForm(this.teamTableTableAdapter);

            addTeam.ShowDialog();
            
            this.teamTableTableAdapter.Fill(this.database1DataSet.TeamTable);
            this.Validate();
            this.teamTableBindingSource.EndEdit();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            teamTableDataGridView.ReadOnly = !(teamTableDataGridView.ReadOnly);

            if (teamTableDataGridView.ReadOnly == false)
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
            if (this.teamTableBindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this team?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.teamTableBindingSource.RemoveCurrent();

                        this.teamTableBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.database1DataSet);

                        MessageBox.Show("Team deleted successfully.");
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

                this.teamTableBindingSource.EndEdit();

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
