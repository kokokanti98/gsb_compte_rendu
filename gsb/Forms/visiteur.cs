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
    public partial class visiteur : Form
    {
        internal static string num_secteur, idtypeemploye, idLocalisation, idEmploye;
        connexion cnn = new connexion();

        //initialisation constructeur
        public visiteur(string p_idtypeemploye, string p_idEmploye, string p_idLocalisation, string p_num_secteur)
        {
            num_secteur = p_num_secteur;
            idtypeemploye = p_idtypeemploye;
            idLocalisation = p_idLocalisation;
            idEmploye = p_idEmploye;
            InitializeComponent();
            visiteur_Load();
            labo_Load();
            typeemploye_load();
            secteur_Load();
            cnn.btnhide(idtypeemploye, btnnouvVIS, btnMajVIS, btnSupVIS);

        }

        //fonction pour charger les visiteurs afin de les utiliser dans un combobox C#
        private void visiteur_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);

            if (idtypeemploye == "VIS")
            {
                //requete utilise si visiteur
                sql = "SELECT idEmploye,nom FROM employe WHERE idEmploye = \'" + idEmploye + "\'";
            }
            else if (idtypeemploye == "RES")
            {
                //requete utilise si responsable
                sql = "SELECT idEmploye,nom FROM employe WHERE num_secteur = " + num_secteur + " ";
            }
            else if (idtypeemploye == "DEL")
            {
                //requete utilise si delegue
                sql = "SELECT idEmploye,nom FROM employe WHERE idLocalisation = " + idLocalisation + "";
            }

            //requete utilise autre ici ce sera l'administrateur

            else //if (compte_rendu.idtypeemploye == "ADM")
            {
                sql = "SELECT idEmploye,nom FROM employe";
            }
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
                cbsearchVisiteur.DataSource = ds.Tables[0];
                cbsearchVisiteur.ValueMember = "idEmploye";
                cbsearchVisiteur.DisplayMember = "nom";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        ////fonction pour charger les laboratoires afin de les utiliser dans un combobox C#
        private void labo_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);

            //requete utiliée
            sql = "SELECT id_labo,nom_labo FROM laboratoire";

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
                cbLabo.DataSource = ds.Tables[0];
                cbLabo.ValueMember = "id_labo";
                cbLabo.DisplayMember = "nom_labo";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        private void secteur_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT id_secteur,nom_secteur FROM secteur";
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
                cbSecteur.DataSource = ds.Tables[0];
                cbSecteur.ValueMember = "id_secteur";
                cbSecteur.DisplayMember = "nom_secteur";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        private void typeemploye_load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT * FROM `typeemploye`";
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
                cbTypeemploye.DataSource = ds.Tables[0];
                cbTypeemploye.ValueMember = "idTypeEmploye";
                cbTypeemploye.DisplayMember = "libelleTypeEmploye";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour charger les données d'un visiteur afin de les utiliser dans un combobox C#
        private void voir_visiteur(object p_idemploye)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT idEmploye,localisation.idLocalisation,nom,prenom,adresse,codePostal,libelleVille," +
                "nom_secteur,libelleTypeEmploye,nom_labo " +
                "FROM employe JOIN localisation ON " +
                "employe.idLocalisation = localisation.idLocalisation " +
                "LEFT JOIN secteur ON employe.num_secteur = secteur.id_secteur " +
                "LEFT JOIN laboratoire ON employe.num_labo = laboratoire.id_labo " +
                "LEFT JOIN typeemploye ON employe.idTypeEmploye = typeemploye.idTypeEmploye WHERE idEmploye = " + p_idemploye + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    idEmploye = rdr["idEmploye"].ToString();
                    idLocalisation = rdr["idLocalisation"].ToString();
                    tbNom.Text = rdr["nom"].ToString();
                    tbPrenom.Text = rdr["prenom"].ToString();
                    tbAdresse.Text = rdr["adresse"].ToString();
                    tbCP.Text = rdr["codePostal"].ToString();
                    tbVille.Text = rdr["libelleVille"].ToString();
                    cbSecteur.Text = rdr["nom_secteur"].ToString();
                    cbLabo.Text = rdr["nom_labo"].ToString();
                    cbTypeemploye.Text = rdr["libelleTypeEmploye"].ToString();
                }
                MessageBox.Show("Chargement reussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }


        //fonction pour modifier les donnees d'un visiteur
        private void update_employe(object p_idemploye, object p_idsector, object p_numlabo, object p_nom, object p_prenom, object p_adresse, object p_idlocalisation, object p_typemploye, object p_ville, object p_CP)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "UPDATE `employe` SET `idTypeEmploye` = \'" + p_typemploye + "\', `idLocalisation` = \'" + p_idlocalisation + "\', " +
                "`num_secteur` = \'" + p_idsector + "\', `nom` = \'" + p_nom + "\'," +
                "`num_labo` = \'" + p_numlabo + "\', `prenom` = \'" + p_prenom + "\', " +
                "`adresse` = \'" + p_adresse + "\' WHERE `employe`.`idEmploye` = " + p_idemploye + ";" +
                " UPDATE `localisation` SET `codePostal` = \'" + p_CP + "\', `libelleVille` = \'" + p_ville + "\' WHERE `localisation`.`idLocalisation` = " + p_idlocalisation + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Mise à jour reussie");
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
            sql = "SELECT idLocalisation FROM `localisation` WHERE libelleVille = \'" + p_nomville + "\'";
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

        //fonction pour supprimer un visiteur grace à son id
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
            sql = "DELETE FROM `employe` WHERE `employe`.`idEmploye` = " + p_idpraticien + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Suppression d employe réussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Syntaxe sql incorecte ! ");
            }
        }

        //fonction pour creer un nouveau visiteur
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
                "\'praticien" + p_idemploye + "\', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', " +
                "\'" + p_datenow + "\', '1',\'" + p_idlocalisation + "\')";
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
        private void lblCoeff_Click(object sender, EventArgs e)
        {

        }

        private void lblChercher_Click(object sender, EventArgs e)
        {

        }

        private void numsearchVisiteur_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbSecteur.DataSource = Enum.GetValues(typeof(Weekdays));

        }

        private void cbLabo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            //pour charger les donnees d'un visiteur
            voir_visiteur(cbsearchVisiteur.SelectedValue);
        }

        private void cbsearchVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnouvVIS_Click(object sender, EventArgs e)
        {
            
        }

        private void cbTypeemploye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //button pour supprimer un visiteur grace à son id
        private void btnMajVIS_Click(object sender, EventArgs e)
        {
            idLocalisation = "";
            //pour rechercher l'id de la ville concerne grace à son nom precedement entree
            idLocalisation = search_idville(tbVille.Text, idLocalisation);
            update_employe(idEmploye, cbSecteur.SelectedValue, cbLabo.SelectedValue, tbNom.Text, tbPrenom.Text, tbAdresse.Text, idLocalisation, cbTypeemploye.SelectedValue, tbVille.Text, tbCP.Text);
            visiteur_Load();
        }

        //button pour supprimer un visiteur grace à son id
        private void btnSupVIS_Click(object sender, EventArgs e)
        {
            suppr_praticien(idEmploye);
            visiteur_Load();
        }

        //fonction pour faire un nouveau un visiteur grace à son id
        private void btnnouvVIS_Click_1(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            idLocalisation = "";
            idLocalisation = search_idville(tbVille.Text, idLocalisation);
            nouv_praticen(idEmploye, thisDay.ToString("yyyy/MM/dd"), idLocalisation);
            visiteur_Load();
        }

        private void visiteur_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
