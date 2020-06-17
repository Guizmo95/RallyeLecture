using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyeLecture
{
    class LesEleves
    {
        List<Eleve> lesEleves = new List<Eleve>();

        public void CreateCsvPasswordFile()
        {
            using (StreamWriter csvPassword = new StreamWriter("MotDePasse.csv"))
            {
                foreach (Eleve eleve in lesEleves)
                {
                    csvPassword.WriteLine("Login : {0}, Mot De Passe : {1}", eleve.Login, eleve.Password); 
                }
            }
        }

        public List<Eleve> LoadCsv(PassWordType psw,Stream fileStream)
        {

            string ligne;
            char caractere = ';';
            using (StreamReader sr = new StreamReader(fileStream))
            {
                List<Eleve> lesEleves = new List<Eleve>();
                while ((ligne = sr.ReadLine()) != null)
                {
                    String[] csv = ligne.Split(caractere);


                    Eleve eleve = new Eleve(csv[0], csv[1], string.Format("{0}{1}@sio.jjr.fr", csv[0], csv[1]));
                    if (psw == PassWordType.Aléatoire)
                    {
                        eleve.Password = Eleve.GetPasswordAleatoire();
                    }
                    else
                    {
                        eleve.Password = eleve.GetPasswordConstruit(eleve);

                    }
                    lesEleves.Add(eleve);

                }
            }
            return lesEleves;
        }
    }
}
