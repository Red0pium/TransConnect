using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Client : Personne, IComparable<Client>
    {
        private double montantAchat;

        public double MontantAchat
        { get { return montantAchat; } }

        /// <summary>
        /// Constructeur à ne pas utiliser, privilégier l'utilisation de la méthode Clients.NouveauClient()
        /// </summary>
        /// <param name="nss"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="adresse"></param>
        /// <param name="mail"></param>
        /// <param name="numerotel"></param>
        /// <param name="montantAchat"></param>
        public Client(string nss, string nom, string prenom, DateTime dateDeNaissance, string adresse, string mail, string numerotel, double montantAchat = 0) : base(nss, nom.ToUpper(), prenom, dateDeNaissance, adresse, mail, numerotel)
        {
            this.montantAchat = montantAchat;        
        }

        public int CompareTo(Client other)
        {
            return this.Nom.CompareTo(other.Nom);
        }

        
        public int TriParVille(Client other)
        {
            return this.Adresse.CompareTo(other.Adresse);
        }


        public int TriParAchat(Client other)
        {
            return Convert.ToInt32(Math.Round(other.MontantAchat-this.MontantAchat));
        }

        public void AjouterCommande(Commande commande)
        {
            montantAchat += commande.Prix;
        }

        public void AnnulerCommande(Commande commande)
        {
            montantAchat -= commande.Prix; 
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom}";
        }
    }
}
