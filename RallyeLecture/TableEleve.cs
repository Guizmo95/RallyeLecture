using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyeLecture
{
    class TableEleve
    {
        public void Insert(Eleve eleve)
        {
            Hash hash = new Hash();
            MySqlCommand mySqlCommand = new MySqlCommand("Select max(id) from aauth_users;");
            //MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader(mySqlCommand);
            //mySqlDataReader.
            //   //TODO FINIR 
            //string mdpHash = hash.GetHashPassword(eleve.Password, )

            using (MySqlCommand command2 = new MySqlCommand(string.Format("insert into eleve (nom, prenom,login) values ({0}, {1}, {2})", eleve.Nom, eleve.Prenom, eleve.Login), Connexion.GetConnexion()))
            {
                command2.ExecuteNonQuery();
            }

            using (MySqlCommand command1 = new MySqlCommand(string.Format("Insert into aauth_users (email, pass, username) values({0}, {1}, {2})", string.Format("{0}@gmail.com", eleve.Login), eleve.Password, eleve.Nom + eleve.Prenom)))
            {
                command1.ExecuteNonQuery();
                int id = Convert.ToInt32(command1.LastInsertedId);
                using (MySqlCommand command3 = new MySqlCommand(string.Format("insert into aauth_user_to_group(user_id, group_id) values ({0}, {1})", id, 4)))
                {
                    command3.ExecuteNonQuery();
                }
            }


            

            //auth user to group

        }
    }
}
