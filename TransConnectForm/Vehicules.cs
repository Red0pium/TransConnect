using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransConnectForm
{
    internal class Vehicules
    {
        private List<Vehicule> vehicules;

        public List<Vehicule> ListeVehicules
        { get { return vehicules; } }

        public Vehicules(List<Vehicule> vehicules=null)
        {
            this.vehicules = vehicules;
        }

        //Méthode utilisée pour créer le fichier dans le bon répertoire, mise en commentaire car peut écraser le fichier
        /*
        public static void CreerFichier()
        {
            StreamWriter writer = new StreamWriter("Vehicules.csv");
            writer.Write("Type de vehicule;En service;Plaque d'immatriculation\n");
            writer.Close();
        }
        */

        public void LectureFichierVehicule()
        {
            this.vehicules = new List<Vehicule>();
            string[] lignes = File.ReadAllLines("Vehicules.csv");
            string[] attributs = new string[3];
            for (int i = 1; i < lignes.Length; i++)
            {
                attributs = lignes[i].Split(";");
                if (attributs[0].Contains("benne"))
                {
                    string[] attributs2 = File.ReadAllLines($"Vehicules\\{attributs[2]}.csv")[0].Split(";");
                    Vehicule vehicule = new CamionBenne(attributs[2], Convert.ToBoolean(attributs2[1]), Convert.ToInt16(attributs2[2]), Convert.ToBoolean(attributs2[3]));
                    vehicule.LectureDates();
                    vehicules.Add(vehicule);
                }
                else if (attributs[0].Contains("citerne"))
                {
                    string[] attributs2 = File.ReadAllLines($"Vehicules\\{attributs[2]}.csv")[0].Split(";");
                    Vehicule vehicule = new CamionCiterne(attributs[2], Convert.ToDouble(attributs2[1]), Convert.ToBoolean(attributs2[2]), attributs2[3]) ;
                    vehicule.LectureDates();
                    vehicules.Add(vehicule);
                }
                else if (attributs[0].Contains("frigorifique"))
                {
                    string[] attributs2 = File.ReadAllLines($"Vehicules\\{attributs[2]}.csv")[0].Split(";");
                    Vehicule vehicule = new CamionFrigorifique(attributs[2], Convert.ToBoolean(attributs2[1]), Convert.ToInt16(attributs2[2]));
                    vehicule.LectureDates();
                    vehicules.Add(vehicule);
                }
                else if (attributs[0]=="Camionnette")
                {
                    string[] attributs2 = File.ReadAllLines($"Vehicules\\{attributs[2]}.csv")[0].Split(";");
                    Vehicule vehicule = new Camionnette(attributs[2], attributs2[1], Convert.ToBoolean(attributs2[2]));
                    vehicule.LectureDates();
                    vehicules.Add(vehicule);
                }
                else if (attributs[0]=="Car")
                {
                    string[] attributs2 = File.ReadAllLines($"Vehicules\\{attributs[2]}.csv")[0].Split(";");
                    Vehicule vehicule = new Car(attributs[2], Convert.ToInt16(attributs2[1]), Convert.ToBoolean(attributs2[2]));
                    vehicule.LectureDates();
                    vehicules.Add(vehicule);
                }
            }
        }

        public void AjouterVehicule(Vehicule v)
        {
            if (!(this.VehiculeExiste(v)))
            {
                vehicules.Add(v);
                StreamWriter writer = new StreamWriter("Vehicules.csv", true);


                //Affectation des valeurs
                writer.Write(v.TypeVehicule + ";");
                writer.Write(v.EnService + ";");
                writer.Write(v.PlaqueImmatriculation + "\n");

                writer.Close();
                StreamWriter writer2 = new StreamWriter($"Vehicules\\{v.PlaqueImmatriculation}_Date.csv");
                writer2.WriteLine("01/01/2000");
                writer2.Close();
                v.EcritureFichier();
            }
        }

        private void AjouterVehiculebis(Vehicule v)
        {
            StreamWriter writer = new StreamWriter("Vehicules.csv", true);


            //Affectation des valeurs
            writer.Write(v.TypeVehicule + ";");
            writer.Write(v.EnService + ";");
            writer.Write(v.PlaqueImmatriculation + "\n");

            writer.Close();
        }

        public bool VehiculeExiste(Vehicule v)
        {
            bool flag = false;
            for(int i = 0; i < vehicules.Count && !flag; i++)
            {
                if (v.PlaqueImmatriculation == vehicules[i].PlaqueImmatriculation)
                    flag = true;
            }
            return flag;
        }

        public void ActualiserFichier()
        {
            StreamWriter writer = new StreamWriter("Vehicules.csv");
            writer.Write("Type de vehicule;En service;Plaque d'immatriculation\n");
            writer.Close();
            foreach (Vehicule vehicule in vehicules)
                AjouterVehiculebis(vehicule);
        }

        public void SupprimerVehicule(Vehicule vehicule)
        {
            bool supprimer = true;
            for (int i =0; i < vehicule.ListeDatesOccupees.Count&&supprimer;i++)
                if (vehicule.ListeDatesOccupees[i]>=DateTime.Today)
                {
                    supprimer = false;
                    MessageBox.Show("Le vehicule est impliqué dans des commandes à venir, veuillez les annuler si vous voulez supprimer le vehicule");
                }
            if (supprimer)
            {
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir supprimer le vehicule ayant pour plaque d'immatriculation {vehicule.PlaqueImmatriculation} de la liste des vehicules ?", "Suppression vehicule", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    vehicules.Remove(vehicule);
                    ActualiserFichier();
                    MessageBox.Show($"Le vehicule a été supprimé de la liste des vehicules");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //this.Close();
                }
            }
        }


        public Vehicule TrouverVehicule(string plaqueImmatriculation)
        {
            Vehicule vehiculeRetourne = null;
            for (int i =0;i<vehicules.Count && vehiculeRetourne==null;i++)
            {
                if (vehicules[i].PlaqueImmatriculation==plaqueImmatriculation)
                    vehiculeRetourne = vehicules[i];
            }
            return vehiculeRetourne;
        }

    }
}
