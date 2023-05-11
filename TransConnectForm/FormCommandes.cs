using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransConnectForm
{
    public partial class FormCommandes : Form
    {
        private Clients clients;
        private Vehicules vehicules;
        private Salaries salaries;
        private Commandes commandes;
        private Formulaire_principal formulaire_principal;
        private List<Commande> commandesEnCours;
        private CheminRoutier route;

        public FormCommandes(Formulaire_principal formulaire_principal)
        {
            route = new CheminRoutier();
            route.LectureGraphe();
            commandesEnCours = new List<Commande>();
            clients = new Clients();
            clients.LectureFichierClient();
            vehicules=new Vehicules();
            vehicules.LectureFichierVehicule();
            salaries = new Salaries();
            salaries.LectureFichierSalaries();
            commandes = new Commandes();
            commandes.LectureFichierCommande(clients,vehicules,salaries);
            StartPosition = FormStartPosition.CenterScreen;
            if (commandes.ListeCommandes != null)
                foreach (Commande commande in commandes.ListeCommandes)
                    if (commande.Date >= DateTime.Today)
                        commandesEnCours.Add(commande);
            this.formulaire_principal = formulaire_principal;
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette interface graphique à été crée par Mathys Bronnec à l'aide de Windows Forms qui n'est pas le plus courrant quand il s'agit de création de Formulaire, WPF aurait été plus adapté mais n'étais pas aussi simple d'utilisation à mes yeux");
        }

        private void CommandesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulaire_principal.Close();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulaire_principal.Show();
        }

        private void FormCommandes_Load(object sender, EventArgs e)
        {
            TableauCommandes.DataSource = commandesEnCours;
        }

        private void btn_NouvelleCommande_click(object sender, EventArgs e)
        {
            salaries.LectureFichierSalaries();
            FormNouvelleCommande f = new FormNouvelleCommande(this,vehicules,salaries);
            f.Show();
        }

        public void Actualiser()
        {
            commandes.LectureFichierCommande(clients, vehicules, salaries);
            commandesEnCours = new List<Commande>();
            if (commandes.ListeCommandes != null)
                foreach (Commande commande in commandes.ListeCommandes)
                    if (commande.Date >= DateTime.Today)
                        commandesEnCours.Add(commande);
            TableauCommandes.DataSource = commandesEnCours;
        }

        private void btn_Actualiser_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            if(TableauCommandes.SelectedRows.Count==0)
            {
                MessageBox.Show("Aucune ligne n'a été selectionnée");
            }
            else if(TableauCommandes.SelectedRows.Count>1)
            {
                MessageBox.Show("Vous ne pouvez annuler qu'une seule commande à la fois");
            }
            else
            {
                Commande selection = commandes.TrouverCommande(TableauCommandes.SelectedRows[0].Cells["NumeroCommande"].Value.ToString());
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir annuler la commande n°{selection.NumeroCommande} ?", "Annulation commande", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clients.LectureFichierClient();
                    commandes.AnnulerCommande(selection, clients);
                    Actualiser();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

        private void btn_Chemin_Click(object sender, EventArgs e)
        {
            if (TableauCommandes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Aucune ligne n'a été selectionnée");
            }
            else if (TableauCommandes.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez annuler qu'une seule commande à la fois");
            }
            else
            {
                Commande selection = commandes.TrouverCommande(TableauCommandes.SelectedRows[0].Cells["NumeroCommande"].Value.ToString());
                FormChemin f = new FormChemin(route.GrapheDistance.dijkstraChemin(route.GrapheDistance.RechercheNoeud(selection.PointA), route.GrapheDistance.RechercheNoeud(selection.PointB)),Convert.ToString(selection.NumeroCommande));
                f.Show();
            }
        }
    }
}
