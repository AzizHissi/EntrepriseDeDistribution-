namespace EntrepriseDeDistribution
{
    partial class ChercherEditeur_F
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_depot = new System.Windows.Forms.ComboBox();
            this.cb_editeur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Liste Des Livres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 239);
            this.dataGridView1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_editeur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 59);
            this.panel1.TabIndex = 14;
            // 
            // cb_depot
            // 
            this.cb_depot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_depot.FormattingEnabled = true;
            this.cb_depot.Location = new System.Drawing.Point(585, 369);
            this.cb_depot.Name = "cb_depot";
            this.cb_depot.Size = new System.Drawing.Size(128, 24);
            this.cb_depot.TabIndex = 23;
            // 
            // cb_editeur
            // 
            this.cb_editeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_editeur.FormattingEnabled = true;
            this.cb_editeur.Location = new System.Drawing.Point(284, 16);
            this.cb_editeur.Name = "cb_editeur";
            this.cb_editeur.Size = new System.Drawing.Size(174, 24);
            this.cb_editeur.TabIndex = 22;
            this.cb_editeur.SelectedIndexChanged += new System.EventHandler(this.cb_editeur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom Depot :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom Editeur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Livres en Stocke :";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(585, 399);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(128, 23);
            this.txt_total.TabIndex = 18;
            // 
            // ChercherEditeur_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_depot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ChercherEditeur_F";
            this.Size = new System.Drawing.Size(747, 433);
            this.Load += new System.EventHandler(this.ChercherEditeur_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox cb_depot;
        private System.Windows.Forms.ComboBox cb_editeur;
    }
}
