using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class NoeudArbre
    {
        private Salarie valeur;
        private NoeudArbre fils;
        private NoeudArbre frere;

        public Salarie Valeur
        { get { return valeur; } }

        public NoeudArbre Fils
        { get { return fils; } set { this.fils = value; } }

        public NoeudArbre Frere
        { get { return frere; } set { this.frere = value; } }

        public NoeudArbre(Salarie valeur=null, NoeudArbre fils=null, NoeudArbre frere=null)
        {
            this.valeur = valeur;
            this.fils = fils;
            this.frere = frere;
        }

        public override string ToString()
        {
            string prefixe = (Valeur.Nss[0] == '1') ? ("Mr") : ("Mme");
            return $"{prefixe}. {this.Valeur.Nom}\n/{this.Valeur.Poste}";
        }
    }
}
