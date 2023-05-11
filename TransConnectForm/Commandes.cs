using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Commandes
    {
        private List<Commande> commandes;
        private int prochainNumeroDeCommande = 0;

        public int ProchainNumeroDeCommande
        { get { return prochainNumeroDeCommande; } }

        public List<Commande> ListeCommandes
        { get { return commandes; } }

        public Commandes(List<Commande> commandes=null)
        {
            this.commandes = commandes;
        }

        //Méthode utilisée pour créer le fichier dans le bon répertoire, mise en commentaire car peut écraser le fichier
        /*
        public static void CreerFichier()
        {
            StreamWriter writer = new StreamWriter("Commandes.csv");
            writer.Write("Numéro de commande;Nss du Client;Point de départ;Point d'arrivée;Distance parcourue;Prix;Plaque du véhicule utilisé;Nss du chauffeur;Date\n");
            writer.Close();
        }
        */
        
        public void LectureFichierCommande(Clients clients,Vehicules vehicules,Salaries salaries)
        {
            prochainNumeroDeCommande = 1;
            this.commandes = new List<Commande>();
            string[] lignes = File.ReadAllLines("Commandes.csv");
            string[] attributs = new string[9];
            string[] date = new string[3];
            for (int i = 1; i < lignes.Length; i++)
            {
                attributs = lignes[i].Split(";");
                if (Convert.ToInt32(attributs[0])>=prochainNumeroDeCommande)
                    prochainNumeroDeCommande = Convert.ToInt32(attributs[0])+1;
                date = attributs[8].Split("/");
                DateTime Date = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
                Commande c = new Commande(Convert.ToInt32(attributs[0]), clients.TrouverClient(attributs[1]), attributs[2], attributs[3], Convert.ToDouble(attributs[4]), Convert.ToDouble(attributs[5]), vehicules.TrouverVehicule(attributs[6]), salaries.TrouverSalarie(attributs[7]),Date);
                this.commandes.Add(c);
            }
        }
        
        public void AjouterCommande(Commande c)
        {
            if (!(this.CommandeExiste(c)))
            {
                commandes.Add(c);
                prochainNumeroDeCommande++;
                StreamWriter writer = new StreamWriter("Commandes.csv", true);


                //Affectation des valeurs
                writer.Write(c.NumeroCommande + ";");
                writer.Write(c.Client.Nss + ";");
                writer.Write(c.PointA + ";");
                writer.Write(c.PointB + ";");
                writer.Write(c.DistanceParcourue + ";");
                writer.Write(c.Prix + ";");
                writer.Write(c.VehiculeUtilise.PlaqueImmatriculation + ";");
                writer.Write(c.Chauffeur.Nss + ";");

                //Creation de la Date au format jj/mm/aaaa
                string date = (c.Date.Day < 10) ? ("0" + c.Date.Day + "/") : (c.Date.Day + "/");
                date += (c.Date.Month < 10) ? ("0" + c.Date.Month + "/") : (c.Date.Month + "/");
                date += c.Date.Year;

                writer.Write(date + "\n");
                writer.Close();
            }
        }

        private void AjouterCommandebis(Commande c)
        {
            StreamWriter writer = new StreamWriter("Commandes.csv", true);


            //Affectation des valeurs
            writer.Write(c.NumeroCommande + ";");
            writer.Write(c.Client.Nss + ";");
            writer.Write(c.PointA + ";");
            writer.Write(c.PointB + ";");
            writer.Write(c.DistanceParcourue + ";");
            writer.Write(c.Prix + ";");
            writer.Write(c.VehiculeUtilise.PlaqueImmatriculation + ";");
            writer.Write(c.Chauffeur.Nss + ";");

            //Creation de la Date au format jj/mm/aaaa
            string date = (c.Date.Day < 10) ? ("0" + c.Date.Day + "/") : (c.Date.Day + "/");
            date += (c.Date.Month < 10) ? ("0" + c.Date.Month + "/") : (c.Date.Month + "/");
            date += c.Date.Year;

            writer.Write(date + "\n");
            writer.Close();
            
        }


        public bool CommandeExiste(Commande c)
        {
            bool flag = false;
            for (int i = 0; i<commandes.Count && !flag; i++)
                if (commandes[i].NumeroCommande == c.NumeroCommande)
                    flag = true;
            return flag;
        }

        public void NouvelleCommande(Personne client, string pointA, string pointB, double distanceParcourue, double prix, Vehicule vehiculeUtilise, Salarie chauffeur, DateTime date,Clients clients)
        {
            Commande commande = new Commande(prochainNumeroDeCommande, client, pointA, pointB, distanceParcourue, prix, vehiculeUtilise, chauffeur, date);
            NouvelleCommande(commande,clients);
        }

        public bool NouvelleCommande(Commande commande,Clients clients)
        {
            DialogResult dialogResult = MessageBox.Show($"Voulez vous valider la commande au prix de {commande.Prix} € ?", "Nouvelle Commande", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("La commande a été créée");
                clients.AjouterCommande(clients.TrouverClient(commande.Client.Nss),commande);
                commande.Chauffeur.AjouterCommande(commande);
                commande.VehiculeUtilise.AjoutDate(commande.Date);
                AjouterCommande(commande);
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }
            return false;
        }

        public Commande TrouverCommande(string numeroCommande)
        {
            Commande commandeRetourne = null;
            if (commandes != null)
                for (int i = 0; i < commandes.Count && commandeRetourne == null; i++)
                { if (commandes[i].NumeroCommande == Convert.ToInt32(numeroCommande)) commandeRetourne = commandes[i]; }
            return commandeRetourne;
        }

        public void ActualiserFichier()
        {
            StreamWriter writer = new StreamWriter("Commandes.csv");
            writer.Write("Numéro de commande;Nss du Client;Point de départ;Point d'arrivée;Distance parcourue;Prix;Plaque du véhicule utilisé;Nss du chauffeur;Date\n");
            writer.Close();
            foreach (Commande commande in commandes)
                AjouterCommandebis(commande);
        }

        public void AnnulerCommande(Commande commande,Clients clients)
        {
            clients.AnnulerCommande(clients.TrouverClient(commande.Client.Nss), commande);
            commande.Chauffeur.AnnulerCommande(commande);
            commande.VehiculeUtilise.SuppressionDate(commande.Date);
            commandes.Remove(commande);
            ActualiserFichier();
        }
        
    }
}
