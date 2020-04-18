using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrepriseDeDistribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editeur1.BringToFront();
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            livre1.BringToFront();
        }

        private void editionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition_F edit = new Edition_F();
            edit.ShowDialog();
        }

        private void parDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chercheDate1.BringToFront();
        }

        private void parNomEditeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chercherEditeur1.BringToFront();
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1.BringToFront();
        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphe1.BringToFront();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment quiter","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
