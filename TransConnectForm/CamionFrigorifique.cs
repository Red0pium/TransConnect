using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class CamionFrigorifique : PoidLourd
    {
        private int nombreDeGroupeElectrogene;

        public int NombreDeGroupeElectrogene
        { get { return nombreDeGroupeElectrogene; } set { nombreDeGroupeElectrogene = value; } }

        public CamionFrigorifique(string plaqueImmatriculation,bool enService=false, int nombreDeGroupeElectrogene=1) : base(plaqueImmatriculation,30,enService,"Camion frigorifique")
        {
            this.nombreDeGroupeElectrogene=nombreDeGroupeElectrogene;
        }

        //Prix par rapport au nombre de groupe Electrogene nécessaires
        public override double Prix(string PointA, string PointB, CheminRoutier Route)
        {
            double distancePointA = Route.distance("Paris", PointA);
            double distanceTrajet = Route.distance(PointA, PointB);
            double tempsTrajet = Route.temps(PointA, PointB);
            int nbElectrogene = 0;
            double distanceRetour = Route.distance(PointB, "Paris");
            if (tempsTrajet < 3 * 60)
                nbElectrogene = 1;
            else if(tempsTrajet > 3 * 60 && tempsTrajet<6*60)
                nbElectrogene = 2;
            else
                nbElectrogene = 3;

            return 500 + 1000*nbElectrogene + distanceTrajet * 7 + (distanceRetour+distancePointA) * 3;
        }

        public override void EcritureFichier()
        {
            StreamWriter writer = new StreamWriter($"Vehicules\\{PlaqueImmatriculation}.csv");
            writer.Write(plaqueImmatriculation + ";");
            writer.Write(Convert.ToString(enService) + ";");
            writer.Write(Convert.ToString(nombreDeGroupeElectrogene) + "\n");
            writer.Close();
        }
    }
}
