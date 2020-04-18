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
    public partial class ChercheDate_F : UserControl
    {
        EntrepriseEntities db4 = new EntrepriseEntities();
        public ChercheDate_F()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db4.V_Recherche.Where(r => r.Annee_D_edition >= dt_d.Value && r.Annee_D_edition <= dt_f.Value).ToList();
            
        }
    }
}
