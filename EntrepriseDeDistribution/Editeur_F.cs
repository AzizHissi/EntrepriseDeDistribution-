using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntrepriseDeDistribution
{
    public partial class Editeur_F : UserControl
    {
        EntrepriseEntities db = new EntrepriseEntities();
        BindingSource bs = new BindingSource();
        public Editeur_F()
        {
            InitializeComponent();
        }

        private void Editeur_F_Load(object sender, EventArgs e)
        {
            Charger_Grid();
            dataGridView1.DataSource = bs;
            txt_num.DataBindings.Add("Text", bs, "Numero");
            txt_nom.DataBindings.Add("Text", bs, "Nom");
            txt_raisonS.DataBindings.Add("Text", bs, "Raison_Sociale");
            txt_adresse.DataBindings.Add("Text", bs, "Adresse");
            txt_num.Enabled = false;


        }

        private void Charger_Grid()
        {
            bs.DataSource = db.Editeurs.Select(edt => new { Numero = edt.Numero_Editeur,
                                                            Nom = edt.Nom_Editeur,
                                                            Raison_Sociale = edt.Raison_Sociale,
                                                            Adresse = edt.Adresse
                                                            }).ToList();
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            Vider(this);
            txt_num.Enabled = true;
        }

        public void Vider(Control ctrl)
        {
            foreach(Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c.Controls.Count !=0) Vider(c);
            }
            
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Int32.TryParse(txt_num.Text, out int number) && txt_nom.Text == "" && txt_raisonS.Text == "" && txt_adresse.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.Editeurs.AsEnumerable().Where(p => p.Numero_Editeur == Int32.Parse(txt_num.Text)).Count()==0)
            {
                Editeur edt = new Editeur
                {
                    Numero_Editeur = Int32.Parse(txt_num.Text),
                    Nom_Editeur = txt_nom.Text,
                    Raison_Sociale = txt_raisonS.Text,
                    Adresse = txt_adresse.Text

                };
                db.Editeurs.Add(edt);
                db.SaveChanges();
                Charger_Grid();


            }
            else
            {
                MessageBox.Show("Numero d'editeur Deja Exist", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_num.Enabled = false;
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment suprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    db.Editeurs.Remove(db.Editeurs.AsEnumerable().Where(p => p.Numero_Editeur == Int32.Parse(txt_num.Text)).First());
                    db.SaveChanges();
                    Charger_Grid();
                    MessageBox.Show("Element suprimer avec succes", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
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
                  
                      
                        db.Editeurs.AsEnumerable().Where(p => p.Numero_Editeur == Int32.Parse(txt_num.Text)).First().Nom_Editeur = txt_nom.Text;
                        db.Editeurs.AsEnumerable().Where(p => p.Numero_Editeur == Int32.Parse(txt_num.Text)).First().Raison_Sociale = txt_raisonS.Text;
                        db.Editeurs.AsEnumerable().Where(p => p.Numero_Editeur == Int32.Parse(txt_num.Text)).First().Adresse = txt_adresse.Text;

                   
                      
                    db.SaveChanges();
                    Charger_Grid();
                    MessageBox.Show("Element modifier avec succes", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
