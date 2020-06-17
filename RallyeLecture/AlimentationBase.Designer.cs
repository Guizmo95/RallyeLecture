namespace RallyeLecture
{
    partial class AlimentationBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_csv = new System.Windows.Forms.Label();
            this.label_annee = new System.Windows.Forms.Label();
            this.label_niveau = new System.Windows.Forms.Label();
            this.label_mdp = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.list_deroule_annee = new System.Windows.Forms.NumericUpDown();
            this.comboBox_niveau = new System.Windows.Forms.ComboBox();
            this.checkBox_alea = new System.Windows.Forms.CheckBox();
            this.checkBox_construit = new System.Windows.Forms.CheckBox();
            this.button_integration = new System.Windows.Forms.Button();
            this.label_fichier = new System.Windows.Forms.Label();
            this.checkbx = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_deroule_annee)).BeginInit();
            this.SuspendLayout();
            // 
            // label_csv
            // 
            this.label_csv.AutoSize = true;
            this.label_csv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_csv.Location = new System.Drawing.Point(34, 63);
            this.label_csv.Name = "label_csv";
            this.label_csv.Size = new System.Drawing.Size(205, 20);
            this.label_csv.TabIndex = 0;
            this.label_csv.Text = "Selectionner le fichier CSV :";
            // 
            // label_annee
            // 
            this.label_annee.AutoSize = true;
            this.label_annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_annee.Location = new System.Drawing.Point(34, 231);
            this.label_annee.Name = "label_annee";
            this.label_annee.Size = new System.Drawing.Size(125, 20);
            this.label_annee.TabIndex = 2;
            this.label_annee.Text = "Année Scolaire :";
            // 
            // label_niveau
            // 
            this.label_niveau.AutoSize = true;
            this.label_niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_niveau.Location = new System.Drawing.Point(34, 286);
            this.label_niveau.Name = "label_niveau";
            this.label_niveau.Size = new System.Drawing.Size(61, 20);
            this.label_niveau.TabIndex = 3;
            this.label_niveau.Text = " Niveau";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(34, 346);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(105, 20);
            this.label_mdp.TabIndex = 4;
            this.label_mdp.Text = "Mot de passe";
            // 
            // list_deroule_annee
            // 
            this.list_deroule_annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_deroule_annee.Location = new System.Drawing.Point(245, 225);
            this.list_deroule_annee.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.list_deroule_annee.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.list_deroule_annee.Name = "list_deroule_annee";
            this.list_deroule_annee.Size = new System.Drawing.Size(102, 26);
            this.list_deroule_annee.TabIndex = 7;
            this.list_deroule_annee.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // comboBox_niveau
            // 
            this.comboBox_niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_niveau.FormattingEnabled = true;
            this.comboBox_niveau.Location = new System.Drawing.Point(245, 278);
            this.comboBox_niveau.Name = "comboBox_niveau";
            this.comboBox_niveau.Size = new System.Drawing.Size(121, 28);
            this.comboBox_niveau.TabIndex = 8;
            // 
            // checkBox_alea
            // 
            this.checkBox_alea.AutoSize = true;
            this.checkBox_alea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_alea.Location = new System.Drawing.Point(211, 342);
            this.checkBox_alea.Name = "checkBox_alea";
            this.checkBox_alea.Size = new System.Drawing.Size(91, 24);
            this.checkBox_alea.TabIndex = 9;
            this.checkBox_alea.Text = "Aléatoire";
            this.checkBox_alea.UseVisualStyleBackColor = true;
            // 
            // checkBox_construit
            // 
            this.checkBox_construit.AutoSize = true;
            this.checkBox_construit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_construit.Location = new System.Drawing.Point(334, 342);
            this.checkBox_construit.Name = "checkBox_construit";
            this.checkBox_construit.Size = new System.Drawing.Size(92, 24);
            this.checkBox_construit.TabIndex = 10;
            this.checkBox_construit.Text = "Construit";
            this.checkBox_construit.UseVisualStyleBackColor = true;
            // 
            // button_integration
            // 
            this.button_integration.Location = new System.Drawing.Point(170, 383);
            this.button_integration.Name = "button_integration";
            this.button_integration.Size = new System.Drawing.Size(232, 55);
            this.button_integration.TabIndex = 11;
            this.button_integration.Text = "Lancer l\'intégration";
            this.button_integration.UseVisualStyleBackColor = true;
            this.button_integration.Click += new System.EventHandler(this.button_integration_Click);
            // 
            // label_fichier
            // 
            this.label_fichier.AutoSize = true;
            this.label_fichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fichier.Location = new System.Drawing.Point(34, 144);
            this.label_fichier.Name = "label_fichier";
            this.label_fichier.Size = new System.Drawing.Size(153, 20);
            this.label_fichier.TabIndex = 13;
            this.label_fichier.Text = "fichier csv à intégrer:";
            // 
            // checkbx
            // 
            this.checkbx.FormattingEnabled = true;
            this.checkbx.Location = new System.Drawing.Point(259, 121);
            this.checkbx.Name = "checkbx";
            this.checkbx.Size = new System.Drawing.Size(287, 79);
            this.checkbx.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Chercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlimentationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbx);
            this.Controls.Add(this.label_fichier);
            this.Controls.Add(this.button_integration);
            this.Controls.Add(this.checkBox_construit);
            this.Controls.Add(this.checkBox_alea);
            this.Controls.Add(this.comboBox_niveau);
            this.Controls.Add(this.list_deroule_annee);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_niveau);
            this.Controls.Add(this.label_annee);
            this.Controls.Add(this.label_csv);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlimentationBase";
            this.RightToLeftLayout = true;
            this.Text = "Intégration groupe de classe";
            ((System.ComponentModel.ISupportInitialize)(this.list_deroule_annee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_csv;
        private System.Windows.Forms.Label label_annee;
        private System.Windows.Forms.Label label_niveau;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown list_deroule_annee;
        private System.Windows.Forms.ComboBox comboBox_niveau;
        private System.Windows.Forms.CheckBox checkBox_alea;
        private System.Windows.Forms.CheckBox checkBox_construit;
        private System.Windows.Forms.Button button_integration;
        private System.Windows.Forms.Label label_fichier;
        private System.Windows.Forms.CheckedListBox checkbx;
        private System.Windows.Forms.Button button1;
    }
}

