using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RallyeLecture
{
    static public class Connexion
    {
        static MySqlConnection cnx;
        static string _host;
        static string _user;
        static string _pwd;
        static string _bdd;

        static public void SetConnectionMySql(string h, string user, string pwd, string bdd)
        {
            _host = h;
            _user = user;
            _pwd = pwd;
            _bdd = bdd;

        }

        static public MySqlConnection GetConnexion()
        {
            if(cnx ==null)
            {
                return cnx = new MySqlConnection(string.Format("host={0},user={1},pwd={2},database={3}", _host, _user, _pwd, _bdd));
            }
            else
            {
                return cnx;
            }
        }
    
    
    }
        }


