namespace gbs_gcr1.Forms
{
    partial class visiteur
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
            this.cbsearchVisiteur = new System.Windows.Forms.ComboBox();
            this.cbSecteur = new System.Windows.Forms.ComboBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbLabo = new System.Windows.Forms.ComboBox();
            this.lblLabo = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblChercher = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbTypeemploye = new System.Windows.Forms.ComboBox();
            this.lblTypeemploye = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnnouvVIS = new System.Windows.Forms.Button();
            this.btnMajVIS = new System.Windows.Forms.Button();
            this.btnSupVIS = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbsearchVisiteur
            // 
            this.cbsearchVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbsearchVisiteur.FormattingEnabled = true;
            this.cbsearchVisiteur.Location = new System.Drawing.Point(238, 3);
            this.cbsearchVisiteur.Name = "cbsearchVisiteur";
            this.cbsearchVisiteur.Size = new System.Drawing.Size(379, 33);
            this.cbsearchVisiteur.TabIndex = 22;
            this.cbsearchVisiteur.SelectedIndexChanged += new System.EventHandler(this.cbsearchVisiteur_SelectedIndexChanged);
            // 
            // cbSecteur
            // 
            this.cbSecteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSecteur.Location = new System.Drawing.Point(238, 445);
            this.cbSecteur.Name = "cbSecteur";
            this.cbSecteur.Size = new System.Drawing.Size(379, 33);
            this.cbSecteur.TabIndex = 21;
            this.cbSecteur.SelectedIndexChanged += new System.EventHandler(this.cbSecteur_SelectedIndexChanged);
            // 
            // tbVille
            // 
            this.tbVille.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbVille.Location = new System.Drawing.Point(623, 363);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(389, 31);
            this.tbVille.TabIndex = 20;
            // 
            // tbCP
            // 
            this.tbCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCP.Location = new System.Drawing.Point(238, 363);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(379, 31);
            this.tbCP.TabIndex = 19;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAdresse.Location = new System.Drawing.Point(238, 282);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(379, 31);
            this.tbAdresse.TabIndex = 18;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrenom.Location = new System.Drawing.Point(238, 216);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(379, 31);
            this.tbPrenom.TabIndex = 17;
            // 
            // tbNom
            // 
            this.tbNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNom.Location = new System.Drawing.Point(238, 142);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(379, 31);
            this.tbNom.TabIndex = 16;
            // 
            // cbLabo
            // 
            this.cbLabo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLabo.FormattingEnabled = true;
            this.cbLabo.Location = new System.Drawing.Point(238, 528);
            this.cbLabo.Name = "cbLabo";
            this.cbLabo.Size = new System.Drawing.Size(379, 33);
            this.cbLabo.TabIndex = 15;
            this.cbLabo.SelectedIndexChanged += new System.EventHandler(this.cbLabo_SelectedIndexChanged);
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLabo.Font = new System.Drawing.Font("Garamond", 11.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLabo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLabo.Location = new System.Drawing.Point(59, 525);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(173, 88);
            this.lblLabo.TabIndex = 10;
            this.lblLabo.Text = "Laboratoire";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSecteur.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSecteur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSecteur.Location = new System.Drawing.Point(99, 442);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(133, 83);
            this.lblSecteur.TabIndex = 9;
            this.lblSecteur.Text = "Secteur";
            this.lblSecteur.Click += new System.EventHandler(this.lblCoeff_Click);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVille.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVille.Location = new System.Drawing.Point(142, 360);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(90, 82);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAdresse.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdresse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAdresse.Location = new System.Drawing.Point(93, 279);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(139, 81);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrenom.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrenom.Location = new System.Drawing.Point(91, 213);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(141, 66);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNom.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNom.Location = new System.Drawing.Point(133, 139);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(99, 74);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // lblChercher
            // 
            this.lblChercher.AutoSize = true;
            this.lblChercher.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChercher.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblChercher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChercher.Location = new System.Drawing.Point(72, 0);
            this.lblChercher.Name = "lblChercher";
            this.lblChercher.Size = new System.Drawing.Size(160, 139);
            this.lblChercher.TabIndex = 1;
            this.lblChercher.Text = "Chercher";
            this.lblChercher.Click += new System.EventHandler(this.lblChercher_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChercher.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnChercher.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChercher.Location = new System.Drawing.Point(623, 3);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(389, 68);
            this.btnChercher.TabIndex = 0;
            this.btnChercher.Text = "Ok";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.98077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.01923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tableLayoutPanel1.Controls.Add(this.btnChercher, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChercher, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrenom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAdresse, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVille, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSecteur, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblLabo, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbLabo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbNom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPrenom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAdresse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbCP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbVille, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbSecteur, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbsearchVisiteur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTypeemploye, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTypeemploye, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 725);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cbTypeemploye
            // 
            this.cbTypeemploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTypeemploye.FormattingEnabled = true;
            this.cbTypeemploye.Location = new System.Drawing.Point(238, 616);
            this.cbTypeemploye.Name = "cbTypeemploye";
            this.cbTypeemploye.Size = new System.Drawing.Size(379, 33);
            this.cbTypeemploye.TabIndex = 23;
            this.cbTypeemploye.SelectedIndexChanged += new System.EventHandler(this.cbTypeemploye_SelectedIndexChanged);
            // 
            // lblTypeemploye
            // 
            this.lblTypeemploye.AutoSize = true;
            this.lblTypeemploye.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTypeemploye.Font = new System.Drawing.Font("Garamond", 11.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTypeemploye.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTypeemploye.Location = new System.Drawing.Point(93, 613);
            this.lblTypeemploye.Name = "lblTypeemploye";
            this.lblTypeemploye.Size = new System.Drawing.Size(139, 112);
            this.lblTypeemploye.TabIndex = 24;
            this.lblTypeemploye.Text = "Fonction";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnnouvVIS, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMajVIS, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSupVIS, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(623, 616);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 106);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // btnnouvVIS
            // 
            this.btnnouvVIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnnouvVIS.Location = new System.Drawing.Point(3, 3);
            this.btnnouvVIS.Name = "btnnouvVIS";
            this.btnnouvVIS.Size = new System.Drawing.Size(188, 47);
            this.btnnouvVIS.TabIndex = 0;
            this.btnnouvVIS.Text = "Nouveau";
            this.btnnouvVIS.UseVisualStyleBackColor = true;
            this.btnnouvVIS.Click += new System.EventHandler(this.btnnouvVIS_Click_1);
            // 
            // btnMajVIS
            // 
            this.btnMajVIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMajVIS.Location = new System.Drawing.Point(197, 3);
            this.btnMajVIS.Name = "btnMajVIS";
            this.btnMajVIS.Size = new System.Drawing.Size(189, 47);
            this.btnMajVIS.TabIndex = 1;
            this.btnMajVIS.Text = "Modifier";
            this.btnMajVIS.UseVisualStyleBackColor = true;
            this.btnMajVIS.Click += new System.EventHandler(this.btnMajVIS_Click);
            // 
            // btnSupVIS
            // 
            this.btnSupVIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupVIS.Location = new System.Drawing.Point(3, 56);
            this.btnSupVIS.Name = "btnSupVIS";
            this.btnSupVIS.Size = new System.Drawing.Size(188, 47);
            this.btnSupVIS.TabIndex = 2;
            this.btnSupVIS.Text = "Supprimer";
            this.btnSupVIS.UseVisualStyleBackColor = true;
            this.btnSupVIS.Click += new System.EventHandler(this.btnSupVIS_Click);
            // 
            // visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "visiteur";
            this.Text = "visiteur";
            this.Load += new System.EventHandler(this.visiteur_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbsearchVisiteur;
        private System.Windows.Forms.ComboBox cbSecteur;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.ComboBox cbLabo;
        private System.Windows.Forms.Label lblLabo;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblChercher;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbTypeemploye;
        private System.Windows.Forms.Label lblTypeemploye;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnnouvVIS;
        private System.Windows.Forms.Button btnMajVIS;
        private System.Windows.Forms.Button btnSupVIS;
    }
}