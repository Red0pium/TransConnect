using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class CamionBenne : PoidLourd
    {
        private int nombreDeBenne; //1,2 ou 3
        private bool grue;

        public int NombreDeBenne
        { get { return nombreDeBenne; } set { this.nombreDeBenne = value; } }

        public bool Grue
        { get { return grue; } set { this.grue = value; } }

        public CamionBenne(string plaqueImmatriculation, bool enService = false, int nombreDeBenne = 1, bool grue = false) : base(plaqueImmatriculation,0,enService,"Camion benne")
        {
            this.plaqueImmatriculation= plaqueImmatriculation;
            this.nombreDeBenne = nombreDeBenne;
            this.grue = grue;
            this.volume = nombreDeBenne * 30;
        }

        //Prix par rapport au nombre de benne + supplément grue + prix de la journée (prix à la journée)
        public override double Prix(string PointA, string PointB, CheminRoutier Route)
        {
            double supplementGrue = 0;
            if (grue)
            {
                supplementGrue = 300;
            }
            return 5000 + supplementGrue + 3000 * nombreDeBenne;
        }

        public override void EcritureFichier()
        {
            StreamWriter writer = new StreamWriter($"Vehicules\\{PlaqueImmatriculation}.csv");
            writer.Write(plaqueImmatriculation + ";");
            writer.Write(Convert.ToString(enService) + ";");
            writer.Write(Convert.ToString(nombreDeBenne) + ";");
            writer.Write(Convert.ToString(grue)+"\n");
            writer.Close();
        }
    }
}
