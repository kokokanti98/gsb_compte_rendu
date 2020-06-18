using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gbs_gcr1.config
{
    class connexion
    {
        internal string datasource = "127.0.0.1";//127.0.0.1
        internal string port = "3306"; //3306
        internal string username = "root"; //root
        internal string password = ""; //none
        internal string database = "gsb_frais";//gsb_frais
        public string connexionstring(string p_connexionstring)
        {
            p_connexionstring = "datasource="+ datasource + ";port="+ port + ";username="+ username + ";" +
                "password="+ password + ";database="+ database + "";
            return p_connexionstring;
        }
        public void btnhide(string p_temploye,Button p_btnajout, Button p_btnmodif, Button p_btnsuppr)
        {
            if (p_temploye == "ADM")
            {
                p_btnajout.Show();
                p_btnmodif.Show();
                p_btnsuppr.Show();
            }
            else
            {
                p_btnajout.Hide();
                p_btnmodif.Hide();
                p_btnsuppr.Hide();
            }
        }
    }
}
