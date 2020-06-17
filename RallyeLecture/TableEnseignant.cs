using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyeLecture
{
    class TableEnseignant
    {
        public Enseignant GetByLogin(string login)
        {

            MySqlCommand command = new MySqlCommand(string.Format("select * from enseignant where login={0}", Connexion.GetConnexion()));
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {

                Enseignant e = new Enseignant(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));

                return e;



            }

        }
    }
}
