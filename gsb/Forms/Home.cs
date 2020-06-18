using gbs_gcr1.config;
using gbs_gcr1.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace gbs_gcr1
{
    public partial class Home : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public string name;
        public string idtypeemploye;
        public string num_secteur;
        public string idLocalisation;
        public string idEmploye;
        connexion cnn = new connexion();


        //initialisation constructeur
        public Home()
        {
            InitializeComponent();
            random = new Random();
        }
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelNavigation.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(46, 56, 56);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Regular, 
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    //currentButton.Font = new System.Drawing.Font("Garamond", 12.5F, System.Drawing.FontStyle.Regular, 
                    //System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //btnVisiteur.BackColor = color;
                    ///ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //button pour ouvrir un le pannel windowform compte rendus
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.compte_rendu(idtypeemploye, idEmploye, idLocalisation,num_secteur), sender);
            lblHome.Text = "COMPTES RENDUS";
        }

        //button pour ouvrir un le pannel windowform praticien
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.praticien(idtypeemploye), sender);
            lblHome.Text = "PRATICIENS";
        }

        //button pour ouvrir un le pannel windowform visiteur
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.visiteur(idtypeemploye, idEmploye, idLocalisation, num_secteur), sender);
            lblHome.Text = "VISITEURS";
        }

        //button pour ouvrir un le pannel windowform medicament
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.medicament(idtypeemploye), sender);
            lblHome.Text = "MEDICAMENTS";         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnquit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();            
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
