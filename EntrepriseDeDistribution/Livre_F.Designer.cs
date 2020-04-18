namespace EntrepriseDeDistribution
{
    partial class Livre_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livre_F));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liste Des Livres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 170);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(36, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 41);
            this.panel3.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(538, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 32);
            this.button8.TabIndex = 6;
            this.button8.Text = "DERNIER";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(371, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 32);
            this.button7.TabIndex = 5;
            this.button7.Text = "SUIVANT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(206, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 32);
            this.button6.TabIndex = 4;
            this.button6.Text = "PREVIOUS";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(32, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "PREMIER";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_delet);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Location = new System.Drawing.Point(392, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 162);
            this.panel2.TabIndex = 6;
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.Color.Red;
            this.btn_delet.FlatAppearance.BorderSize = 0;
            this.btn_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delet.Image = ((System.Drawing.Image)(resources.GetObject("btn_delet.Image")));
            this.btn_delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet.Location = new System.Drawing.Point(170, 87);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(109, 32);
            this.btn_delet.TabIndex = 3;
            this.btn_delet.Text = "SUPRIMER";
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
            this.btn_edit.Location = new System.Drawing.Point(34, 87);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(109, 32);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "MODIFIER";
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
            this.btn_add.Location = new System.Drawing.Point(170, 34);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 32);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "AJOUTER";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Gold;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(34, 34);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(109, 32);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "NOUVEAU";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_theme);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_titre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 162);
            this.panel1.TabIndex = 5;
            // 
            // cb_theme
            // 
            this.cb_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(132, 94);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(174, 24);
            this.cb_theme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Theme";
            // 
            // txt_titre
            // 
            this.txt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.Location = new System.Drawing.Point(132, 51);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(174, 23);
            this.txt_titre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titre Livre";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(132, 11);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(174, 23);
            this.txt_num.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero Livre";
            // 
            // Livre_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Livre_F";
            this.Size = new System.Drawing.Size(747, 433);
            this.Load += new System.EventHandler(this.Livre_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_theme;
    }
}
