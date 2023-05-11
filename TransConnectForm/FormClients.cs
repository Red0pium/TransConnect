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
    public partial class FormClients : Form
    {
        private Clients clients;
        private Formulaire_principal predecesseur;
        private bool modification;

        public FormClients(Formulaire_principal predecesseur)
        {
            this.modification = false;
            StartPosition = FormStartPosition.CenterScreen;
            Clients clients = new Clients();
            clients.LectureFichierClient();
            clients.ListeClients.Sort();
            this.clients = clients;
            this.predecesseur = predecesseur;
            InitializeComponent();
        }

        public void ActualiserListeClient()
        {
            if(modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Voulez vous valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clients.ActualiserFichier();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            modification = false;
            clients.LectureFichierClient();
            if (comboBox_tri.SelectedIndex == 0)
            {
                clients.ListeClients.Sort();
            }
            else if (comboBox_tri.SelectedIndex == 1)
            {
                clients.ListeClients.Sort((a,b)=>a.TriParVille(b));
            }
            else if (comboBox_tri.SelectedIndex == 2)
            {
                clients.ListeClients.Sort((a, b) => a.TriParAchat(b));
            }
            TableauClients.DataSource = clients.ListeClients;

            TableauClients.Columns[0].ReadOnly = true;
            TableauClients.Columns[1].ReadOnly = true;
            TableauClients.Columns[2].ReadOnly = false;
            TableauClients.Columns[3].ReadOnly = true;
            TableauClients.Columns[4].ReadOnly = true;
            TableauClients.Columns[5].ReadOnly = false;
            TableauClients.Columns[6].ReadOnly = false;
            TableauClients.Columns[7].ReadOnly = false;
        }

        private void FormGestionClients_Load(object sender, EventArgs e)
        {
            TableauClients.DataSource = clients.ListeClients;
            comboBox_tri.SelectedIndex = 0;
        }



        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette interface graphique à été crée par Mathys Bronnec à l'aide de Windows Forms qui n'est pas le plus courrant quand il s'agit de création de Formulaire, WPF aurait été plus adapté mais n'étais pas aussi simple d'utilisation à mes yeux");
        }

        private void FormGestionClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Voulez valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clients.ActualiserFichier();
                }
                else if (dialogResult == DialogResult.No)
                {
                    clients.LectureFichierClient();
                }
            }
            modification = false;
            predecesseur.Close();
        }

        private void FormGestionClients_Shown(object sender, EventArgs e)
        {
            ActualiserListeClient();
        }

        private void btn_AjouterClient_Click(object sender, EventArgs e)
        {
            if (modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Voulez valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clients.ActualiserFichier();
                }
                else if (dialogResult == DialogResult.No)
                {
                    clients.LectureFichierClient();
                }
            }
            modification = false;
            FormAjoutClient f = new FormAjoutClient(this);
            f.Show();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            if (modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Voulez valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clients.ActualiserFichier();
                }
                else if (dialogResult == DialogResult.No)
                {
                    clients.LectureFichierClient();
                }
            }
            modification = false;
            this.Hide();
            predecesseur.Show();
        }

        private void btn_Actualiser_Click(object sender, EventArgs e)
        {
            ActualiserListeClient();
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            if (TableauClients.SelectedRows.Count == 0)
                MessageBox.Show("Aucune ligne n'a été selectionnée");
            else if (TableauClients.SelectedRows.Count == 1)
            {
                int indice = TableauClients.SelectedRows[0].Index;
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir supprimer {clients.ListeClients[indice].Prenom} {clients.ListeClients[indice].Nom} de la liste des clients ?", "Suppression client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show($"{clients.ListeClients[indice].Prenom} {clients.ListeClients[indice].Nom} à été supprimé de la liste des clients");
                    clients.SupprimerClient(clients.ListeClients[indice]);
                    ActualiserListeClient();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir supprimer les clients séléctionnés de la liste des clients ?", "Suppression clients", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int indice = 0;
                    List<Client> clientsSuppr = new List<Client>();
                    for (int i = 0; i<TableauClients.SelectedRows.Count; i++)
                    {
                        indice = TableauClients.SelectedRows[i].Index;
                        clientsSuppr.Add(clients.ListeClients[indice]);
                    }
                    MessageBox.Show($"Les clients ont été supprimé de la liste des clients");
                    clients.SupprimerClient(clientsSuppr);
                    ActualiserListeClient();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void TableauClients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modification = true;
        }

        private void btn_Modifications_Click(object sender, EventArgs e)
        {
            if (modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clients.ActualiserFichier();
                }
                else if (dialogResult == DialogResult.No)
                {
                    clients.LectureFichierClient();
                }
                modification = false;
                ActualiserListeClient();
            }
            else
                MessageBox.Show("Aucune modification n'a été effectuée");
        }
    }
}
