using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RallyeLecture
{
    class Niveau
    {
        private int id;
        private string niveauScolaire;
        List<Niveau> lesNiveaux = new List<Niveau>();

        public Niveau(int id, string niveauScolaire)
        {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
            lesNiveaux.Add(this);
        }



        public int Id { get => id; set => id = value; }
        public string NiveauScolaire { get => niveauScolaire; set => niveauScolaire = value; }

        public List<Niveau> GetAll()
        {
            return lesNiveaux;
        }
    }
}
