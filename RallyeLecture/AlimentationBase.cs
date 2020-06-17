using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace RallyeLecture
{
    public partial class AlimentationBase : Form
    {
        private int idEnseignant;
        private List<Stream> fileStreams;
        public AlimentationBase(int idEnseignant)
        {
            InitializeComponent();
            comboBox_niveau.Items.Add("CP");
            comboBox_niveau.Items.Add("CE1");
            comboBox_niveau.Items.Add("CE2");
            comboBox_niveau.Items.Add("CM1");
            comboBox_niveau.Items.Add("CM2");
            comboBox_niveau.SelectedIndex = 0;
            checkBox_alea.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox_construit.CheckedChanged += CheckBox2_CheckedChanged;
            string[] fich = Directory.GetDirectories(@"C:\");
            this.idEnseignant = idEnseignant;

            fileStreams = new List<Stream>();
        }

        private void charge_fich(List<string> filesNames)
        {
            foreach(string fileName in filesNames)
            {
                checkbx.Items.Add(fileName);
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_construit.Checked==true)
            {
                checkBox_alea.Checked = false;
                
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_alea.Checked == true)
            {
                checkBox_construit.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> filesNames = new List<string>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "csv files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(String file in openFileDialog.SafeFileNames)
                    {
                        filesNames.Add(file);
                        fileStreams.Add(openFileDialog.OpenFile());
                    }
                    
                }

            }
            charge_fich(filesNames);

        }

        private void button_integration_Click(object sender, EventArgs e)
        {
            List<Eleve> eleves = new List<Eleve>();
            Hash hash = new Hash();
            MySqlCommand mySqlCommand = new MySqlCommand();
                
            LesEleves lesEleves = new LesEleves();
            TableEleve tableEleve = new TableEleve();
            int idClasse = comboBox_niveau.SelectedIndex + 1;

            Classe classe = new Classe(idEnseignant, Convert.ToString(list_deroule_annee.Value), idClasse);

            TableClasse tc = new TableClasse();
            tc.Insert(classe);

            PassWordType passWordType;

            if (checkBox_alea.Checked)
            {
                passWordType = PassWordType.Aléatoire;
            }
            else
            {
                passWordType = PassWordType.Construit;
            }

            fileStreams.ForEach(delegate (Stream stream)
            {
                eleves.AddRange(lesEleves.LoadCsv(passWordType, stream));
            });

            eleves.ForEach(delegate (Eleve eleve)
            {
                tableEleve.Insert(eleve);
            });

            


        }
    }
}
