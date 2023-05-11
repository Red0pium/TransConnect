using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class StatMoyennePrixCommande
    {
        private int nombreDeCommande;
        private double sommeDesCommandesCumulees;
        private double moyenneDesPrix;

        public int NombreDeCommande
        { get { return nombreDeCommande; } }

        public double SommeDesCommandesCumulees
        { get { return sommeDesCommandesCumulees; } }

        public double MoyenneDesPrix
        { get { return moyenneDesPrix;} }

        public StatMoyennePrixCommande(Commandes commandes) 
        {
            sommeDesCommandesCumulees = 0;
            nombreDeCommande = 0;
            foreach(Commande commande in commandes.ListeCommandes)
            {
                sommeDesCommandesCumulees += commande.Prix;
                nombreDeCommande++;
            }
            moyenneDesPrix = sommeDesCommandesCumulees / nombreDeCommande;
        }
    }
}
