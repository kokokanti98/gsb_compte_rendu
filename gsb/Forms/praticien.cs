using gbs_gcr1.config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gbs_gcr1.Forms
{
    public partial class praticien : Form
    {
        string idlocalisation;
        internal static string idtypeemploye;
        connexion cnn = new connexion();

        //initialisation constructeur
        public praticien(string p_idtypeemploye)
        {
            idtypeemploye = p_idtypeemploye;
            InitializeComponent();
            praticien_Load();
            specialite_Load();
            cnn.btnhide(idtypeemploye, btnMAJpraticien, btncreer, btnSupprPraticien);
        }

        //fonction pour charger les praticiens afin de les utiliser dans un combobox C#
        private void praticien_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT idEmploye,nom FROM employe WHERE idTypeEmploye = 'PRA'";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                cbChercher.DataSource = ds.Tables[0];
                cbChercher.ValueMember = "idEmploye";
                cbChercher.DisplayMember = "nom";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour charger les specialite des praticiens afin de les utiliser dans un combobox C#
        private void specialite_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT `id_specialite`, `nom_specialite` FROM `specialite`";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                cbLieuexercice.DataSource = ds.Tables[0];
                cbLieuexercice.ValueMember = "id_specialite";
                cbLieuexercice.DisplayMember = "nom_specialite";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour voir un praticien race à son id 
        private void voir_praticien(object p_idemploye)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT idEmploye,localisation.idLocalisation,nom,prenom,adresse," +
                "codePostal,libelleVille,coeff_notorie," +
                "nom_specialite FROM employe " +
                "LEFT JOIN localisation ON employe.idLocalisation = localisation.idLocalisation " +
                "LEFT JOIN specialite ON employe.num_specialite = specialite.id_specialite " +
                "WHERE idTypeEmploye = 'PRA' AND idEmploye = "+ p_idemploye + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(string.Format("user_id = {0}", rdr["idEmploye"].ToString()));
                    numNumero.Text = rdr["idEmploye"].ToString();
                    tbNom.Text = rdr["nom"].ToString();
                    tbPrenom.Text = rdr["prenom"].ToString();
                    tbAdresse.Text = rdr["adresse"].ToString();
                    tbCP.Text = rdr["codePostal"].ToString();
                    tbVille.Text = rdr["libelleVille"].ToString();
                    tbCoeff.Text = rdr["coeff_notorie"].ToString();
                    cbLieuexercice.Text = rdr["nom_specialite"].ToString();
                    idlocalisation = rdr["idLocalisation"].ToString();
                }
                MessageBox.Show("Chargement reussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour faire le mise à jour d'un praticien 
        private void update_praticen(object p_idemploye, object p_special_id, object p_coeffnotorie, object p_nom, object p_prenom, object p_adresse, object p_idlocalisation, object p_ville, object p_CP)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "UPDATE `employe` SET `num_specialite` = \'"+ p_special_id + "\', `coeff_notorie` = \'"+ p_coeffnotorie + "\', `nom` = \'"+ p_nom + "\', `prenom` = \'"+ p_prenom + "\', `adresse` = \'"+ p_adresse + "\' WHERE `employe`.`idEmploye` = "+ p_idemploye + "; " +
                "UPDATE `localisation` SET `codePostal` = \'"+ p_CP + "\', `libelleVille` = \'"+ p_ville + "\' WHERE `localisation`.`idLocalisation` = "+ p_idlocalisation + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Mise à jour reussie"+ idtypeemploye);
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour faire un  nouveau praticien 
        private void nouv_praticen(object p_idemploye, object p_datenow, string p_idlocalisation)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "INSERT INTO `employe` " +
                "(`idTypeEmploye`,`coeff_notorie`, `nom`, `prenom`, `adresse`, " +
                "`login`, `mdp`, `dateEmbauche`, `cptActif`,`idLocalisation`) VALUES " +
                "('PRA','00.11', 'nom', 'prenom', '15 rue du Bouccicauta', " +
                "\'praticien"+ p_idemploye + "\', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', " +
                "\'"+ p_datenow + "\', '1',\'"+ p_idlocalisation + "\')";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Nouveau praticien reussie, noubliez pas d'ajouter " +
                    "les informations complémentaire: adresse, et lieu d exercice puis cliquez sur modifier pour finir");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour chercher l id d'une ville grace à son nom
        private string search_idville(object p_nomville, string p_idville)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT idLocalisation FROM `localisation` WHERE libelleVille = \'"+ p_nomville + "\'";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    p_idville = rdr["idLocalisation"].ToString();
                }
                MessageBox.Show("Ville trouve");
            }
            catch (Exception)
            {
                MessageBox.Show("Syntaxe sql incorecte ou ville non present dans la bdd ! ");
            }
            return p_idville;
        }

        //fonction pour supprimer un praticien
        private void suppr_praticien(object p_idpraticien)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "DELETE FROM `employe` WHERE `employe`.`idEmploye` = "+ p_idpraticien + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Suppression du praticien réussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Syntaxe sql incorecte ! ");
            }
        }
        private void tranformstring_double(object sender, EventArgs e)
        {

        }
        private void praticien_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbLieuexercice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbChercher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //fonction pour chercher un praticien
        private void btnChercher_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbChercher.Text + " " + cbChercher.SelectedValue);
            //MessageBox.Show("Type employe:" + idtypeemploye);
            voir_praticien(cbChercher.SelectedValue);
        }

        private void numNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        //fonction pour modifier un praticien
        private void btnMAJpraticien_Click(object sender, EventArgs e)
        {
            update_praticen(numNumero.Text, cbLieuexercice.SelectedValue, tbCoeff.Text.Replace(',', '.'), tbNom.Text,
                tbPrenom.Text, tbAdresse.Text, idlocalisation, tbVille.Text, tbCP.Text);
            praticien_Load();
        }

        //fonction pour creer un nouveau praticien
        private void btncreer_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            idlocalisation = "";
            idlocalisation = search_idville(tbVille.Text, idlocalisation);
            //MessageBox.Show("date maintenant:"+ thisDay.ToString("yyyy/MM/dd")+"\nidlocalisation:"+ idlocalisation+"\nville:"+ tbVille.Text);
            nouv_praticen(numNumero.Text, thisDay.ToString("yyyy/MM/dd"), idlocalisation);
            praticien_Load();
        }


        //button pour supprimer un praticien
        private void btnSupprPraticien_Click(object sender, EventArgs e)
        {
            suppr_praticien(numNumero.Text);
            praticien_Load();
        }

        private void tbCoeff_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
