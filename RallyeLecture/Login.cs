using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RallyeLecture
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            TableEnseignant enseignant = new TableEnseignant();

            string login = textBox1.Text;
            string motDePasse = textBox2.Text;

            int idEnseignant = enseignant.GetByLogin(login).Id;

            motDePasse = hash.GetHashPassword(motDePasse,idEnseignant);

            string query = "select email,pass from aauth_users;";
            MySqlCommand mySqlCommand = new MySqlCommand(query);

            MySqlDataReader d = mySqlCommand.ExecuteReader();
            if (d.HasRows==true)
            {
                this.Close();
                Application.Run(new AlimentationBase(idEnseignant));
  
            }
            else
            {
                var popup = new Form();
                popup.Text = "Veuillez réessayer login invalide";
            }
        }
    }
}
