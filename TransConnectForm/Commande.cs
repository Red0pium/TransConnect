using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Commande
    {
        private int numeroCommande;
        private Personne client;
        private string pointA;
        private string pointB;
        private double distanceParcourue;
        private double prix;
        private Vehicule vehiculeUtilise; //Sert à définir le type de livraison
        private Salarie chauffeur;
        private DateTime date;
        //Le centre de livraison se trouve à Paris
        //Les liquides (camion citerne) se trouvent à plusieurs endroit differents...
        //Les fournisseurs de nourriture sont a differents endroits de la france
        //Les trajets de personnes peuvent débuter n'importe où et finir n'importe où, cependant !!!+ le point de départ est loin de Paris, +la course est chère (sans compter le coût du trajet)!!!
        //Le prix est basé sur la distance, les coût/km varie selon le type de véhicule

        public Commande(int numeroCommande, Personne client,string pointA,string pointB,double distanceParcourue, double prix, Vehicule vehiculeUtilise,Salarie chauffeur, DateTime date)
        {
            this.numeroCommande = numeroCommande;
            this.client = client;
            this.pointA = pointA;
            this.pointB = pointB;
            this.distanceParcourue = distanceParcourue;
            this.prix = prix;
            this.vehiculeUtilise= vehiculeUtilise;
            this.chauffeur= chauffeur;
            this.date= date;
        }

        public int NumeroCommande
        { get { return numeroCommande; } }

        public Personne Client
        { get { return client; } }

        public string PointA
        { get { return pointA; } }

        public string PointB
        { get { return pointB; } }

        public double DistanceParcourue
        { get { return distanceParcourue; } }

        public double Prix
        { get { return prix; } }

        public Vehicule VehiculeUtilise
        { get { return vehiculeUtilise; } }

        public Salarie Chauffeur 
        { get { return chauffeur; } }

        public DateTime Date
        { get { return date; } }
    }

}