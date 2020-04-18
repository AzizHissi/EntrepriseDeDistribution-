namespace EntrepriseDeDistribution
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parNomEditeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editeur1 = new EntrepriseDeDistribution.Editeur();
            this.livre1 = new EntrepriseDeDistribution.Livre();
            this.chercheDate1 = new EntrepriseDeDistribution.ChercheDate();
            this.chercherEditeur1 = new EntrepriseDeDistribution.ChercherEditeur();
            this.report1 = new EntrepriseDeDistribution.Report();
            this.graphe1 = new EntrepriseDeDistribution.Graphe();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(986, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeurToolStripMenuItem,
            this.livreToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionToolStripMenuItem.Image")));
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // editeurToolStripMenuItem
            // 
            this.editeurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editeurToolStripMenuItem.Image")));
            this.editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            this.editeurToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.editeurToolStripMenuItem.Text = "Editeur";
            this.editeurToolStripMenuItem.Click += new System.EventHandler(this.editeurToolStripMenuItem_Click);
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livreToolStripMenuItem.Image")));
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.livreToolStripMenuItem.Text = "Livre";
            this.livreToolStripMenuItem.Click += new System.EventHandler(this.livreToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.editionToolStripMenuItem.Text = "Edition";
            this.editionToolStripMenuItem.Click += new System.EventHandler(this.editionToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parDateToolStripMenuItem,
            this.parNomEditeurToolStripMenuItem});
            this.rechercheToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rechercheToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rechercheToolStripMenuItem.Image")));
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(134, 23);
            this.rechercheToolStripMenuItem.Text = "Recherche livres";
            // 
            // parDateToolStripMenuItem
            // 
            this.parDateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parDateToolStripMenuItem.Image")));
            this.parDateToolStripMenuItem.Name = "parDateToolStripMenuItem";
            this.parDateToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.parDateToolStripMenuItem.Text = "Par date";
            this.parDateToolStripMenuItem.Click += new System.EventHandler(this.parDateToolStripMenuItem_Click);
            // 
            // parNomEditeurToolStripMenuItem
            // 
            this.parNomEditeurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parNomEditeurToolStripMenuItem.Image")));
            this.parNomEditeurToolStripMenuItem.Name = "parNomEditeurToolStripMenuItem";
            this.parNomEditeurToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.parNomEditeurToolStripMenuItem.Text = "Par nom Editeur";
            this.parNomEditeurToolStripMenuItem.Click += new System.EventHandler(this.parNomEditeurToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statistiqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statistiqueToolStripMenuItem.Image")));
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.statistiqueToolStripMenuItem.Text = "Statistique ";
            this.statistiqueToolStripMenuItem.Click += new System.EventHandler(this.statistiqueToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quiterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quiterToolStripMenuItem.Image")));
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.quiterToolStripMenuItem.Text = "Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editeur1);
            this.panel1.Controls.Add(this.livre1);
            this.panel1.Controls.Add(this.chercheDate1);
            this.panel1.Controls.Add(this.chercherEditeur1);
            this.panel1.Controls.Add(this.report1);
            this.panel1.Controls.Add(this.graphe1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 530);
            this.panel1.TabIndex = 1;
            // 
            // editeur1
            // 
            this.editeur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editeur1.Location = new System.Drawing.Point(0, 0);
            this.editeur1.Margin = new System.Windows.Forms.Padding(4);
            this.editeur1.Name = "editeur1";
            this.editeur1.Size = new System.Drawing.Size(986, 530);
            this.editeur1.TabIndex = 1;
            // 
            // livre1
            // 
            this.livre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livre1.Location = new System.Drawing.Point(0, 0);
            this.livre1.Margin = new System.Windows.Forms.Padding(4);
            this.livre1.Name = "livre1";
            this.livre1.Size = new System.Drawing.Size(986, 530);
            this.livre1.TabIndex = 0;
            // 
            // chercheDate1
            // 
            this.chercheDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chercheDate1.Location = new System.Drawing.Point(0, 0);
            this.chercheDate1.Margin = new System.Windows.Forms.Padding(4);
            this.chercheDate1.Name = "chercheDate1";
            this.chercheDate1.Size = new System.Drawing.Size(986, 530);
            this.chercheDate1.TabIndex = 2;
            // 
            // chercherEditeur1
            // 
            this.chercherEditeur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chercherEditeur1.Location = new System.Drawing.Point(0, 0);
            this.chercherEditeur1.Margin = new System.Windows.Forms.Padding(4);
            this.chercherEditeur1.Name = "chercherEditeur1";
            this.chercherEditeur1.Size = new System.Drawing.Size(986, 530);
            this.chercherEditeur1.TabIndex = 3;
            // 
            // report1
            // 
            this.report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report1.Location = new System.Drawing.Point(0, 0);
            this.report1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(986, 530);
            this.report1.TabIndex = 4;
            // 
            // graphe1
            // 
            this.graphe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphe1.Location = new System.Drawing.Point(0, 0);
            this.graphe1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graphe1.Name = "graphe1";
            this.graphe1.Size = new System.Drawing.Size(986, 530);
            this.graphe1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parNomEditeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Editeur editeur1;
        private Livre livre1;
        private ChercheDate chercheDate1;
        private ChercherEditeur chercherEditeur1;
        private Report report1;
        private Graphe graphe1;
    }
}

