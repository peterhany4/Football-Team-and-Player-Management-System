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
    public partial class filterPlayersForm : Form
    {
        mainForm mf;
        public filterPlayersForm(mainForm f1)
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

        private void filterPlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.PlayerTable' table. You can move, or remove it, as needed.
            this.playerTableTableAdapter.Fill(this.database1DataSet.PlayerTable);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox1.Text);

                this.playerTableTableAdapter.FilterPlayersByTeamID(this.database1DataSet.PlayerTable, id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Close();
        }
    }
}
