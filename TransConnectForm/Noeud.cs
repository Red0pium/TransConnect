using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Noeud:IEquatable<Noeud>,IComparable<Noeud>
    {
        private string valeur;

        public string Valeur { get { return valeur; } }

        public Noeud(string valeur = null)
        {
            this.valeur = valeur;
        }

        public bool Equal(Noeud noeud)
        { return noeud.Valeur == this.Valeur; }


        public int CompareTo(Noeud? other)
        {
            return this.Valeur.CompareTo(other.Valeur);
        }

        public bool Equals(Noeud? other)
        {
            return this.Valeur==other.Valeur;
        }
    }
}
