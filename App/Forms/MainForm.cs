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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void viewTeamsForm_Click(object sender, EventArgs e)
        {
            viewTeamsForm viewTeams = new viewTeamsForm(this);
            viewTeams.Show();
            this.Hide();
        }

        private void sortTeamsForm_Click(object sender, EventArgs e)
        {
            sortTeamsForm sortTeams = new sortTeamsForm(this);
            sortTeams.Show();
            this.Hide();
        }

        private void add_edit_teamBtn_Click(object sender, EventArgs e)
        {
            addEditTeamForm addEditTeam = new addEditTeamForm(this);
            addEditTeam.Show();
            this.Hide();
        }

        private void add_edit_playerBtn_Click(object sender, EventArgs e)
        {
            AddEditPlayerForm addEditPlayer = new AddEditPlayerForm(this);
            addEditPlayer.Show();
            this.Hide();
        }

        private void sortPlayersBtn_Click(object sender, EventArgs e)
        {
            SortPlayers sortTeams = new SortPlayers(this);
            sortTeams.Show();
            this.Hide();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            filterPlayersForm Filter = new filterPlayersForm(this);
            Filter.Show();
            this.Hide();
        }

        private void helpForm_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
