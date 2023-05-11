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
    internal partial class FormNouveauVehicule : Form
    {
        private Vehicules vehicules;
        private FormGarage predecesseur;
        public FormNouveauVehicule(FormGarage predecesseur,Vehicules vehicules)
        {
            InitializeComponent();
            this.predecesseur = predecesseur;
            this.vehicules = vehicules;
            cbBox_TypeDeCuve.SelectedIndex = 0;
            cbBox_TypeDeVehicule.SelectedIndex = 0;
            ToutCacher();
        }

        private void ToutCacher()
        {
            cbBox_TypeDeCuve.Hide();
            lbl_CamionCiterne1.Hide();
            lbl_nbPlace1.Hide();
            lbl_nbPlace2.Hide();
            lbl_Volume1.Hide();
            lbl_Volume2.Hide();
            Box_nbPlace.Hide();
            Box_Volume.Hide();
        }

        private void AjoutVehicule(Vehicule vehicule)
        {
            DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir ajouter le vehicule à la liste des vehicules ?", "Ajout vehicule", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                vehicules.AjouterVehicule(vehicule);
                MessageBox.Show($"Le vehicule à été ajouté à la liste des vehicules");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //this.Close();
            }
        }
        private void btn_Ajout_Click(object sender, EventArgs e)
        {
            if(Box_plaqueImmatriculation1.Text.Length!=2 || Box_plaqueImmatriculation2.Text.Length!=3 || Box_plaqueImmatriculation3.Text.Length !=2)
            {
                MessageBox.Show("Format de la plaque d'immatriculation invalide");
            }
            else if(cbBox_TypeDeVehicule.SelectedIndex==-1)
            {
                MessageBox.Show("Veuillez sélectionner un type de vehicule valide");
            }
            else
            {
                string plaqueImmatriculation = $"{Box_plaqueImmatriculation1.Text}-{Box_plaqueImmatriculation2.Text}-{Box_plaqueImmatriculation3.Text}".ToUpper();
                if (cbBox_TypeDeVehicule.Text.Contains("benne"))
                {
                    Vehicule vehicule = new CamionBenne(plaqueImmatriculation);
                    AjoutVehicule(vehicule);
                }
                else if (cbBox_TypeDeVehicule.Text.Contains("citerne"))
                {
                    int volume = 0;
                    if (int.TryParse(Box_Volume.Text, out volume))
                    {
                        if (cbBox_TypeDeCuve.SelectedIndex == -1) 
                        {
                            MessageBox.Show("Veuillez selectionner un type de cuve valide");
                        }
                        else
                        {
                            Vehicule vehicule = new CamionCiterne(plaqueImmatriculation, volume, false, cbBox_TypeDeCuve.Text.ToLower());
                            AjoutVehicule(vehicule);
                        }
                    }
                    else
                        MessageBox.Show("Le volume entré n'est pas valide");
                }
                else if (cbBox_TypeDeVehicule.Text.Contains("frigorifique"))
                {
                    Vehicule vehicule = new CamionFrigorifique(plaqueImmatriculation);
                    AjoutVehicule(vehicule);
                }
                else if (cbBox_TypeDeVehicule.Text=="Camionnette")
                {
                    Vehicule vehicule = new Camionnette(plaqueImmatriculation);
                    AjoutVehicule(vehicule);
                }
                else if (cbBox_TypeDeVehicule.Text=="Car")
                {
                    int nbPlace = 0;
                    if(int.TryParse(Box_nbPlace.Text,out nbPlace))
                    {
                        Vehicule vehicule = new Car(plaqueImmatriculation,nbPlace);
                        AjoutVehicule(vehicule);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un nombre de place valide");
                    }
                }
            }
        }

        private void cbBox_TypeDeVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_TypeDeVehicule.SelectedIndex==-1)
            {
                ToutCacher();
            }
            else if (cbBox_TypeDeVehicule.Text.Contains("benne"))
            {
                ToutCacher();
            }
            else if (cbBox_TypeDeVehicule.Text.Contains("citerne"))
            {
                ToutCacher();
                cbBox_TypeDeCuve.Show();
                lbl_CamionCiterne1.Show();
                lbl_Volume1.Show();
                lbl_Volume2.Show();
                Box_Volume.Show();
            }
            else if (cbBox_TypeDeVehicule.Text.Contains("frigorifique"))
            {
                ToutCacher();
            }
            else if (cbBox_TypeDeVehicule.Text == "Camionnette")
            {
                ToutCacher();
            }
            else if (cbBox_TypeDeVehicule.Text == "Car")
            {
                ToutCacher();
                lbl_nbPlace2.Show();
                lbl_nbPlace1.Show();
                Box_nbPlace.Show();
                Box_Volume.Show();
            }
        }

        private void FormNouveauVehicule_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.Actualiser();
        }
    }
}
