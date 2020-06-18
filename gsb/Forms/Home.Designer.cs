namespace gbs_gcr1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.btnPraticien = new System.Windows.Forms.Button();
            this.btnVisiteur = new System.Windows.Forms.Button();
            this.btCR = new System.Windows.Forms.Button();
            this.panelLogo2 = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelNavigation.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panelNavigation.Controls.Add(this.btnquit);
            this.panelNavigation.Controls.Add(this.btnMedicament);
            this.panelNavigation.Controls.Add(this.btnPraticien);
            this.panelNavigation.Controls.Add(this.btnVisiteur);
            this.panelNavigation.Controls.Add(this.btCR);
            this.panelNavigation.Controls.Add(this.panelLogo2);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(373, 850);
            this.panelNavigation.TabIndex = 0;
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnquit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnquit.FlatAppearance.BorderSize = 0;
            this.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquit.Font = new System.Drawing.Font("Garamond", 13.875F);
            this.btnquit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnquit.Location = new System.Drawing.Point(0, 375);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(373, 75);
            this.btnquit.TabIndex = 5;
            this.btnquit.Text = "Quitter";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click_1);
            // 
            // btnMedicament
            // 
            this.btnMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnMedicament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicament.FlatAppearance.BorderSize = 0;
            this.btnMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicament.Font = new System.Drawing.Font("Garamond", 13.875F);
            this.btnMedicament.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMedicament.Location = new System.Drawing.Point(0, 312);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(373, 63);
            this.btnMedicament.TabIndex = 4;
            this.btnMedicament.Text = "Medicaments";
            this.btnMedicament.UseVisualStyleBackColor = false;
            this.btnMedicament.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPraticien
            // 
            this.btnPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnPraticien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPraticien.FlatAppearance.BorderSize = 0;
            this.btnPraticien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPraticien.Font = new System.Drawing.Font("Garamond", 13.875F);
            this.btnPraticien.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPraticien.Location = new System.Drawing.Point(0, 249);
            this.btnPraticien.Name = "btnPraticien";
            this.btnPraticien.Size = new System.Drawing.Size(373, 63);
            this.btnPraticien.TabIndex = 3;
            this.btnPraticien.Text = "Praticiens";
            this.btnPraticien.UseVisualStyleBackColor = false;
            this.btnPraticien.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVisiteur
            // 
            this.btnVisiteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisiteur.FlatAppearance.BorderSize = 0;
            this.btnVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisiteur.Font = new System.Drawing.Font("Garamond", 13.875F);
            this.btnVisiteur.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVisiteur.Location = new System.Drawing.Point(0, 186);
            this.btnVisiteur.Name = "btnVisiteur";
            this.btnVisiteur.Size = new System.Drawing.Size(373, 63);
            this.btnVisiteur.TabIndex = 2;
            this.btnVisiteur.Text = "Visiteurs";
            this.btnVisiteur.UseVisualStyleBackColor = false;
            this.btnVisiteur.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCR
            // 
            this.btCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCR.FlatAppearance.BorderSize = 0;
            this.btCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCR.Font = new System.Drawing.Font("Garamond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCR.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCR.Location = new System.Drawing.Point(0, 123);
            this.btCR.Name = "btCR";
            this.btCR.Size = new System.Drawing.Size(373, 63);
            this.btCR.TabIndex = 1;
            this.btCR.Text = "Comptes-rendus";
            this.btCR.UseVisualStyleBackColor = false;
            this.btCR.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo2
            // 
            this.panelLogo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo2.BackgroundImage")));
            this.panelLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo2.Location = new System.Drawing.Point(0, 0);
            this.panelLogo2.Name = "panelLogo2";
            this.panelLogo2.Size = new System.Drawing.Size(373, 123);
            this.panelLogo2.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHome.Controls.Add(this.lblHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelHome.Location = new System.Drawing.Point(373, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(944, 100);
            this.panelHome.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Garamond", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHome.Location = new System.Drawing.Point(387, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Padding = new System.Windows.Forms.Padding(10);
            this.lblHome.Size = new System.Drawing.Size(99, 44);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "HOME";
            this.lblHome.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(373, 100);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(944, 750);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 850);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panelNavigation.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelLogo2;
        private System.Windows.Forms.Button btnVisiteur;
        private System.Windows.Forms.Button btCR;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnMedicament;
        private System.Windows.Forms.Button btnPraticien;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}