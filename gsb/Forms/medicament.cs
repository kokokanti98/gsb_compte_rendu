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
    public partial class medicament : Form
    {
        private string id_medicament = "";
        connexion cnn = new connexion();
        internal static string idtypeemploye;

        //initialisation constructeur
        public medicament(string p_idtypeemploye)
        {
            idtypeemploye = p_idtypeemploye;
            InitializeComponent();
            medicament_Load();
            famille_Load();
            cnn.btnhide(idtypeemploye, btnSupMed, btnSMed, btnAddMed);          
        }

        //fonction pour charger donnees d'un medicament
        private void afficher_medicament(object p_number)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT id_medicament,code,nom_commercial,nom_famille,composition,effets," +
    "contre_indication,prix_echantillon FROM medicament " +
    "INNER JOIN famille ON medicament.num_famille = famille.id_famille " +
    "WHERE id_medicament = " + p_number + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    id_medicament = rdr["id_medicament"].ToString(); ;
                    cbSearchMedicament.Text = rdr["nom_commercial"].ToString();
                    tbNom.Text = rdr["code"].ToString(); ;
                    tbPrenom.Text = rdr["nom_commercial"].ToString();
                    cbFamille.Text = rdr["nom_famille"].ToString();
                    tbCP.Text = rdr["composition"].ToString();
                    rtbEI.Text = rdr["effets"].ToString();
                    rtbCI.Text = rdr["contre_indication"].ToString();
                    tbPE.Text = rdr["prix_echantillon"].ToString();
                }
                MessageBox.Show("Chargement reussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour charger les donnees d'un medicament afin de les utiliser dans un combobox C#
        private void medicament_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT id_medicament,code,nom_commercial FROM medicament";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds1);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                cbSearchMedicament.DataSource = ds1.Tables[0];
                cbSearchMedicament.ValueMember = "id_medicament";
                cbSearchMedicament.DisplayMember = "nom_commercial";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour charger les donnees de la tables famille afin de les utiliser dans un combobox C#
        private void famille_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT `id_famille`,`nom_famille` FROM `famille`";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds1);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                cbFamille.DataSource = ds1.Tables[0];
                cbFamille.ValueMember = "id_famille";
                cbFamille.DisplayMember = "nom_famille";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour modifier un medicament grace à son id
        private void mod_medicament(object p_idmedicament,object p_code, object p_numfamille,
            object p_nomcomerciale, object p_composition, object p_EI, object p_CI, object p_PE)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "UPDATE `medicament` SET `code` = \'"+ p_code + "\', `num_famille` = \'"+p_numfamille+"\', " +
                "`nom_commercial` = \'"+ p_nomcomerciale + "\', `composition` = \'"+ p_composition + "\', " +
                "`effets` = \'"+ p_EI + "\', " +
                "`contre_indication` = \'"+ p_CI + "\', `prix_echantillon` = \'"+ p_PE + "\' " +
                "WHERE `medicament`.`id_medicament` = "+ p_idmedicament + ";";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Modification du medicament réussie"+ idtypeemploye);
            }
            catch (Exception)
            {
                MessageBox.Show("Syntaxe sql incorecte ! ");
            }
        }

        //fonction pour ajouter un nouveau medicament
        private void ajouter_medicament(object p_code, object p_numfamille, 
            object p_nomcomerciale, object p_composition, object p_EI, object p_CI, object p_PE)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "INSERT INTO `medicament`(`code`, `num_famille`, `nom_commercial`, `composition`, `effets`, `contre_indication`, `prix_echantillon`) " +
                "VALUES (\'"+ p_code + "\',\'"+ p_numfamille + "\',\'"+ p_nomcomerciale + "\',\'"+ p_composition + "\',\'"+ p_EI + "\',\'"+ p_CI + "\',\'"+ p_PE + "\')";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Ajout du medicament réussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Syntaxe sql incorecte ! ");
            }
        }

        //fonction pour supprimer un medicament
        private void suppr_medicament(object p_idmedicament)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "DELETE FROM `medicament` WHERE `medicament`.`id_medicament` = "+ p_idmedicament + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Suppression du medicament réussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Syntaxe sql incorecte ! ");
            }
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //numsearchMedic.Value = numsearchMedic.Value - 1;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {

        }

        private void tbAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //afficher_medicament(bdd, table1, table2, numsearchMedic.Value);
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            //afficher_medicament(bdd, table1, table2, numsearchMedic.Value);
        }

        private void cbChercher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblChercher_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("id_medicament:"+ cbSearchMedicament.SelectedValue+"\nid famille:"+ cbFamille.SelectedValue);

            //afficher un medicament grace à son id
            afficher_medicament(cbSearchMedicament.SelectedValue);
        }

        private void cbSearchMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPE_TextChanged(object sender, EventArgs e)
        {

        }

        //button pour supprimer un medicament
        private void button1_Click_1(object sender, EventArgs e)
        {
            suppr_medicament(cbSearchMedicament.SelectedValue);
            medicament_Load();
        }

        //button pour modifier un medicament
        private void btnSupMed_Click(object sender, EventArgs e)
        {
            mod_medicament(cbSearchMedicament.SelectedValue, tbNom.Text, cbFamille.SelectedValue, tbPrenom.Text, tbCP.Text, rtbEI.Text, rtbCI.Text, tbPE.Text.Replace(',', '.'));
            medicament_Load();
        }

        //button pour ajouter un medicament
        private void btnAddMed_Click(object sender, EventArgs e)
        {
            ajouter_medicament(tbNom.Text, cbFamille.SelectedValue, tbPrenom.Text, tbCP.Text, rtbEI.Text, rtbCI.Text, tbPE.Text.Replace(',', '.'));
            medicament_Load();
        }
    }
}
