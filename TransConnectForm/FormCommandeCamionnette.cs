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
    internal partial class FormCommandeCamionnette : Form
    {
        private FormNouvelleCommande predecesseur;
        private Client client;
        private Clients clients;
        private Salarie chauffeur;
        private DateTime date;
        private Camionnette vehicule;
        private CheminRoutier route;
        private Commandes commandes;
        public FormCommandeCamionnette(FormNouvelleCommande predecesseur, Client client, Salarie chauffeur, Camionnette vehicule, DateTime date, Commandes commandes)
        {
            this.predecesseur = predecesseur;
            clients = new Clients();
            clients.LectureFichierClient();
            this.commandes = commandes;
            route = new CheminRoutier();
            route.LectureGraphe();
            InitializeComponent();
            foreach (Noeud noeud in route.GrapheDistance.Noeuds)
            {
                cbBox_PointA.Items.Add(noeud.Valeur);
                cbBox_PointB.Items.Add(noeud.Valeur);
            }
            this.client = client;
            this.chauffeur = chauffeur;
            this.vehicule = vehicule;
            this.date = date;
            lbl_ChauffeurInfo.Text = $"{chauffeur.Prenom} {chauffeur.Nom}";
            lbl_ClientInfo.Text = $"{client.Prenom} {client.Nom}";
            lbl_Date.Text = date.ToShortDateString();
            cbBox_PointA.SelectedIndex = 0;
            cbBox_PointB.SelectedIndex = 0;
        }

        private void btn_NouvelleCommande_Click(object sender, EventArgs e)
        {
            if (cbBox_PointA.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un point de départ valide");
            }
            else if (cbBox_PointB.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un point d'arrivée valide");
            }
            else
            {
                string pointA = cbBox_PointA.Text;
                string pointB = cbBox_PointB.Text;
                double distanceParcourue = route.distance(pointA, pointB);
                double prix = vehicule.Prix(pointA, pointB, route);
                Client selectionne = clients.TrouverClient(client.Nss);
                Commande c = new Commande(commandes.ProchainNumeroDeCommande, selectionne, pointA, pointB, distanceParcourue, prix, vehicule, chauffeur, date);
                if (commandes.NouvelleCommande(c, clients))
                {
                    predecesseur.Close();
                    this.Close();
                }
            }
        }
    }
}
