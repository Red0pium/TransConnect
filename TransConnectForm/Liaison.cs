using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Liaison
    {
        private Noeud depart;
        private Noeud arrivee;
        private double poids;

        public Noeud Depart { get { return depart; } }

        public Noeud Arrivee { get { return arrivee; } }

        public double Poids { get { return poids; } }

        public Liaison(Noeud depart, Noeud arrivee, double poids)
        {
            this.depart = depart;
            this.arrivee = arrivee;
            this.poids = poids;
        }
    }
}
