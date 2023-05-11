using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class CamionCiterne : PoidLourd
    {
        private string typeDeCuve;

        public string TypeDeCuve
        { get { return typeDeCuve;} }

        public double Volume
        { get { return volume; } }

        public CamionCiterne(string plaqueImmatriculation, double volume,bool enService, string typeDeCuve) : base(plaqueImmatriculation,volume,enService,"Camion citerne")
        {
            if (typeDeCuve != null && (typeDeCuve == "liquide" || typeDeCuve == "gazeux"))
                this.typeDeCuve = typeDeCuve; //liquide ou gazeux

            else this.typeDeCuve = "liquide";
        }

        //Prix par rapport à la distance parcourue et au volume de fluide transporté (il est + cher de transporter du liquide que du gaz)
        public override double Prix(string PointA, string PointB, CheminRoutier Route)
        {
            double liquideOuGaz = 15;
            if (typeDeCuve == "gaz")
                liquideOuGaz = 12;
            double prixKm = liquideOuGaz * volume/100000;
            double distanceAller = Route.distance("Paris", PointA) + Route.distance(PointA, PointB);
            double distanceRetour = Route.distance(PointB, "Paris");
            return 1000 + distanceAller * prixKm + distanceRetour * 4;
        }

        public override void EcritureFichier()
        {
            StreamWriter writer = new StreamWriter($"Vehicules\\{PlaqueImmatriculation}.csv");
            writer.Write(plaqueImmatriculation + ";");
            writer.Write(Convert.ToString(volume) + ";");
            writer.Write(Convert.ToString(enService) + ";");
            writer.Write(typeDeCuve + "\n");
            writer.Close();
        }
    }
}
