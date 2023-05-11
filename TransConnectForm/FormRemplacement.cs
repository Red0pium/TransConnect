using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransConnectForm
{
    internal partial class FormRemplacement : Form
    {
        private FormPersonnel predecesseur;
        private Salarie remplace;
        private Salaries salaries;

        public FormRemplacement(FormPersonnel predecesseur,Salarie remplace,Salaries salaries)
        {
            InitializeComponent();
            this.predecesseur= predecesseur;
            this.Text += $" {remplace.Prenom} {remplace.Nom}/{remplace.Poste}";
            this.salaries = salaries;
            this.remplace = remplace;
        }

        private void btn_remplacer_Click(object sender, EventArgs e)
        {
            bool ajout = true;
            if (Box_Nss.Text.Length != 15)
            {
                ajout = false;
                MessageBox.Show("Le numéro de sécurité sociale doit contenir 15 chiffres");
            }
            if (Box_Tel.Text.Length != 10)
            {
                ajout = false;
                MessageBox.Show("Le numéro de téléphone doit contenir 10 chiffres");
            }
            if (ajout)
            {
                Salarie remplacant = new Salarie(Box_Nss.Text, Box_Nom.Text, Box_Prenom.Text, new DateTime(Convert.ToInt32(Box_Annee.Text), Convert.ToInt32(Box_Mois.Text), Convert.ToInt32(Box_Jour.Text))
                    , Box_Adresse.Text, Box_Mail.Text, Box_Tel.Text,new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day),remplace.Poste,remplace.Salaire,remplace.PosteSuperieur,remplace.EstDirecteur);
                salaries.Remplacement(remplace,remplacant);
                this.Close();
            }
        }

        private void FormRemplacement_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.Actualiser();
        }
    }
}
