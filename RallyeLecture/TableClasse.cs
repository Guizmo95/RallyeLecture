using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RallyeLecture
{
    class TableClasse
    {
        public void Insert(Classe classe)
        {
            using (MySqlCommand command = new MySqlCommand(string.Format("insert into classe (idEnseignant, anneeScolaire, idNiveau) values ({0}, {1}, {2})", classe.IdEnseignant, classe.AnnéeScolaire, classe.IdNiveau), Connexion.GetConnexion()))
            {
                command.ExecuteNonQuery();
            }
        }
        
        
        
    }
}
