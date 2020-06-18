namespace gbs_gcr1.Forms
{
    partial class compte_rendu
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
            this.btnChercher = new System.Windows.Forms.Button();
            this.lblChercher = new System.Windows.Forms.Label();
            this.lblNumCR = new System.Windows.Forms.Label();
            this.lblPraCR = new System.Windows.Forms.Label();
            this.lblDtCR = new System.Windows.Forms.Label();
            this.lblMV = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lblOE = new System.Windows.Forms.Label();
            this.cbChercher = new System.Windows.Forms.ComboBox();
            this.tbnumrapport = new System.Windows.Forms.TextBox();
            this.dtCR = new System.Windows.Forms.DateTimePicker();
            this.cbPraCR = new System.Windows.Forms.ComboBox();
            this.rtbBilan = new System.Windows.Forms.RichTextBox();
            this.dtgvEchantillon = new System.Windows.Forms.DataGridView();
            this.rtbMotif = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnModifEchantillon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSapport = new System.Windows.Forms.Button();
            this.btnModrapport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEchantillon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16076F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.83923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.btnChercher, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChercher, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumCR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPraCR, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDtCR, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMV, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBilan, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblOE, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbChercher, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbnumrapport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtCR, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbPraCR, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbBilan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtgvEchantillon, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.rtbMotif, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSapport, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnModrapport, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 732);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnChercher
            // 
            this.btnChercher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChercher.Font = new System.Drawing.Font("Garamond", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChercher.Location = new System.Drawing.Point(831, 3);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(345, 68);
            this.btnChercher.TabIndex = 0;
            this.btnChercher.Text = "Ok";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // lblChercher
            // 
            this.lblChercher.AutoSize = true;
            this.lblChercher.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChercher.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChercher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChercher.Location = new System.Drawing.Point(86, 0);
            this.lblChercher.Name = "lblChercher";
            this.lblChercher.Size = new System.Drawing.Size(103, 131);
            this.lblChercher.TabIndex = 1;
            this.lblChercher.Text = "Chercher";
            this.lblChercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumCR
            // 
            this.lblNumCR.AutoSize = true;
            this.lblNumCR.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumCR.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumCR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumCR.Location = new System.Drawing.Point(92, 131);
            this.lblNumCR.Name = "lblNumCR";
            this.lblNumCR.Size = new System.Drawing.Size(97, 89);
            this.lblNumCR.TabIndex = 5;
            this.lblNumCR.Text = "Numero Rapport";
            this.lblNumCR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPraCR
            // 
            this.lblPraCR.AutoSize = true;
            this.lblPraCR.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPraCR.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPraCR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPraCR.Location = new System.Drawing.Point(85, 220);
            this.lblPraCR.Name = "lblPraCR";
            this.lblPraCR.Size = new System.Drawing.Size(104, 66);
            this.lblPraCR.TabIndex = 6;
            this.lblPraCR.Text = "Praticien";
            this.lblPraCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPraCR.Click += new System.EventHandler(this.lblPraCR_Click);
            // 
            // lblDtCR
            // 
            this.lblDtCR.AutoSize = true;
            this.lblDtCR.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDtCR.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDtCR.Location = new System.Drawing.Point(16, 286);
            this.lblDtCR.Name = "lblDtCR";
            this.lblDtCR.Size = new System.Drawing.Size(173, 81);
            this.lblDtCR.TabIndex = 7;
            this.lblDtCR.Text = "Date de rapport";
            this.lblDtCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMV
            // 
            this.lblMV.AutoSize = true;
            this.lblMV.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMV.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMV.Location = new System.Drawing.Point(30, 367);
            this.lblMV.Name = "lblMV";
            this.lblMV.Size = new System.Drawing.Size(159, 63);
            this.lblMV.TabIndex = 8;
            this.lblMV.Text = "Motif de visite";
            this.lblMV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBilan.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBilan.Location = new System.Drawing.Point(123, 430);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(66, 70);
            this.lblBilan.TabIndex = 9;
            this.lblBilan.Text = "Bilan";
            this.lblBilan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOE
            // 
            this.lblOE.AutoSize = true;
            this.lblOE.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOE.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOE.Location = new System.Drawing.Point(54, 500);
            this.lblOE.Name = "lblOE";
            this.lblOE.Size = new System.Drawing.Size(135, 161);
            this.lblOE.TabIndex = 10;
            this.lblOE.Text = "Offres d échantillons";
            this.lblOE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbChercher
            // 
            this.cbChercher.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbChercher.FormattingEnabled = true;
            this.cbChercher.Items.AddRange(new object[] {
            "moi",
            "toi",
            "eux"});
            this.cbChercher.Location = new System.Drawing.Point(195, 3);
            this.cbChercher.Name = "cbChercher";
            this.cbChercher.Size = new System.Drawing.Size(630, 33);
            this.cbChercher.TabIndex = 14;
            this.cbChercher.SelectedIndexChanged += new System.EventHandler(this.cbChercher_SelectedIndexChanged);
            // 
            // tbnumrapport
            // 
            this.tbnumrapport.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbnumrapport.Location = new System.Drawing.Point(195, 134);
            this.tbnumrapport.Name = "tbnumrapport";
            this.tbnumrapport.Size = new System.Drawing.Size(630, 31);
            this.tbnumrapport.TabIndex = 16;
            this.tbnumrapport.TextChanged += new System.EventHandler(this.tbnumrapport_TextChanged);
            // 
            // dtCR
            // 
            this.dtCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtCR.Location = new System.Drawing.Point(195, 289);
            this.dtCR.Name = "dtCR";
            this.dtCR.Size = new System.Drawing.Size(630, 31);
            this.dtCR.TabIndex = 22;
            this.dtCR.Value = new System.DateTime(2019, 3, 23, 17, 46, 0, 0);
            this.dtCR.ValueChanged += new System.EventHandler(this.dtCR_ValueChanged);
            // 
            // cbPraCR
            // 
            this.cbPraCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPraCR.FormattingEnabled = true;
            this.cbPraCR.Location = new System.Drawing.Point(195, 223);
            this.cbPraCR.Name = "cbPraCR";
            this.cbPraCR.Size = new System.Drawing.Size(630, 33);
            this.cbPraCR.TabIndex = 23;
            this.cbPraCR.SelectedIndexChanged += new System.EventHandler(this.cbPraCR_SelectedIndexChanged);
            // 
            // rtbBilan
            // 
            this.rtbBilan.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbBilan.Location = new System.Drawing.Point(195, 433);
            this.rtbBilan.Name = "rtbBilan";
            this.rtbBilan.Size = new System.Drawing.Size(630, 64);
            this.rtbBilan.TabIndex = 24;
            this.rtbBilan.Text = "";
            // 
            // dtgvEchantillon
            // 
            this.dtgvEchantillon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEchantillon.Location = new System.Drawing.Point(195, 503);
            this.dtgvEchantillon.Name = "dtgvEchantillon";
            this.dtgvEchantillon.RowHeadersWidth = 82;
            this.dtgvEchantillon.RowTemplate.Height = 33;
            this.dtgvEchantillon.Size = new System.Drawing.Size(555, 155);
            this.dtgvEchantillon.TabIndex = 25;
            this.dtgvEchantillon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEchantillon_CellContentClick);
            // 
            // rtbMotif
            // 
            this.rtbMotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbMotif.Location = new System.Drawing.Point(195, 370);
            this.rtbMotif.Name = "rtbMotif";
            this.rtbMotif.Size = new System.Drawing.Size(630, 57);
            this.rtbMotif.TabIndex = 26;
            this.rtbMotif.Text = "";
            this.rtbMotif.TextChanged += new System.EventHandler(this.rtbMotif_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.36612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.63388F));
            this.tableLayoutPanel2.Controls.Add(this.btnModifEchantillon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnnew, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(831, 503);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 155);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // btnModifEchantillon
            // 
            this.btnModifEchantillon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifEchantillon.Location = new System.Drawing.Point(3, 3);
            this.btnModifEchantillon.Name = "btnModifEchantillon";
            this.btnModifEchantillon.Size = new System.Drawing.Size(171, 71);
            this.btnModifEchantillon.TabIndex = 28;
            this.btnModifEchantillon.Text = "Modifier";
            this.btnModifEchantillon.UseVisualStyleBackColor = true;
            this.btnModifEchantillon.Click += new System.EventHandler(this.btnModifEchantillon_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(180, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 71);
            this.button1.TabIndex = 29;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 72);
            this.button2.TabIndex = 30;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnew
            // 
            this.btnnew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnnew.Location = new System.Drawing.Point(180, 80);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(162, 72);
            this.btnnew.TabIndex = 31;
            this.btnnew.Text = "Nouveau Rapport";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnSapport
            // 
            this.btnSapport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSapport.Location = new System.Drawing.Point(831, 433);
            this.btnSapport.Name = "btnSapport";
            this.btnSapport.Size = new System.Drawing.Size(345, 64);
            this.btnSapport.TabIndex = 28;
            this.btnSapport.Text = "Supprimer Rapport";
            this.btnSapport.UseVisualStyleBackColor = true;
            this.btnSapport.Click += new System.EventHandler(this.btnSapport_Click);
            // 
            // btnModrapport
            // 
            this.btnModrapport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModrapport.Location = new System.Drawing.Point(831, 370);
            this.btnModrapport.Name = "btnModrapport";
            this.btnModrapport.Size = new System.Drawing.Size(345, 57);
            this.btnModrapport.TabIndex = 29;
            this.btnModrapport.Text = "Modifier Rapport";
            this.btnModrapport.UseVisualStyleBackColor = true;
            this.btnModrapport.Click += new System.EventHandler(this.btnSrapport_Click);
            // 
            // compte_rendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "compte_rendu";
            this.Text = "compte_rendu";
            this.Load += new System.EventHandler(this.compte_rendu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEchantillon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Label lblChercher;
        private System.Windows.Forms.Label lblNumCR;
        private System.Windows.Forms.Label lblPraCR;
        private System.Windows.Forms.Label lblDtCR;
        private System.Windows.Forms.Label lblMV;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Label lblOE;
        private System.Windows.Forms.ComboBox cbChercher;
        private System.Windows.Forms.TextBox tbnumrapport;
        private System.Windows.Forms.DateTimePicker dtCR;
        private System.Windows.Forms.ComboBox cbPraCR;
        private System.Windows.Forms.RichTextBox rtbBilan;
        private System.Windows.Forms.DataGridView dtgvEchantillon;
        private System.Windows.Forms.RichTextBox rtbMotif;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnModifEchantillon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSapport;
        private System.Windows.Forms.Button btnModrapport;
    }
}