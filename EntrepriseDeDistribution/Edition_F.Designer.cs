namespace EntrepriseDeDistribution
{
    partial class Edition_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edition_F));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_annee = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_livre = new System.Windows.Forms.ComboBox();
            this.cb_editeur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_delet);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Location = new System.Drawing.Point(335, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 150);
            this.panel2.TabIndex = 8;
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.Color.Red;
            this.btn_delet.FlatAppearance.BorderSize = 0;
            this.btn_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delet.Image = ((System.Drawing.Image)(resources.GetObject("btn_delet.Image")));
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.Location = new System.Drawing.Point(20, 97);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(109, 32);
            this.btn_delet.TabIndex = 3;
            this.btn_delet.Text = "SUPRIMER";
            this.btn_delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Green;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(20, 57);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(109, 32);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "MODIFIER";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(20, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 32);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "AJOUTER";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dt_annee);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_livre);
            this.panel1.Controls.Add(this.cb_editeur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 150);
            this.panel1.TabIndex = 7;
            // 
            // dt_annee
            // 
            this.dt_annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_annee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_annee.Location = new System.Drawing.Point(132, 106);
            this.dt_annee.Name = "dt_annee";
            this.dt_annee.Size = new System.Drawing.Size(174, 23);
            this.dt_annee.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom Editeur";
            // 
            // cb_livre
            // 
            this.cb_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_livre.FormattingEnabled = true;
            this.cb_livre.Location = new System.Drawing.Point(132, 22);
            this.cb_livre.Name = "cb_livre";
            this.cb_livre.Size = new System.Drawing.Size(174, 24);
            this.cb_livre.TabIndex = 6;
            // 
            // cb_editeur
            // 
            this.cb_editeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_editeur.FormattingEnabled = true;
            this.cb_editeur.Location = new System.Drawing.Point(132, 62);
            this.cb_editeur.Name = "cb_editeur";
            this.cb_editeur.Size = new System.Drawing.Size(174, 24);
            this.cb_editeur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Edition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titre Livre";
            // 
            // Edition_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 175);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Edition_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edition";
            this.Load += new System.EventHandler(this.Edition_F_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_editeur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_annee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_livre;
    }
}