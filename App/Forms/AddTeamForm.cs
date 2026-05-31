using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Database1DataSetTableAdapters;

namespace App.Forms
{
    public partial class AddTeamForm : Form
    {
        Database1DataSetTableAdapters.TeamTableTableAdapter dataB;
        public AddTeamForm(Database1DataSetTableAdapters.TeamTableTableAdapter incomingAdapter)
        {
            InitializeComponent();
            dataB = incomingAdapter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team T1 = new Team();

            try
            {
                T1.Name = textBox2.Text;
                T1.Coach = textBox3.Text;
                T1.Year = Convert.ToInt32(textBox4.Text);
                dataB.InsertTeamQuery(T1.Name,T1.Coach,T1.Year);
                MessageBox.Show("Team Is Added");
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
