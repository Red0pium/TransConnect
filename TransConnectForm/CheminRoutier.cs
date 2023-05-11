using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class CheminRoutier
    {
        private Graphe grapheDistance;
        private Graphe grapheTemps;

        public Graphe GrapheDistance
        { get { return grapheDistance; } }

        public Graphe GrapheTemps
        { get { return grapheTemps; } }
        public CheminRoutier(Graphe grapheDistance=null, Graphe grapheTemps=null)
        {
            this.grapheDistance = grapheDistance;
            this.grapheTemps = grapheTemps;
        }

        public void LectureGraphe()
        {
            string[] lignes = File.ReadAllLines("Distances.csv");
            string[] ligne = new string[4];
            List<Noeud> noeuds= new List<Noeud>();
            List<Liaison> liaisonsDistance = new List<Liaison>();
            List<Liaison> liaisonsTemps = new List<Liaison>();
            for (int i =0;i<lignes.Length;i++)
            {
                ligne = lignes[i].Split(';');
                Noeud noeud1 = new Noeud(ligne[0]);
                Noeud noeud2 = new Noeud(ligne[1]);
                Liaison liaisonDistance = new Liaison(noeud1, noeud2, Convert.ToDouble(ligne[2])); //Ajout de la liaison 1 -> 2
                Liaison liaisonDistance2 = new Liaison(noeud2, noeud1, Convert.ToDouble(ligne[2])); //Ajout de la liason 2 -> 1
                Liaison liaisonTemps = new Liaison(noeud1, noeud2, Convert.ToDouble(ligne[3]));
                Liaison liaisonTemps2 = new Liaison(noeud2, noeud1, Convert.ToDouble(ligne[3]));
                if (!noeuds.Contains(noeud1))
                    noeuds.Add(noeud1);
                if (!noeuds.Contains(noeud2))
                    noeuds.Add(noeud2);
                liaisonsDistance.Add(liaisonDistance);
                liaisonsDistance.Add(liaisonDistance2);
                liaisonsTemps.Add(liaisonTemps);
                liaisonsTemps.Add(liaisonTemps2);
            }
            noeuds.Sort();
            grapheDistance=new Graphe(noeuds,liaisonsDistance);
            grapheTemps=new Graphe(noeuds,liaisonsTemps);
        }

        public double distance(string PointA,string PointB)
        {
            double distance = 0;
            if (PointA!=PointB)
                distance = grapheDistance.ValeurChemin(grapheDistance.dijkstraChemin(grapheDistance.RechercheNoeud(PointA),grapheDistance.RechercheNoeud(PointB)));
            return distance;
        }

        public double temps(string PointA, string PointB)
        {
            return grapheTemps.ValeurChemin(grapheTemps.dijkstraChemin(grapheTemps.RechercheNoeud(PointA), grapheTemps.RechercheNoeud(PointB)));
        }
    }
}
