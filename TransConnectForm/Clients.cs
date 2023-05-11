using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Clients
    {
        private List<Client> clients;

        public List<Client> ListeClients
        { get { return clients; } }
        public Clients(List<Client> clients=null)
        {
            this.clients = clients;
        }

        //Méthode utilisée pour créer le fichier dans le bon répertoire, mise en commentaire car peut écraser le fichier
        /*
        public static void CreerFichier()
        {
            StreamWriter writer = new StreamWriter("Clients.csv");
            writer.Write("Num SS;Nom;Prénom;Date de naissance;Adresse postale;Adresse mail;Numéro de téléphone;Montant total d'achat\n");
            writer.Close();
        }
        */

        /// <summary>
        /// Initialise la liste des clients en prenant les informations du fichier Clients.csv
        /// </summary>
        public void LectureFichierClient()
        {
            this.clients = new List<Client>();
            string[] lignes = File.ReadAllLines("Clients.csv");
            string[] attributs = new string[8];
            string[] date = new string[3];
            for (int i = 1; i < lignes.Length; i++)
            {
                attributs = lignes[i].Split(";");
                date = attributs[3].Split("/");
                DateTime DateDeNaissance = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
                Client c = new Client(attributs[0].Remove(15), attributs[1], attributs[2], DateDeNaissance, attributs[4], attributs[5], attributs[6].Remove(10), Convert.ToDouble(attributs[7]));
                this.clients.Add(c);
            }
        }


        /// <summary>
        /// Ajoute un client à la liste des clients
        /// </summary>
        /// <param name="c"></param>
        public void AjouterClient(Client c)
        {
            if(!(this.ClientExiste(c)))
            { 
                clients.Add(c);
                StreamWriter writer = new StreamWriter("Clients.csv", true);


                //Affectation des valeurs
                writer.Write(c.Nss + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double
                writer.Write(c.Nom + ";");
                writer.Write(c.Prenom + ";");

                //Creation de la Date de naissance au format jj/mm/aaaa
                string dateNaissance = (c.DateDeNaissance.Day < 10) ? ("0" + c.DateDeNaissance.Day + "/") : (c.DateDeNaissance.Day + "/");
                dateNaissance += (c.DateDeNaissance.Month < 10) ? ("0" + c.DateDeNaissance.Month + "/") : (c.DateDeNaissance.Month + "/");
                dateNaissance += c.DateDeNaissance.Year;

                writer.Write(dateNaissance + ";");
                writer.Write(c.Adresse + ";");
                writer.Write(c.Mail + ";");
                writer.Write(c.Numerotel + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double
                writer.Write(c.MontantAchat + "\n");

                writer.Close();
            }
        }


        /// <summary>
        /// Méthode auxiliaire à la méthode ActualiserFichier
        /// </summary>
        /// <param name="c"></param>
        private void AjouterClientbis(Client c)
        {
            StreamWriter writer = new StreamWriter("Clients.csv", true);


            //Affectation des valeurs
            writer.Write(c.Nss + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double
            writer.Write(c.Nom + ";");
            writer.Write(c.Prenom + ";");

            //Creation de la Date de naissance au format jj/mm/aaaa
            string dateNaissance = (c.DateDeNaissance.Day < 10) ? ("0" + c.DateDeNaissance.Day + "/") : (c.DateDeNaissance.Day + "/");
            dateNaissance += (c.DateDeNaissance.Month < 10) ? ("0" + c.DateDeNaissance.Month + "/") : (c.DateDeNaissance.Month + "/");
            dateNaissance += c.DateDeNaissance.Year;

            writer.Write(dateNaissance + ";");
            writer.Write(c.Adresse + ";");
            writer.Write(c.Mail + ";");
            writer.Write(c.Numerotel + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double
            writer.Write(c.MontantAchat + "\n");

            writer.Close();
        }

        /// <summary>
        /// Crée un nouveau client et l'ajoute à la liste des clients
        /// </summary>
        /// <param name="nss"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="adresse"></param>
        /// <param name="mail"></param>
        /// <param name="numerotel"></param>
        /// <param name="montantAchat"></param>
        public void NouveauClient(string nss, string nom, string prenom, DateTime dateDeNaissance, string adresse, string mail, string numerotel, double montantAchat = 0)
        {
            Client c = new Client(nss, nom.ToUpper(), prenom, dateDeNaissance, adresse, mail, numerotel, montantAchat);
            this.AjouterClient(c);
        }

        /// <summary>
        /// Actualise le fichier Clients.csv par rapport à la liste
        /// </summary>
        public void ActualiserFichier()
        {
            StreamWriter writer = new StreamWriter("Clients.csv");
            writer.Write("Num SS;Nom;Prénom;Date de naissance;Adresse postale;Adresse mail;Numéro de téléphone;Montant total d'achat\n");
            writer.Close();
            foreach (Client client in clients)
                AjouterClientbis(client);
        }

        /// <summary>
        /// supprime le client du fichier Clients.csv
        /// </summary>
        /// <param name="c"></param>
        public void SupprimerClient(Client c)
        {
            this.ListeClients.Remove(c);
            this.ActualiserFichier();
        }

        /// <summary>
        /// supprime les clients de la liste du fichier Clients.csv
        /// </summary>
        /// <param name="clients"></param>
        public void SupprimerClient(List<Client> clients)
        {
            foreach (Client client in clients)
                this.ListeClients.Remove(client);
            this.ActualiserFichier();
        }

        //Aussi faisable avec une interface mais j'aime que 2 objets soient égaux si les mêmes seulement
        public bool ClientExiste(Client c)
        {
            bool flag = false;
            foreach(Client c2 in clients)
                if (c2.Nss==c.Nss)
                    flag = true;
            return flag;
        }

        public Client TrouverClient(string nss)
        {
            Client clientRetourne = null;
            if (clients !=null)
                for (int i = 0; i<clients.Count && clientRetourne==null;i++) 
                { if (clients[i].Nss==nss) clientRetourne=clients[i]; }
            return clientRetourne;
        }

        public void AjouterCommande(Client client, Commande commande)
        {
            client.AjouterCommande(commande);
            ActualiserFichier();
        }

        public void AnnulerCommande(Client client,Commande commande)
        {
            client.AnnulerCommande(commande);
            ActualiserFichier() ;
        }
    }
}
