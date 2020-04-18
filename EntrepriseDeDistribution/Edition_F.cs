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
    public partial class Edition_F : Form
    {
        EntrepriseEntities db2 = new EntrepriseEntities();
     
        public Edition_F()
        {
            InitializeComponent();
        }

        private void Edition_F_Load(object sender, EventArgs e)
        {
            cb_editeur.DataSource = db2.Editeurs.Select(ed => new
            {
                Numero = ed.Numero_Editeur,
                Nom = ed.Nom_Editeur
            }).ToList();
          
            cb_editeur.DisplayMember = "Nom";
            cb_editeur.ValueMember = "Numero";
            cb_livre.DataSource = db2.Livres.Select(ed => new
            {
                Numero = ed.Numero_Livre,
                Nom = ed.Nom_Livre
            }).ToList();
           
            cb_livre.DisplayMember = "Nom";
            cb_livre.ValueMember = "Numero";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (db2.Editions.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(cb_livre.SelectedValue + "") && p.Numero_Editeur == Int32.Parse(cb_editeur.SelectedValue + "")).Count() == 0)
                {
                    Edition edition = new Edition
                    {
                        Numero_Livre = Int32.Parse(cb_livre.SelectedValue + ""),
                        Numero_Editeur = Int32.Parse(cb_editeur.SelectedValue + ""),
                        Annee_D_edition = dt_annee.Value
                    };
                    db2.Editions.Add(edition);
                    db2.SaveChanges();
                    MessageBox.Show("Element Ajouter avec succes", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                }
                else
                {
                    MessageBox.Show("Choix exist deja", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    db2.Editions.Remove(db2.Editions.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(cb_livre.SelectedValue + "") && p.Numero_Editeur == Int32.Parse(cb_editeur.SelectedValue + "")).First());
                    db2.SaveChanges();
                    
                    MessageBox.Show("Element suprimer avec succes", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment modifier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    db2.Editions.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(cb_livre.SelectedValue + "") && p.Numero_Editeur == Int32.Parse(cb_editeur.SelectedValue + "")).First().Annee_D_edition = dt_annee.Value;



                    db2.SaveChanges();
                   
                    MessageBox.Show("Element modifier avec succes", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
