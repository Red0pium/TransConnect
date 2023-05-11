using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Camionnette : Vehicule
    {
        private string usage;

        public string Usage
        { get { return this.usage; } set { this.usage = value; } }

        public Camionnette(string plaqueImmatriculation, string usage=null,bool enService=false):base("Camionnette",enService,plaqueImmatriculation)
        {
            this.plaqueImmatriculation = plaqueImmatriculation;
            this.usage = usage;
            this.enService = false;
        }

        public override double Prix(string PointA,string PointB, CheminRoutier Route) //Prix à la journée pour la Camionnette et le chauffeur
        {
            return 7000;
        }

        public override void EcritureFichier()
        {
            StreamWriter writer = new StreamWriter($"Vehicules\\{PlaqueImmatriculation}.csv");
            writer.Write(plaqueImmatriculation + ";");
            writer.Write(usage + ";");
            writer.Write(Convert.ToString(enService) + "\n");
            writer.Close();
        }
    }
}
