using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addHewanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHewan abs = new AddHewan();
            abs.Show();
        }

        private void namaPengunjungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAnimal abs = new AddAnimal();
            abs.Show();
        }

        private void viewHewanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook abs = new viewbook();
            abs.Show();
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestList abs = new GuestList();
            abs.Show();
        }
    }
}
