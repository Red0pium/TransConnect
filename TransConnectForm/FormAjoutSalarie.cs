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
    public partial class FormAjoutSalarie : Form
    {
        private FormPersonnel predecesseur;
        private Salaries salaries;
        public FormAjoutSalarie(FormPersonnel predecesseur)
        {
            this.predecesseur = predecesseur;
            Salaries salaries = new Salaries();
            salaries.LectureFichierSalaries();
            this.salaries= salaries;
            InitializeComponent();
            Cbbox_ChefEquipe.Hide();
            lbl_ChefEquipe.Hide();
            for (int i = 1; i <= salaries.NbChefEquipe; i++)
            {
                Cbbox_ChefEquipe.Items.Add($"Chef d'équipe {i}");
            }
            Cbbox_ChefEquipe.SelectedIndex= 0;
            comboBox1.SelectedIndex=0;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { Cbbox_ChefEquipe.Show();lbl_ChefEquipe.Show(); }
            else { Cbbox_ChefEquipe.Hide(); lbl_ChefEquipe.Hide();}
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string poste = null;
            string superieur = null;
            double salaire = 0;
            bool directeur = false;
            bool ajout = true;
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Poste séléctionné incorrect");
                ajout = false;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                if (Cbbox_ChefEquipe.SelectedIndex == -1)
                {
                    MessageBox.Show("Chef d'équipe séléctionné incorect");
                    ajout = false;
                }
                else
                {
                    poste = "Chauffeur";
                    superieur = $"Chef Equipe {Cbbox_ChefEquipe.SelectedIndex + 1}";
                    salaire = 5000;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                poste = $"Chef Equipe {salaries.NbChefEquipe + 1}";
                superieur = "Directeur des operations";
                salaire = 8000;
                directeur = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                poste = "Comptable";
                superieur = "Direction comptable";
                salaire = 7000;
            }
            if (Box_Nss.Text.Length != 15)
            {
                ajout= false;
                MessageBox.Show("Le numéro de sécurité sociale doit contenir 15 chiffres");
            }
            if (Box_Tel.Text.Length != 10)
            {
                ajout= false;
                MessageBox.Show("Le numéro de téléphone doit contenir 10 chiffres");
            }
            if (ajout)
            {
                Salarie s = new Salarie(Box_Nss.Text, Box_Nom.Text, Box_Prenom.Text, new DateTime(Convert.ToInt32(Box_Annee.Text), Convert.ToInt32(Box_Mois.Text), Convert.ToInt32(Box_Jour.Text))
                    , Box_Adresse.Text, Box_Mail.Text, Box_Tel.Text, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), poste, salaire, superieur, directeur);
                if (!(salaries.SalarieExiste(s)))
                {
                    DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir recruter {Box_Prenom.Text} {Box_Nom.Text} en tant que {s.Poste} ?", "Ajout salarié", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        salaries.AjouterSalarie(s);
                        MessageBox.Show($"{Box_Prenom.Text} {Box_Nom.Text} à été recruté en tant que {s.Poste}");
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else
                    MessageBox.Show("Un salarié avec le même numéro de sécurité sociale existe déjà.");
            }
        }

        private void FormAjoutSalarie_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.Actualiser();
        }
    }
    
}
