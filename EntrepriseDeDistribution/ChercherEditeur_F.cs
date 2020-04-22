using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrepriseDeDistribution
{
    public partial class ChercherEditeur_F : UserControl
    {
        EntrepriseEntities data = new EntrepriseEntities();
        public ChercherEditeur_F()
        {
            InitializeComponent();
        }

        private void ChercherEditeur_F_Load(object sender, EventArgs e)
        {
            cb_editeur.DataSource = data.Editeurs.Select(ecr => new {
                Numero = ecr.Numero_Editeur,
                Nom = ecr.Nom_Editeur
            }).ToList();
            cb_editeur.DisplayMember = "Nom";
            cb_editeur.ValueMember = "Numero";
            cb_depot.DataSource = data.Depots.Select(d => new {
                Numero = d.Numero_Depot,
                Nom = d.Nom_Depot
            }).ToList();
            cb_depot.DisplayMember = "Nom";
            cb_depot.ValueMember = "Numero";
            cb_editeur.SelectionChangeCommitted += Cb_editeur_SelectionChangeCommitted;
            cb_depot.SelectionChangeCommitted += Cb_depot_SelectionChangeCommitted;
           
        }

        private void Cb_depot_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Clacule_Total();
        }

        private void Clacule_Total()
        {
            int numero_edituer = Int32.Parse(cb_editeur.SelectedValue.ToString());
            int numero_depot = Int32.Parse(cb_depot.SelectedValue.ToString());
            var query1 = (from s in data.Stocks where s.Numero_Depot == numero_depot && s.Numero_Editeur == numero_edituer select new { s.Quantite }).ToList();
            txt_total.Text = query1.Sum(x => x.Quantite) + "";
        }

        private void Cb_editeur_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numero_edituer = Int32.Parse(cb_editeur.SelectedValue.ToString());
            int numero_depot = Int32.Parse(cb_depot.SelectedValue.ToString());
            var query = (from s in data.Stocks
                         join l in data.Livres on s.Numero_Livre equals l.Numero_Livre
                         join t in data.Themes on l.Numero_Theme equals t.Numero_Theme
                         where s.Numero_Editeur == numero_edituer
                         select new { l.Numero_Livre, l.Nom_Livre, t.Nom_Theme }).Distinct().ToList();
            
            dataGridView1.DataSource = query;
            Clacule_Total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_editeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = 
          
        }
    }
}
