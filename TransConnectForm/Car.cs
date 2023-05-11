using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Car : Vehicule
    {
        private int nombrePassager;

        public int NombrePassager
        { get { return nombrePassager; } }

        public Car(string plaqueImmatriculation,int nombrePassager,bool enService=false) : base("Car",enService,plaqueImmatriculation)
        {
            this.nombrePassager = nombrePassager;
        }

        //Prix par rapport à la taille du car et la distance parcourue (+prix de la journée)
        public override double Prix(string PointA, string PointB, CheminRoutier Route)
        {
            double distanceAller = Route.distance("Paris", PointA) + Route.distance(PointA, PointB);
            double distanceRetour = Route.distance(PointB, "Paris");
            return 500 + distanceAller * 0.2 * nombrePassager + distanceRetour * 3;
        }

        public override void EcritureFichier()
        {
            StreamWriter writer = new StreamWriter($"Vehicules\\{PlaqueImmatriculation}.csv");
            writer.Write(plaqueImmatriculation + ";");
            writer.Write(Convert.ToString(nombrePassager) + ";");
            writer.Write(Convert.ToString(enService) + "\n");
            writer.Close();
        }
    }
}
