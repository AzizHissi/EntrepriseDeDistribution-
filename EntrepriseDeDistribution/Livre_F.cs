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
    public partial class Livre_F : UserControl
    {
        EntrepriseEntities db1 = new EntrepriseEntities();
        BindingSource bs1 = new BindingSource();
        public Livre_F()
        {
            InitializeComponent();
        }

        private void Livre_F_Load(object sender, EventArgs e)
        {

            cb_theme.DataSource = db1.Themes.Select(t => new
            {
                Numero = t.Numero_Theme,
                Nom = t.Nom_Theme

            }).ToList();
            cb_theme.DisplayMember = "Nom";
            cb_theme.ValueMember = "Numero";
            Charger_Grid();
            dataGridView1.DataSource = bs1;
            txt_num.DataBindings.Add("Text", bs1, "Numero");
            txt_titre.DataBindings.Add("Text", bs1, "Titre");
           cb_theme.DataBindings.Add("Text", bs1, "Theme");
             
            txt_num.Enabled = false;



        }

        private void Charger_Grid()
        {
            bs1.DataSource = db1.Livres.Select(edt => new {
                Numero = edt.Numero_Livre,
                Titre = edt.Nom_Livre,
                Theme = edt.Theme.Nom_Theme
            }).ToList();
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            Vider(this);
            txt_num.Enabled = true;
        }

        public void Vider(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c.Controls.Count != 0) Vider(c);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Int32.TryParse(txt_num.Text, out int number) && txt_titre.Text == "" && cb_theme.Text == "")
                {
                    MessageBox.Show("Merci de remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (db1.Livres.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(txt_num.Text)).Count() == 0)
                {
                    Livre lvr = new Livre
                    {
                        Numero_Livre = Int32.Parse(txt_num.Text),
                        Nom_Livre = txt_titre.Text,
                        Numero_Theme = Int32.Parse(cb_theme.SelectedValue + "")
                    };
                    db1.Livres.Add(lvr);
                    db1.SaveChanges();
                    Charger_Grid();


                }
                else
                {
                    MessageBox.Show("Numero d'editeur Deja Exist", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
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

                    db1.Livres.Remove(db1.Livres.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(txt_num.Text)).First());
                    db1.SaveChanges();
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


                    db1.Livres.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(txt_num.Text)).First().Nom_Livre = txt_titre.Text;
                    db1.Livres.AsEnumerable().Where(p => p.Numero_Livre == Int32.Parse(txt_num.Text)).First().Numero_Theme = Int32.Parse(cb_theme.SelectedValue + "");



                    db1.SaveChanges();
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
            bs1.MoveFirst();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            bs1.MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bs1.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bs1.MoveLast();
        }

        
    }
}
