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
    public partial class compte_rendu : Form
    {
        connexion cnn = new connexion();
        internal static  string num_secteur, idtypeemploye, idLocalisation, idEmploye;

        //initialisation constructeur
        public compte_rendu(string p_idtypeemploye, string p_idEmploye,string p_idLocalisation, string p_num_secteur)
        {
            num_secteur = p_num_secteur;
            idtypeemploye = p_idtypeemploye;
            idLocalisation = p_idLocalisation;
            idEmploye = p_idEmploye;
            InitializeComponent();
            //MessageBox.Show("id employe : "+ idEmploye + "\n idlocalisation : "+ idLocalisation + "\nnum_secteur : "+ num_secteur + "\n id type employe : "+ idtypeemploye);
            rapport_Load(idtypeemploye);
            praticien_Load();
            if (idtypeemploye == "ADM")
            {
                btnSapport.Show();
            }
            else
            {
                btnSapport.Hide();
            }           

        }

        //charger les praticiens afin de les utiliser dans une combobox c#
        private void praticien_Load()
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT idEmploye,nom,prenom FROM employe WHERE idTypeEmploye = 'PRA'";
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
                cbPraCR.DataSource = ds1.Tables[0];
                cbPraCR.ValueMember = "idEmploye";
                cbPraCR.DisplayMember = "nom";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour recuperer plusieurs rapports selon le type d'utilisateur le code sql est différent et utiliser dans un combobox c#
        private void rapport_Load(string pr_idtypeemploye)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            if (pr_idtypeemploye == "VIS")
            {
                sql = "SELECT DISTINCT id_rapport  FROM echantillon JOIN rapport_visite " +
                    "ON echantillon.num_rapport = rapport_visite.id_rapport WHERE date_rapport>=DATE_ADD(NOW(), " +
                    "INTERVAL -3 YEAR) " +
                    "AND num_visiteur= \'" + idEmploye + "\'";
            }
            else if (pr_idtypeemploye == "RES")
            {
                sql = "SELECT DISTINCT id_rapport FROM echantillon JOIN medicament " +
                    "ON echantillon.num_medicament =medicament.id_medicament " +
                    "LEFT JOIN employe ON echantillon.num_praticien = employe.idEmploye " +
                    "RIGHT JOIN rapport_visite ON echantillon.num_rapport = rapport_visite.id_rapport " +
                    "WHERE idLocalisation = " + num_secteur + "";
            }
            else if (pr_idtypeemploye == "DEL")
            {
                sql = "SELECT DISTINCT id_rapport FROM echantillon JOIN medicament " +
                    "ON echantillon.num_medicament =medicament.id_medicament " +
                    "LEFT JOIN employe ON echantillon.num_praticien = employe.idEmploye " +
                    "RIGHT JOIN rapport_visite ON echantillon.num_rapport = rapport_visite.id_rapport " +
                    "WHERE idLocalisation = " + idLocalisation + "";
            }
            else //if (compte_rendu.idtypeemploye == "ADM")
            {
                sql = "SELECT DISTINCT id_rapport  FROM echantillon JOIN rapport_visite " +
                    "ON echantillon.num_rapport = rapport_visite.id_rapport";
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
                cbChercher.DataSource = ds.Tables[0];
                cbChercher.ValueMember = "id_rapport";
                cbChercher.DisplayMember = "id_rapport";
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour voir un rapport par son id
        private void voir_rapport(object p_idrapport)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            if (compte_rendu.idtypeemploye == "VIS")
            {
                sql = "SELECT id_rapport,id_echantillon,nom,prenom,date_rapport,motif,bilan,nom_commercial,qte_offerte " +
                    "FROM echantillon JOIN medicament ON echantillon.num_medicament =medicament.id_medicament " +
                    "LEFT JOIN employe ON echantillon.num_praticien = employe.idEmploye " +
                    "RIGHT JOIN rapport_visite ON echantillon.num_rapport = rapport_visite.id_rapport " +
                    "WHERE id_rapport = " + p_idrapport + " AND date_rapport>=DATE_ADD(NOW(), INTERVAL -3 YEAR) AND num_visiteur= \'"+ idEmploye + "\'";
            }
            else if (compte_rendu.idtypeemploye == "RES")
            {
                sql = "SELECT id_rapport,id_echantillon,nom,prenom,date_rapport,motif,bilan,nom_commercial,qte_offerte " +
                    "FROM echantillon JOIN medicament ON echantillon.num_medicament =medicament.id_medicament " +
                    "LEFT JOIN employe ON echantillon.num_praticien = employe.idEmploye " +
                    "RIGHT JOIN rapport_visite ON echantillon.num_rapport = rapport_visite.id_rapport " +
                    "WHERE id_rapport = " + p_idrapport + " AND num_secteur = " + num_secteur + "";
            }
            else if (compte_rendu.idtypeemploye == "DEL")
            {
                sql = "SELECT id_rapport,id_echantillon,nom,prenom,date_rapport,motif,bilan,nom_commercial,qte_offerte " +
                    "FROM echantillon JOIN medicament ON echantillon.num_medicament =medicament.id_medicament " +
                    "LEFT JOIN employe ON echantillon.num_praticien = employe.idEmploye " +
                    "RIGHT JOIN rapport_visite ON echantillon.num_rapport = rapport_visite.id_rapport " +
                    "WHERE id_rapport = " + p_idrapport + " AND idLocalisation = " + idLocalisation + "";
            }
            else //if (compte_rendu.idtypeemploye == "ADM")
            {
                sql = "SELECT id_rapport,id_echantillon,nom,prenom,date_rapport,motif,bilan,nom_commercial,qte_offerte " +
                    "FROM echantillon JOIN medicament ON echantillon.num_medicament =medicament.id_medicament " +
                    "LEFT JOIN employe ON echantillon.num_praticien = employe.idEmploye " +
                    "RIGHT JOIN rapport_visite ON echantillon.num_rapport = rapport_visite.id_rapport " +
                    "WHERE id_rapport = " + p_idrapport + "";
            }

            
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    tbnumrapport.Text = rdr["id_rapport"].ToString();
                    cbPraCR.Text = ""+rdr["nom"].ToString()+"\t"+rdr["prenom"].ToString()+"";
                    dtCR.Text = rdr["date_rapport"].ToString();
                    rtbMotif.Text = rdr["motif"].ToString();
                    rtbBilan.Text = rdr["bilan"].ToString();
                    dtgvEchantillon.Refresh();
                    dtgvEchantillon.ColumnCount = 3;
                    dtgvEchantillon.Columns[0].Name = "id_echantillon";
                    dtgvEchantillon.Columns[1].Name = "Nom commerciale";
                    dtgvEchantillon.Columns[2].Name = "Quantite";
                    int i = 1;
                    string[] row = new string[] { rdr["id_echantillon"].ToString(), rdr["nom_commercial"].ToString(), rdr["qte_offerte"].ToString() };
                    dtgvEchantillon.Rows.Add(row);

                    while (rdr.Read())
                    {
                        i++;
                        row = new string[] { rdr["id_echantillon"].ToString(), rdr["nom_commercial"].ToString(), rdr["qte_offerte"].ToString() };
                        dtgvEchantillon.Rows.Add(row);
                    }
                }
                MessageBox.Show("Chargement reussie");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPraCR_Click(object sender, EventArgs e)
        {

        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            voir_rapport(cbChercher.SelectedValue);
        }

        private void cbChercher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPraCR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvEchantillon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvEchantillon.Refresh();

        }

        //fonction pour modifier un echantillon
        private void btnAddEchantillon_Click(object sender, EventArgs e)
        {
            string id_med = "";
            id_med = search_med_id(dtgvEchantillon.SelectedRows[0].Cells[1].Value.ToString(), id_med);
            update_echantillon(dtgvEchantillon.SelectedRows[0].Cells[0].Value.ToString(), id_med, dtgvEchantillon.SelectedRows[0].Cells[2].Value.ToString());
        }

        //fonction pour seacher l id d'un medicament race à son nom
        private string search_med_id(object nom_medicament,string medicament_id)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "SELECT id_medicament FROM medicament WHERE nom_commercial=\'"+ nom_medicament + "\'";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    medicament_id = rdr["id_medicament"].ToString();
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            return medicament_id;
        }

        //fonction pour modifier un echantillon
        private void update_echantillon(object p_echantillonid, string p_med_id, object p_qte_offerte)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "UPDATE `echantillon` SET " +
                "`num_medicament` = \'" + p_med_id + "\', " +
                "`qte_offerte` = \'" + p_qte_offerte + "\' " +
                "WHERE `echantillon`.`id_echantillon` = " + p_echantillonid + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Mise à jour réussie des données");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        //fonction pour inserer un echantillon
        private void insert_echantillon(string p_med_id,object p_rapport_id, object p_praticien_id, object p_qte_offerte)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "INSERT INTO `echantillon`(`num_medicament`, `num_rapport`, `num_praticien`, `qte_offerte`) VALUES ("+ p_med_id + ","+ p_rapport_id + ","+ p_praticien_id + ","+ p_qte_offerte + ")";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Entree réussie de l echantillon");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour supprimer un echantillon
        private void delete_echantillon(object p_echantillon_id)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "DELETE FROM `echantillon` WHERE `echantillon`.`id_echantillon` = "+ p_echantillon_id + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Suppression réussie de l echantillon");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour faire un nouveau rapport
        private void nouv_rapport(object p_praticien_id)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            string sql1 = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "INSERT INTO `rapport_visite`(`id_rapport`, `numero_praticien`,`date_rapport`,`bilan`, `motif`) " +
                "VALUES (" + tbnumrapport.Text + "," + idEmploye + ",\'" + dtCR.Value.ToString("yyyy/MM/dd") + "\','','')";
            sql1 = "INSERT INTO `echantillon`(`num_medicament`, `num_rapport`, `num_praticien`, `num_visiteur`, `qte_offerte`) " +
                "VALUES (2," + tbnumrapport.Text + "," + p_praticien_id + "," + idEmploye + ",12)";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                //MessageBox.Show("Creation réussie du nouveau rapport vide");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            try
            {
                connection.Open();
                command = new MySqlCommand(sql1, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Creation réussie du nouveau rapport vide");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        //fonction pour modifier un rapport
        private void update_rapport(object p_rapport_id, object p_praticien_id, object p_date, object p_bilan, object p_motif)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "UPDATE `rapport_visite` SET `numero_praticien` = \'"+p_praticien_id+"\', `date_rapport` = \'"+ p_date + "\', " +
                "`bilan` = \'"+ p_bilan + "\', `motif` = \'"+ p_motif + "\' WHERE `rapport_visite`.`id_rapport` = "+ p_rapport_id + "";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Mise à jour réussie dU RAPPORT");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //fonction pour supprimer un rapport
        private void suppr_rapport(object p_rapport_id)
        {
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds1 = new DataSet();
            string sql = null;
            connetionString = cnn.connexionstring(connetionString);
            sql = "DELETE FROM `echantillon` WHERE `echantillon`.`num_rapport` = "+ p_rapport_id + "; " +
                "DELETE FROM `rapport_visite` WHERE id_rapport = "+ p_rapport_id + "";
            //sql1 = "DELETE FROM `echantillon` WHERE `echantillon`.`id_echantillon` = 8";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                MySqlDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Suppression réussie dU RAPPORT");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void compte_rendu_Load(object sender, EventArgs e)
        {

        }

        //button pour modifier un echantillon
        private void btnModifEchantillon_Click(object sender, EventArgs e)
        { 
            string id_med = "";
            id_med = search_med_id(dtgvEchantillon.SelectedRows[0].Cells[1].Value.ToString(), id_med);
            update_echantillon(dtgvEchantillon.SelectedRows[0].Cells[0].Value.ToString(), id_med, dtgvEchantillon.SelectedRows[0].Cells[2].Value.ToString());
        }


        //button pour ajouter un echantillon
        private void button2_Click(object sender, EventArgs e)
        {
            string id_med = "";
            id_med = search_med_id(dtgvEchantillon.SelectedRows[0].Cells[1].Value.ToString(), id_med);
            insert_echantillon(id_med, tbnumrapport.Text, cbPraCR.SelectedValue, dtgvEchantillon.SelectedRows[0].Cells[2].Value.ToString());
        }

        //button pour supprimer un echantillon
        private void button1_Click(object sender, EventArgs e)
        {
            delete_echantillon(dtgvEchantillon.SelectedRows[0].Cells[1].Value.ToString());
            //MessageBox.Show(dtgvEchantillon.SelectedRows[0].Cells[1].Value.ToString());
            dtgvEchantillon.Refresh();
        }

        //button pour creer un nouveau rapport
        private void btnnew_Click(object sender, EventArgs e)
        {
            nouv_rapport(cbPraCR.SelectedValue);
            rapport_Load(idtypeemploye);
        }

        private void rtbMotif_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnumrapport_TextChanged(object sender, EventArgs e)
        {

        }

        //button pour modifier un rapport
        private void btnSrapport_Click(object sender, EventArgs e)
        {
            update_rapport(tbnumrapport.Text, cbPraCR.SelectedValue, dtCR.Value.ToString("yyyy/MM/dd"), rtbBilan.Text, rtbMotif.Text);
            rapport_Load(idtypeemploye);
        }

        //button pour supprimer un rapport
        private void btnSapport_Click(object sender, EventArgs e)
        {
            //btn click supprimer un rapport
            suppr_rapport(tbnumrapport.Text);
            rapport_Load(idtypeemploye);
        }

        private void dtCR_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
