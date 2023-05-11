using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TransConnectForm
{
    internal abstract class PoidLourd : Vehicule
    {
        protected double volume; //En dm^3 (Litres)
        protected string matiere; //Type de matiere transportée

        public PoidLourd(string plaqueImmatriculation, double volume, bool enService = false, string typeDeVehicule=null) : base(typeDeVehicule,enService,plaqueImmatriculation)
        {
            this.volume = volume;
        }

    }
}
