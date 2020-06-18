using gbs_gcr1.config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gbs_gcr1
{
    public partial class Form1 : Form
    {
        //private string[] donnees;
        private string mot_de_passe;
        private string login;
        public string nom;
        public string Type_EmployeC;
        public string num_secteur;
        public string idLocalisation;
        public string idEmploye;
        connexion cnn = new connexion();
        public Form1()
        {
            InitializeComponent();
        }
        private void auth_user(string p_login,string p_mdp)
        {
            //connexion cnn = new connexion();
            string connectionString = null;
            connectionString = cnn.connexionstring(connectionString);
            // Your query,
            string query = "SELECT idEmploye,idTypeEmploye,nom,login,mdp,num_secteur,	idLocalisation FROM `employe`";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        if (p_login == reader["login"].ToString() && p_mdp == reader["mdp"].ToString())
                        {
                            Close();
                            Type_EmployeC = reader["idTypeEmploye"].ToString();
                            nom = reader["nom"].ToString();
                            MessageBox.Show("Connexion reussie. Bonjour Mr/Mme "+nom);
                            num_secteur = reader["num_secteur"].ToString(); 
                            idLocalisation = reader["idLocalisation"].ToString();
                            idEmploye = reader["idEmploye"].ToString();
                            Home home = new Home();
                            home.name = nom;
                            home.idtypeemploye = Type_EmployeC;
                            home.num_secteur = num_secteur;
                            home.idLocalisation = idLocalisation;
                            home.idEmploye = idEmploye;
                            //Console.WriteLine(home);
                            //home.Show();
                            home.Show();
                        }
                        else
                        {
                            lblErrorconnexion.Text = "Identifiant ou mot de passe Incorrecte.";
                            lblErrorconnexion.ForeColor = Color.Red;
                        }
                        //Console.WriteLine("nom_utilisateur: " + row[1] + "\tpseudo: " + row[2] + "\tmdp:" + row[3]);
                    }
                    //Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Pas de donnees");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception)
            {
                // Show any error message.
                //MessageBox.Show(ex.Message);
                Console.WriteLine("Error");
            }
        }
        private string hashage_mdp(string p_mdp,string p_typehashage_MAJUSCULE)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(p_mdp);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName(""+ p_typehashage_MAJUSCULE + "")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();
            return encoded;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = tbLogin.Text;
            mot_de_passe = tbMdp.Text;
            mot_de_passe = hashage_mdp(mot_de_passe, "MD5");
            //MessageBox.Show("Hashage MD5 du mot mdp:" + mot_de_passe);
            auth_user(login, mot_de_passe);


        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            //childForm.BringToFront();
            childForm.Show();            
            //lblTitle.Text = childForm.Text;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
