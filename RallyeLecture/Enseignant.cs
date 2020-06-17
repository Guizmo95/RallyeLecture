using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyeLecture
{
    class Enseignant
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string hashPassWord;

        public int Id { get => id;  private set => id = value; }

        public Enseignant(int id, string nom, string prenom, string login, string hashPassWord)
        {
            this.Id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }

     
    }
}
