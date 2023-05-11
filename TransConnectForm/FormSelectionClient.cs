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
    internal partial class FormSelectionClient : Form
    {
        private Client retour;
        private Clients clients;

        public Client Retour
        { get { return retour; } }

        public FormSelectionClient()
        {
            retour = null;
            clients = new Clients();
            clients.LectureFichierClient();
            InitializeComponent();
            TableauClient.DataSource = clients.ListeClients;
        }

        private void btn_Validation_Click(object sender, EventArgs e)
        {
            if (TableauClient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Aucune ligne n'a été sélectionnée");
            }
            else if (TableauClient.SelectedRows.Count > 1)
            {
                MessageBox.Show("Il n'est possible de sélectionner qu'un seul chauffeur à la fois");
            }
            else
            {
                int indice = TableauClient.SelectedRows[0].Index;
                DialogResult dialogResult = MessageBox.Show($"Selectionner le client {clients.ListeClients[indice].Prenom} {clients.ListeClients[indice].Nom} ?", "Selection client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show($"Le client {clients.ListeClients[indice].Prenom} {clients.ListeClients[indice].Nom} à été sélectionné");
                    retour = clients.ListeClients[indice];
                    DialogResult = DialogResult.OK;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}

