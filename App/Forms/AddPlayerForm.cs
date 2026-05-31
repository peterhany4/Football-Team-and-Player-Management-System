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
    public partial class AddPlayerForm : Form
    {
        Database1DataSetTableAdapters.PlayerTableTableAdapter dataB;
        public AddPlayerForm(Database1DataSetTableAdapters.PlayerTableTableAdapter dataB)
        {
            InitializeComponent();
            this.dataB = dataB;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Player P1 = new Player();

            try
            {
                P1.Name = textBox2.Text;
                P1.Number = Convert.ToInt32(textBox3.Text);
                P1.Posision = textBox4.Text;
                P1.teamId = Convert.ToInt32(textBox5.Text);
                dataB.InsertPlayerQuery(P1.Name, P1.Number, P1.Posision, P1.teamId);
                MessageBox.Show("Player Is Added");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Notice: You MUST use a correct TeamID that existis! ... Please check the current teams...\n" + ex.Message);
            }
        }
    }
}
