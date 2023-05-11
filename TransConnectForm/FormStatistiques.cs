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
    public partial class FormStatistiques : Form
    {
        private Formulaire_principal formulaire_principal;
        private Salaries salaries;
        private Clients clients;
        private Client client;
        private Vehicules vehicules;
        private Commandes commandes;
        private List<Commande> commandesIntervalTemps;
        private List<Commande> commandesClient;
        private List<StatNbLivraison> nbLivraisons;
        private StatMoyennePrixCommande statMoyennePrixCommande;
        public FormStatistiques(Formulaire_principal formulaire_principal)
        {
            salaries = new Salaries();
            salaries.LectureFichierSalaries();
            clients = new Clients();
            clients.LectureFichierClient();
            vehicules = new Vehicules();
            vehicules.LectureFichierVehicule();
            commandes = new Commandes();
            commandes.LectureFichierCommande(clients, vehicules, salaries);
            statMoyennePrixCommande = new StatMoyennePrixCommande(commandes);
            client = null;

            

            StartPosition = FormStartPosition.CenterScreen;
            this.formulaire_principal = formulaire_principal;
            InitializeComponent();
            StatNombrebLivraisons();
            btn_Selection.Hide();
            lbl_clientSelect.Hide();
            lbl_clientSelect2.Hide();
            lbl_clientSelect2.Text = "Aucun";
            lbl_date1.Hide();
            lbl_date2.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            cbBox_StatAAfficher.SelectedIndex = 0;
        }

        private void StatNombrebLivraisons()
        {
            nbLivraisons = new List<StatNbLivraison>();
            foreach (Salarie salarie in salaries.ListeSalaries)
            {
                if (salarie.Poste == "Chauffeur")
                    nbLivraisons.Add(new StatNbLivraison(salarie));
            }
            Tableau.DataSource = nbLivraisons;
        }

        private void CommandesIntervalTemps()
        {
            Tableau.DataSource = commandesIntervalTemps;
        }

        private void MoyennePrixCommande()
        {
            Tableau.DataSource = new List<StatMoyennePrixCommande>() { statMoyennePrixCommande };
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette interface graphique à été crée par Mathys Bronnec à l'aide de Windows Forms qui n'est pas le plus courrant quand il s'agit de création de Formulaire, WPF aurait été plus adapté mais n'étais pas aussi simple d'utilisation à mes yeux");
        }

        private void ListeCommandePourClient(Client client)
        {
            commandesClient = new List<Commande>();
            commandes.LectureFichierCommande(clients, vehicules, salaries);
            foreach(Commande commande in commandes.ListeCommandes)
                if (commande.Client.Nss==client.Nss)
                {
                    commandesClient.Add(commande);
                }
            Tableau.DataSource = commandesClient;
        }

        private void StatistiquesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulaire_principal.Close();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulaire_principal.Show();
        }

        private void FormStatistiques_Load(object sender, EventArgs e)
        {
            salaries = new Salaries();
            salaries.LectureFichierSalaries();
            clients = new Clients();
            clients.LectureFichierClient();
            vehicules = new Vehicules();
            vehicules.LectureFichierVehicule();
            commandes = new Commandes();
            commandes.LectureFichierCommande(clients, vehicules, salaries);
            statMoyennePrixCommande = new StatMoyennePrixCommande(commandes);
        }

        private void CommandeSelonUnePeriodeDeTemps(DateTime date1, DateTime date2)
        {
            if (date1 > date2) 
            {
                MessageBox.Show("La date1 est plus récente que la date 2");
            }
            else
            {
                commandesIntervalTemps = new List<Commande>();
                foreach (Commande commande in commandes.ListeCommandes)
                {
                    if (commande.Date>=date1 && commande.Date<=date2)
                    {
                        commandesIntervalTemps.Add(commande);
                    }
                }
                Tableau.DataSource= commandesIntervalTemps;
            }
        }

        private Client SelectionnerClient()
        {
            Client retour = null;
            using (FormSelectionClient f = new FormSelectionClient())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    retour = f.Retour;
                }
            }
            return retour;
        }

        private void btn_SelectionClient_Click(object sender, EventArgs e)
        {
            client = SelectionnerClient();
            if (client == null)
                lbl_clientSelect2.Text = "Aucun";
            else
                lbl_clientSelect2.Text = client.ToString();
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            if (cbBox_StatAAfficher.SelectedIndex== -1)
            {
                MessageBox.Show("Veuillez selectionner une statistique valide");
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 0)
            {
                //Nombre de livraison par chauffeur
                StatNombrebLivraisons();
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 1)
            {
                //Commandes selon une période de temps
                CommandeSelonUnePeriodeDeTemps(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 2)
            {
                //Moyenne des prix de commandes
                MoyennePrixCommande();
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 3)
            {
                //Liste des commandes pour un client
                if (client== null)
                {
                    MessageBox.Show("Aucun client n'a été sélectionné");
                }
                else
                    ListeCommandePourClient(client);
            }
        }

        private void cbBox_StatAAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_StatAAfficher.SelectedIndex == 0)
            {
                //Nombre de livraison par chauffeur
                btn_Selection.Hide();
                lbl_clientSelect.Hide();
                lbl_clientSelect2.Hide();
                lbl_date1.Hide();
                lbl_date2.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 1)
            {
                //Commandes selon une période de temps
                btn_Selection.Hide();
                lbl_clientSelect.Hide();
                lbl_clientSelect2.Hide();
                lbl_date1.Show();
                lbl_date2.Show();
                dateTimePicker1.Show();
                dateTimePicker2.Show();
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 2)
            {
                //Moyenne des prix de commandes
                btn_Selection.Hide();
                lbl_clientSelect.Hide();
                lbl_clientSelect2.Hide();
                lbl_date1.Hide();
                lbl_date2.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
            }
            else if (cbBox_StatAAfficher.SelectedIndex == 3)
            {
                //Liste des commandes pour un client
                btn_Selection.Show();
                lbl_clientSelect.Show();
                lbl_clientSelect2.Show();
                lbl_date1.Hide();
                lbl_date2.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
            }
        }
    }
}
