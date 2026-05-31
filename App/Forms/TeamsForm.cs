using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class viewTeamsForm : Form
    {
        mainForm mf;
        public viewTeamsForm(mainForm f1)
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

        private void viewTeamsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TeamTable' table. You can move, or remove it, as needed.
            this.teamTableTableAdapter.Fill(this.database1DataSet.TeamTable);

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Close();
        }
    }
}
