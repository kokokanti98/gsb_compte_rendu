namespace gbs_gcr1.Forms
{
    partial class medicament
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
            this.data_medicament1 = new gbs_gcr1.data_medicament1();
            this.rtbEI = new System.Windows.Forms.RichTextBox();
            this.rtbCI = new System.Windows.Forms.RichTextBox();
            this.tbPE = new System.Windows.Forms.TextBox();
            this.cbFamille = new System.Windows.Forms.ComboBox();
            this.lblPE = new System.Windows.Forms.Label();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblLabo = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblComposition = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.lblNC = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblChercher = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSearchMedicament = new System.Windows.Forms.ComboBox();
            this.btnsearchMed = new System.Windows.Forms.Button();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.btnSupMed = new System.Windows.Forms.Button();
            this.btnSMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_medicament1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_medicament1
            // 
            this.data_medicament1.DataSetName = "data_medicament1";
            this.data_medicament1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtbEI
            // 
            this.rtbEI.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbEI.Location = new System.Drawing.Point(263, 379);
            this.rtbEI.Name = "rtbEI";
            this.rtbEI.Size = new System.Drawing.Size(356, 86);
            this.rtbEI.TabIndex = 30;
            this.rtbEI.Text = "";
            this.rtbEI.TextChanged += new System.EventHandler(this.rtbEI_TextChanged);
            // 
            // rtbCI
            // 
            this.rtbCI.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbCI.Location = new System.Drawing.Point(263, 471);
            this.rtbCI.Name = "rtbCI";
            this.rtbCI.Size = new System.Drawing.Size(356, 85);
            this.rtbCI.TabIndex = 29;
            this.rtbCI.Text = "";
            this.rtbCI.TextChanged += new System.EventHandler(this.rtbCI_TextChanged);
            // 
            // tbPE
            // 
            this.tbPE.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPE.Location = new System.Drawing.Point(263, 562);
            this.tbPE.Name = "tbPE";
            this.tbPE.Size = new System.Drawing.Size(356, 31);
            this.tbPE.TabIndex = 28;
            this.tbPE.TextChanged += new System.EventHandler(this.tbPE_TextChanged);
            // 
            // cbFamille
            // 
            this.cbFamille.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFamille.FormattingEnabled = true;
            this.cbFamille.Location = new System.Drawing.Point(263, 216);
            this.cbFamille.Name = "cbFamille";
            this.cbFamille.Size = new System.Drawing.Size(356, 33);
            this.cbFamille.TabIndex = 27;
            this.cbFamille.SelectedIndexChanged += new System.EventHandler(this.cbFamille_SelectedIndexChanged);
            // 
            // lblPE
            // 
            this.lblPE.AutoSize = true;
            this.lblPE.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPE.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPE.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPE.Location = new System.Drawing.Point(39, 559);
            this.lblPE.Name = "lblPE";
            this.lblPE.Size = new System.Drawing.Size(218, 56);
            this.lblPE.TabIndex = 26;
            this.lblPE.Text = "Prix Echantillon";
            // 
            // tbCP
            // 
            this.tbCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCP.Location = new System.Drawing.Point(263, 297);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(356, 31);
            this.tbCP.TabIndex = 19;
            this.tbCP.TextChanged += new System.EventHandler(this.tbCP_TextChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrenom.Location = new System.Drawing.Point(263, 150);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(356, 31);
            this.tbPrenom.TabIndex = 17;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // tbNom
            // 
            this.tbNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNom.Location = new System.Drawing.Point(263, 94);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(356, 31);
            this.tbNom.TabIndex = 16;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLabo.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold);
            this.lblLabo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLabo.Location = new System.Drawing.Point(24, 468);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(233, 91);
            this.lblLabo.TabIndex = 10;
            this.lblLabo.Text = "Contre Indication";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSecteur.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold);
            this.lblSecteur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSecteur.Location = new System.Drawing.Point(10, 376);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(247, 92);
            this.lblSecteur.TabIndex = 9;
            this.lblSecteur.Text = "Effets Indésirables";
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblComposition.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold);
            this.lblComposition.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblComposition.Location = new System.Drawing.Point(84, 294);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(173, 82);
            this.lblComposition.TabIndex = 8;
            this.lblComposition.Text = "Composition";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFamille.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold);
            this.lblFamille.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFamille.Location = new System.Drawing.Point(148, 213);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(109, 81);
            this.lblFamille.TabIndex = 7;
            this.lblFamille.Text = "Famille";
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNC.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold);
            this.lblNC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNC.Location = new System.Drawing.Point(7, 147);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(250, 66);
            this.lblNC.TabIndex = 6;
            this.lblNC.Text = "Nom Commerciale";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCode.Font = new System.Drawing.Font("Garamond", 10.875F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCode.Location = new System.Drawing.Point(177, 91);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(80, 56);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code";
            // 
            // lblChercher
            // 
            this.lblChercher.AutoSize = true;
            this.lblChercher.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChercher.Font = new System.Drawing.Font("Garamond", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblChercher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChercher.Location = new System.Drawing.Point(97, 0);
            this.lblChercher.Name = "lblChercher";
            this.lblChercher.Size = new System.Drawing.Size(160, 91);
            this.lblChercher.TabIndex = 1;
            this.lblChercher.Text = "Chercher";
            this.lblChercher.Click += new System.EventHandler(this.lblChercher_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.75182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.24818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel1.Controls.Add(this.lblChercher, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFamille, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblComposition, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSecteur, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblLabo, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbNom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPrenom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbCP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPE, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbFamille, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPE, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.rtbCI, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.rtbEI, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbSearchMedicament, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsearchMed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddMed, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSupMed, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSMed, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 679);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cbSearchMedicament
            // 
            this.cbSearchMedicament.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSearchMedicament.FormattingEnabled = true;
            this.cbSearchMedicament.Location = new System.Drawing.Point(263, 3);
            this.cbSearchMedicament.Name = "cbSearchMedicament";
            this.cbSearchMedicament.Size = new System.Drawing.Size(356, 33);
            this.cbSearchMedicament.TabIndex = 31;
            this.cbSearchMedicament.SelectedIndexChanged += new System.EventHandler(this.cbSearchMedicament_SelectedIndexChanged);
            // 
            // btnsearchMed
            // 
            this.btnsearchMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsearchMed.Location = new System.Drawing.Point(625, 3);
            this.btnsearchMed.Name = "btnsearchMed";
            this.btnsearchMed.Size = new System.Drawing.Size(290, 85);
            this.btnsearchMed.TabIndex = 32;
            this.btnsearchMed.Text = "Ok";
            this.btnsearchMed.UseVisualStyleBackColor = true;
            this.btnsearchMed.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddMed
            // 
            this.btnAddMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMed.Location = new System.Drawing.Point(3, 618);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(254, 58);
            this.btnAddMed.TabIndex = 33;
            this.btnAddMed.Text = "Ajouter";
            this.btnAddMed.UseVisualStyleBackColor = true;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnSupMed
            // 
            this.btnSupMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupMed.Location = new System.Drawing.Point(263, 618);
            this.btnSupMed.Name = "btnSupMed";
            this.btnSupMed.Size = new System.Drawing.Size(356, 58);
            this.btnSupMed.TabIndex = 34;
            this.btnSupMed.Text = "Modifier";
            this.btnSupMed.UseVisualStyleBackColor = true;
            this.btnSupMed.Click += new System.EventHandler(this.btnSupMed_Click);
            // 
            // btnSMed
            // 
            this.btnSMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSMed.Location = new System.Drawing.Point(625, 618);
            this.btnSMed.Name = "btnSMed";
            this.btnSMed.Size = new System.Drawing.Size(290, 58);
            this.btnSMed.TabIndex = 35;
            this.btnSMed.Text = "Supprimer";
            this.btnSMed.UseVisualStyleBackColor = true;
            this.btnSMed.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "medicament";
            this.Text = "medicament";
            ((System.ComponentModel.ISupportInitialize)(this.data_medicament1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private data_medicament1 data_medicament1;
        private System.Windows.Forms.RichTextBox rtbEI;
        private System.Windows.Forms.RichTextBox rtbCI;
        private System.Windows.Forms.TextBox tbPE;
        private System.Windows.Forms.ComboBox cbFamille;
        private System.Windows.Forms.Label lblPE;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblLabo;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblChercher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbSearchMedicament;
        private System.Windows.Forms.Button btnsearchMed;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnSupMed;
        private System.Windows.Forms.Button btnSMed;
    }
}