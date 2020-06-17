using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyeLecture
{
    class Classe
    {
        private int idEnseignant;
        private string annéeScolaire;
        private int idNiveau;

        public Classe(int idEnseignant, string annéeScolaire, int idNiveau)
        {
            this.idEnseignant = idEnseignant;
            this.annéeScolaire = annéeScolaire;
            this.idNiveau = idNiveau;
        }

        public int IdEnseignant { get => idEnseignant; set => idEnseignant = value; }
        public string AnnéeScolaire { get => annéeScolaire; set => annéeScolaire = value; }
        public int IdNiveau { get => idNiveau; set => idNiveau = value; }
    }
}
