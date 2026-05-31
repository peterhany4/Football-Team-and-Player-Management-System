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
    public partial class SortPlayers : Form
    {
        mainForm mf;
        public SortPlayers(mainForm f1)
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

        private void SortPlayers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.PlayerTable' table. You can move, or remove it, as needed.
            this.playerTableTableAdapter.Fill(this.database1DataSet.PlayerTable);

        }

        private void IDSort_Click(object sender, EventArgs e)
        {
            this.playerTableTableAdapter.SortPlayerById(this.database1DataSet.PlayerTable);
        }

        private void playerSort_Click(object sender, EventArgs e)
        {
            this.playerTableTableAdapter.SortPlayerByName(this.database1DataSet.PlayerTable);
        }

        private void numberSort_Click(object sender, EventArgs e)
        {
            this.playerTableTableAdapter.SortPlayerByNumber(this.database1DataSet.PlayerTable);
        }

        private void positionSort_Click(object sender, EventArgs e)
        {
            this.playerTableTableAdapter.SortPlayerByPosition(this.database1DataSet.PlayerTable);
        }

        private void teamIDSort_Click(object sender, EventArgs e)
        {
            this.playerTableTableAdapter.SortPlayerByTeamID(this.database1DataSet.PlayerTable);
        }

        private void mainFormBtn_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Close();
        }
    }
}
