using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Arbre
    {
        private NoeudArbre racine;

        public Arbre(NoeudArbre racine = null) { this.racine = racine; }

        public NoeudArbre Racine
        { get { return racine; } }

        /// <summary>
        /// insère le frére "nouveau" au noeud "aine"
        /// </summary>
        /// <param name="aine"></param>
        /// <param name="nouveau"></param>
        /// <returns></returns>
        public bool insererFrere(NoeudArbre aine, NoeudArbre nouveau)
        {
            if (aine == null) return false;
            if (aine.Frere == null)
            {
                aine.Frere = nouveau;
                return true;
            }
            return insererFrere(aine.Frere, nouveau);
        }


        /// <summary>
        /// retourne le noeud contenant le salarié "s" dans l'arbre ayant pour racine "noeudActuel"
        /// </summary>
        /// <param name="noeudActuel"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public NoeudArbre RechercherNoeudArbre(NoeudArbre noeudActuel, Salarie s)
        {
            if (noeudActuel == null)
            {
                return null;
            }
            else if (noeudActuel.Valeur == s)
            {
                return noeudActuel;
            }
            else
            {
                NoeudArbre noeudTrouve = RechercherNoeudArbre(noeudActuel.Fils, s);
                if (noeudTrouve != null)
                {
                    return noeudTrouve;
                }

                noeudTrouve = RechercherNoeudArbre(noeudActuel.Frere, s);
                if (noeudTrouve != null)
                {
                    return noeudTrouve;
                }

                return null;
            }
        }

        /// <summary>
        /// Insère un salarié (nouveau) en desous de son supérieur (superieur) dans l'arbre ayant pour racine "racine"
        /// </summary>
        /// <param name="racine"></param>
        /// <param name="superieur"></param>
        /// <param name="nouveau"></param>
        /// <returns></returns>
        public NoeudArbre insererSalarie(NoeudArbre racine, Salarie superieur, Salarie nouveau) 
        {
            if (racine == null)
            {
                return null;
            }
            else if (racine.Valeur == superieur)
            {
                if (racine.Fils == null)
                    racine.Fils = new NoeudArbre(nouveau);
                else
                    insererFrere(racine.Fils,new NoeudArbre(nouveau));
                return racine;
            }
            else
            {
                NoeudArbre noeudTrouve = insererSalarie(racine.Fils, superieur,nouveau);
                if (noeudTrouve != null)
                {
                    return noeudTrouve;
                }

                noeudTrouve = insererSalarie(racine.Frere, superieur,nouveau);
                if (noeudTrouve != null)
                {
                    return noeudTrouve;
                }

                return null;
            }
        }

    }
}
