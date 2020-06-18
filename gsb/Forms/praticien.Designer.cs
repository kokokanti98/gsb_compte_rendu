namespace gbs_gcr1.Forms
{
    partial class praticien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Button();
            this.lblChercher = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCoeff = new System.Windows.Forms.Label();
            this.lblLieuexercice = new System.Windows.Forms.Label();
            this.numNumero = new System.Windows.Forms.NumericUpDown();
            this.cbChercher = new System.Windows.Forms.ComboBox();
            this.cbLieuexercice = new System.Windows.Forms.ComboBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCoeff = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSupprPraticien = new System.Windows.Forms.Button();
            this.btnMAJpraticien = new System.Windows.Forms.Button();
            this.btncreer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.97474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.02526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumero, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChercher, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChercher, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPrenom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAdresse, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblVille, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCoeff, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblLieuexercice, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.numNumero, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbChercher, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbLieuexercice, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbNom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPrenom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbAdresse, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbCP, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbVille, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbCoeff, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 693);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumero.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumero.Location = new System.Drawing.Point(45, 105);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(149, 57);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // btnChercher
            // 
            this.btnChercher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChercher.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnChercher.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChercher.Location = new System.Drawing.Point(682, 3);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(357, 99);
            this.btnChercher.TabIndex = 0;
            this.btnChercher.Text = "Ok";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // lblChercher
            // 
            this.lblChercher.AutoSize = true;
            this.lblChercher.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChercher.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblChercher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChercher.Location = new System.Drawing.Point(34, 0);
            this.lblChercher.Name = "lblChercher";
            this.lblChercher.Size = new System.Drawing.Size(160, 105);
            this.lblChercher.TabIndex = 1;
            this.lblChercher.Text = "Chercher";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNom.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNom.Location = new System.Drawing.Point(95, 162);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(99, 68);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrenom.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrenom.Location = new System.Drawing.Point(53, 230);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(141, 58);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAdresse.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdresse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAdresse.Location = new System.Drawing.Point(55, 288);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(139, 60);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVille.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVille.Location = new System.Drawing.Point(104, 348);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(90, 62);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "Ville";
            // 
            // lblCoeff
            // 
            this.lblCoeff.AutoSize = true;
            this.lblCoeff.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCoeff.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCoeff.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCoeff.Location = new System.Drawing.Point(7, 410);
            this.lblCoeff.Name = "lblCoeff";
            this.lblCoeff.Size = new System.Drawing.Size(187, 149);
            this.lblCoeff.TabIndex = 9;
            this.lblCoeff.Text = "Coefficient Notorie";
            // 
            // lblLieuexercice
            // 
            this.lblLieuexercice.AutoSize = true;
            this.lblLieuexercice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLieuexercice.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLieuexercice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLieuexercice.Location = new System.Drawing.Point(19, 559);
            this.lblLieuexercice.Name = "lblLieuexercice";
            this.lblLieuexercice.Size = new System.Drawing.Size(175, 64);
            this.lblLieuexercice.TabIndex = 10;
            this.lblLieuexercice.Text = "Lieu d\'exercice";
            // 
            // numNumero
            // 
            this.numNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.numNumero.Location = new System.Drawing.Point(200, 108);
            this.numNumero.Name = "numNumero";
            this.numNumero.Size = new System.Drawing.Size(476, 31);
            this.numNumero.TabIndex = 13;
            this.numNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumero.ValueChanged += new System.EventHandler(this.numNumero_ValueChanged);
            // 
            // cbChercher
            // 
            this.cbChercher.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbChercher.FormattingEnabled = true;
            this.cbChercher.Location = new System.Drawing.Point(200, 3);
            this.cbChercher.Name = "cbChercher";
            this.cbChercher.Size = new System.Drawing.Size(476, 33);
            this.cbChercher.TabIndex = 14;
            this.cbChercher.SelectedIndexChanged += new System.EventHandler(this.cbChercher_SelectedIndexChanged);
            // 
            // cbLieuexercice
            // 
            this.cbLieuexercice.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLieuexercice.FormattingEnabled = true;
            this.cbLieuexercice.Items.AddRange(new object[] {
            "Medecin de sante",
            "Gynecologue"});
            this.cbLieuexercice.Location = new System.Drawing.Point(200, 562);
            this.cbLieuexercice.Name = "cbLieuexercice";
            this.cbLieuexercice.Size = new System.Drawing.Size(476, 33);
            this.cbLieuexercice.TabIndex = 15;
            this.cbLieuexercice.SelectedIndexChanged += new System.EventHandler(this.cbLieuexercice_SelectedIndexChanged);
            // 
            // tbNom
            // 
            this.tbNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNom.Location = new System.Drawing.Point(200, 165);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(476, 31);
            this.tbNom.TabIndex = 16;
            this.tbNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrenom.Location = new System.Drawing.Point(200, 233);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(476, 31);
            this.tbPrenom.TabIndex = 17;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAdresse.Location = new System.Drawing.Point(200, 291);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(476, 31);
            this.tbAdresse.TabIndex = 18;
            // 
            // tbCP
            // 
            this.tbCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCP.Location = new System.Drawing.Point(200, 351);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(476, 31);
            this.tbCP.TabIndex = 19;
            // 
            // tbVille
            // 
            this.tbVille.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbVille.Location = new System.Drawing.Point(682, 351);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(357, 31);
            this.tbVille.TabIndex = 20;
            // 
            // tbCoeff
            // 
            this.tbCoeff.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCoeff.Location = new System.Drawing.Point(200, 413);
            this.tbCoeff.Name = "tbCoeff";
            this.tbCoeff.Size = new System.Drawing.Size(476, 31);
            this.tbCoeff.TabIndex = 21;
            this.tbCoeff.TextChanged += new System.EventHandler(this.tbCoeff_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSupprPraticien, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMAJpraticien, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btncreer, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(682, 413);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 143);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // btnSupprPraticien
            // 
            this.btnSupprPraticien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupprPraticien.Location = new System.Drawing.Point(3, 74);
            this.btnSupprPraticien.Name = "btnSupprPraticien";
            this.btnSupprPraticien.Size = new System.Drawing.Size(172, 66);
            this.btnSupprPraticien.TabIndex = 1;
            this.btnSupprPraticien.Text = "Supprimer";
            this.btnSupprPraticien.UseVisualStyleBackColor = true;
            this.btnSupprPraticien.Click += new System.EventHandler(this.btnSupprPraticien_Click);
            // 
            // btnMAJpraticien
            // 
            this.btnMAJpraticien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMAJpraticien.Location = new System.Drawing.Point(181, 3);
            this.btnMAJpraticien.Name = "btnMAJpraticien";
            this.btnMAJpraticien.Size = new System.Drawing.Size(173, 65);
            this.btnMAJpraticien.TabIndex = 2;
            this.btnMAJpraticien.Text = "Modifier";
            this.btnMAJpraticien.UseVisualStyleBackColor = true;
            this.btnMAJpraticien.Click += new System.EventHandler(this.btnMAJpraticien_Click);
            // 
            // btncreer
            // 
            this.btncreer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncreer.Location = new System.Drawing.Point(181, 74);
            this.btncreer.Name = "btncreer";
            this.btncreer.Size = new System.Drawing.Size(173, 66);
            this.btncreer.TabIndex = 3;
            this.btncreer.Text = "Nouveau";
            this.btncreer.UseVisualStyleBackColor = true;
            this.btncreer.Click += new System.EventHandler(this.btncreer_Click);
            // 
            // praticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "praticien";
            this.Text = "praticien";
            this.Load += new System.EventHandler(this.praticien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Label lblChercher;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCoeff;
        private System.Windows.Forms.Label lblLieuexercice;
        private System.Windows.Forms.NumericUpDown numNumero;
        private System.Windows.Forms.ComboBox cbChercher;
        private System.Windows.Forms.ComboBox cbLieuexercice;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCoeff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSupprPraticien;
        private System.Windows.Forms.Button btnMAJpraticien;
        private System.Windows.Forms.Button btncreer;
    }
}