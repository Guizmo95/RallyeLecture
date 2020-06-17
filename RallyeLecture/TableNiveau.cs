using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace RallyeLecture
{
    class TableNiveau
    {
        public List<Niveau> GetAll()
        {
            using (MySqlCommand c  = new MySqlCommand("select * from niveau;", Connexion.GetConnexion()))
            {
                List<Niveau> niv = new List<Niveau>();
                MySqlDataReader r = c.ExecuteReader();
                 while(r.Read())
                {
                    niv.Add(new Niveau(r.GetInt32(0), r.GetString(1)));

                }
                return niv;
            }
        }
    }
}
