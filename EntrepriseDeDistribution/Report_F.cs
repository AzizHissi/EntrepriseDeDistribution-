using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace EntrepriseDeDistribution
{
    public partial class Report_F : UserControl
    {
        EntrepriseEntities dt = new EntrepriseEntities();
        public Report_F()
        {
            InitializeComponent();
        }

       

        private void Report_F_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dt.Ecrivains.Select(ecr => new {
                Numero = ecr.Numero_Ecrivain,
                Nom = ecr.Nom_Ecrivain
            }).ToList();
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Numero";
            comboBox1.SelectionChangeCommitted += ComboBox1_SelectionChangeCommitted;
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            crpt c = new crpt();
            c.SetParameterValue("Num_Ecrivain", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = c;
           
        }
    }
}
