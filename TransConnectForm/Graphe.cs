using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Graphe
    {
        private List<Noeud> noeuds;
        private List<Liaison> liaisons;

        public List<Noeud> Noeuds
        { get { return noeuds; } }

        public List<Liaison> Liaisons
        { get { return liaisons; } }

        public Graphe(List<Noeud> noeuds = null, List<Liaison> liaisons = null)
        {
            this.noeuds = noeuds;
            this.liaisons = liaisons;
        }

        public void ajouterLiaison(Liaison liaison)
        {
            liaisons.Add(liaison);
        }

        /// <summary>
        /// Retourne le chemin le plus court entre "depart" et "arrive"
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="arrive"></param>
        /// <returns></returns>
        public List<Noeud> dijkstraChemin(Noeud depart, Noeud arrive)
        {
            int k = 0;
            double distance = 0; //distance la plus courte pour arriver au noeud sur lequel on se trouve
            double[] distances = null; //tableau des poids des chemins les plus court pour chaque noeud
            Noeud[] provenance = null; //tableau des provenance du chemin le plus court pour chaque noeud
            bool[] aEteSource = null; //Tableau pour verifier si un noeud a déjà été source (permet d'éviter de reprendre un noeud qui à déjà été pris comme source)
            List<Noeud> chemin = new List<Noeud>();
            if (this.Noeuds != null)
            {
                distances = new double[this.Noeuds.Count];
                provenance = new Noeud[this.Noeuds.Count];
                aEteSource = new bool[this.Noeuds.Count];
                for (int i = 0; i < distances.Length; i++)
                {
                    distances[i] = double.MaxValue; //initialisation de toutes les distances à la plus grande valeur possible (une sorte d'infini en code)
                    aEteSource[i] = false; //aucun noeud n'a encore été source
                }
                //partir de start
                foreach (Liaison liaison in this.Liaisons) //recherche de toute les liaisons ayant "start" pour départ
                {
                    if (liaison.Depart.Valeur == depart.Valeur)
                    {
                        k = this.Noeuds.FindIndex(x => x.Equal(liaison.Arrivee));
                        provenance[k] = depart;
                        distances[k] = liaison.Poids;
                    }
                }
                k = this.Noeuds.FindIndex(x => x.Equal(depart));
                aEteSource[k] = true; //start à été source
                Noeud source = depart;
                double val = double.MaxValue;
                while (source != arrive)
                {
                    val = double.MaxValue;
                    for (int i = 0; i < distances.Length; i++)//Prend le noeud avec la plus petite distance qui n'a jamais été source
                    {
                        if (!aEteSource[i] && distances[i] < val)
                        {
                            k = i;
                            val = distances[i];
                        }
                    }
                    source = this.Noeuds[k];//met le noeud en tant que source
                    distance = distances[k];//prend la distance en question
                    aEteSource[k] = true;//l'ajoute dans la liste des noeud ayant été source
                    foreach (Liaison liaison in this.Liaisons)//cherche toutes les liaisons ayant eu pour départ la source
                    {
                        if (liaison.Depart.Valeur == source.Valeur)
                        {
                            k = this.Noeuds.FindIndex(x => x.Equal(liaison.Arrivee));

                            //met à jour les distances et provenance des distances à chaque noeud si nécessaire
                            if (distances[k] == double.MaxValue )//&& provenance[k] != liaison.Arrivee )
                            {
                                provenance[k] = source;
                                distances[k] = distance + liaison.Poids;
                            }
                            else
                            {
                                if (distances[k] > distance + liaison.Poids)// && provenance[k] != liaison.Arrivee)
                                {
                                    provenance[k] = source;
                                    distances[k] = distance + liaison.Poids;
                                }
                            }
                        }
                    }
                }

                //Remontée de dikjstra
                k = this.Noeuds.FindIndex(x => x.Equal(arrive));
                chemin.Add(arrive);
                while (provenance[k] != depart)
                {
                    chemin.Add(provenance[k]);
                    k = this.Noeuds.FindIndex(x => x.Equal(provenance[k]));
                }
                chemin.Add(depart);
                chemin.Reverse();
            }
            return chemin;

        }

        /// <summary>
        /// retourne le poids total du chemin mis en entrée
        /// </summary>
        /// <param name="chemin"></param>
        /// <returns></returns>
        public double ValeurChemin(List<Noeud> chemin)
        {
            bool trouve = false; //bool pour terminer la boucle dès que la liaison est trouvée afin de ne pas parcourir le reste de la liste des liaisons inutilement
            bool cheminExiste = false;
            double valeur = 0;
            if (chemin != null && chemin.Count>1)
            {
                cheminExiste = true;
                for (int i=0;i<chemin.Count-1;i++)
                {
                    trouve = false;
                    for (int j = 0 ; j<liaisons.Count && !trouve ; j++)
                    { 
                        if (liaisons[j].Depart.Valeur == chemin[i].Valeur && liaisons[j].Arrivee.Valeur == chemin[i + 1].Valeur)//Si la liaison correspond à la liaison[i]
                        {
                            valeur += liaisons[j].Poids;//Ajout du poid de la liaison
                            trouve = true;
                        }
                    }
                    if (!trouve)
                        cheminExiste = false;
                    trouve = false;
                }
            }
            if (!cheminExiste)
            {
                valeur = -1;
            }
            return valeur;
        }

        public Noeud RechercheNoeud(string valeur)
        {
            Noeud noeud = null;
            for(int i =0; i<noeuds.Count && noeud == null;i++)
            {
                if (noeuds[i].Valeur==valeur)
                {
                    noeud= noeuds[i];
                }
            }
            return noeud;

        }
    }
}
