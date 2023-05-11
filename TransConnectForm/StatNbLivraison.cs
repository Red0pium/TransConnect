using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class StatNbLivraison
    {
        private string prenom;
        private string nom;
        private int nombreDeLivraison;
        public string Prenom
        { get { return prenom; } }

        public string Nom
        { get { return nom; } }

        public int NombreDeLivraison
        { get { return nombreDeLivraison; } }

        public StatNbLivraison(Salarie salarie)
        {
            prenom= salarie.Prenom;
            nom= salarie.Nom;
            nombreDeLivraison = (File.ReadAllLines($"DatesChauffeurs\\{salarie.Nss}.csv"))[0].Length-1;
        }
    }
}
