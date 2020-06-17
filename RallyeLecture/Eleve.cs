using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RallyeLecture
{
    class Eleve
    {
        string nom;
        string prenom;
        string login;
        string password;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public Eleve(string nom, string prenom, string login)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.Password = GetPasswordAleatoire();
        }

        public static string GetPasswordAleatoire()
        {
            string carac = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN&éèçà0123456789+*!?/§£$ù%µ¤";
            int lim = 12;
            Random pswdAlea = new Random();
            string pswrd = "";
            for(int i = 0; i < lim; i++)
            {
                pswrd += carac[pswdAlea.Next(0, carac.Length)];
            }
            return pswrd;
        } 
        public override string  ToString()
        {
            return string.Format("Le mot de passe est {0}",Password);

        }

        public string GetPasswordConstruit(Eleve eleve)
        {

            string mdp = string.Format("{0}{1}", eleve.prenom[0], eleve.nom);

            return mdp;

            //string mdp;
            //int compteur = 0;
            //string ligne;
            //char virgule = ';';
            //System.IO.StreamReader fichier = new System.IO.StreamReader(fileStream);
            //while((ligne=fichier.ReadLine())!= null)
            //{
            //    string[] substrings = ligne.Split(virgule);
            //    mdp=string.Format("{0}{1}\n",substrings[0][0],substrings[1]);
            //    compteur++;
            //}

            //fichier.Close();
            //int fin = compteur;
            //string[] liste = new string[fin];

            //return mdp;
        }

        public static string GetPasswordAleatoireConstruit()
        {
            FileInfo fichier2 = new FileInfo("P:/RallyeLecture/NewClasse.txt");
            if (fichier2.Exists)
            {
                fichier2.Delete();
            }
            fichier2.Create();

            int compteur = 0;
            string ligne;
            char virgule = ';';
            string carac = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN&éèçà0123456789+*!?/§£$ù%µ¤";
            int lim = 12;
            int lim2 = 8;
            Random pswdAlea = new Random();
            string pswrd = "";
            string pswrd2 = "";
            for (int i = 0; i < lim2; i++)
            {
                pswrd2 += carac[pswdAlea.Next(0, carac.Length)];
            }
            
            System.IO.StreamReader fichier = new System.IO.StreamReader(@"P:\RallyeLecture\maClasseCm2_2018test.txt");
            while ((ligne = fichier.ReadLine()) != null)
            {
                string[] substrings = ligne.Split(virgule);
           
                
                    for (int i = 0; i < lim; i++)
                    {
                        pswrd = pswrd2 + carac[pswdAlea.Next(0, carac.Length)];
                    }
                 
 
                if (compteur % 2 == 0)
                {
                    Console.Write(string.Format("{0}{1}\n", substrings[0][0], substrings[1]));
                    
                }
                else
                {
                    Console.Write(string.Format("{0}\n", pswrd));
                }
        
                
                compteur++;

            }

            fichier.Close();
            int fin = compteur;
            string[] liste = new string[fin];

            return string.Format("nombre d'éleves traités : {0}", compteur);
        }
    }
}
