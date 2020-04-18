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
    public partial class Graphe_F : UserControl
    {
        EntrepriseEntities Data = new EntrepriseEntities();
        public Graphe_F()
        {
            InitializeComponent();
        }

        private void Graphe_F_Load(object sender, EventArgs e)
        {
            Graphe_Source();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphe_Source();
        }

        private void Graphe_Source()
        {
            chart1.DataSource = Data.V_graphe.ToList();
            chart1.Series["Depot"].YValueMembers = "Total_en_stock";
            chart1.Series["Depot"].XValueMember = "Nom_Depot";
            chart1.DataBind();
        }

        
    }
}
