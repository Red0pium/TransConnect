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
    public partial class FormAjoutClient : Form
    {
        private FormClients predecesseur;
        private Clients clients = null;
        public FormAjoutClient(FormClients predecesseur)
        {
            Clients clients = new Clients();
            clients.LectureFichierClient();
            this.clients= clients;
            this.predecesseur = predecesseur;
            InitializeComponent();
        }

        private void resetBox()
        {
            Box_Nss.Text = "";
            Box_Nom.Text = "";
            Box_Prenom.Text = "";
            Box_Jour.Text = "";
            Box_Mois.Text = "";
            Box_Annee.Text = "";
            Box_Adresse.Text = "";
            Box_Mail.Text = "";
            Box_Tel.Text = "";
        }

        private void btn_retour_Click(object sender, EventArgs e)
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
                Client c = new Client(Box_Nss.Text, Box_Nom.Text, Box_Prenom.Text, new DateTime(Convert.ToInt32(Box_Annee.Text), Convert.ToInt32(Box_Mois.Text), Convert.ToInt32(Box_Jour.Text))
                    , Box_Adresse.Text, Box_Mail.Text, Box_Tel.Text, 0);
                if (!(clients.ClientExiste(c)))
                {
                    DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir ajouter {Box_Prenom.Text} {Box_Nom.Text} à la liste des clients ?", "Ajout client", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        clients.AjouterClient(c);
                        MessageBox.Show($"{Box_Prenom.Text} {Box_Nom.Text} à été ajouté à la liste des clients");
                        this.resetBox();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //this.Close();
                    }
                }
                else
                    MessageBox.Show("Un client avec le même numéro de sécurité sociale existe déjà.");
            }
        }

        private void FormAjoutClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.ActualiserListeClient();
        }
    }
}
