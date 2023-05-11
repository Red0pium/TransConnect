using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal abstract class EmploiDuTemps
    {
        public static List<DateTime> LectureDates(Salarie salarie)
        {
            DateTime date = new DateTime();
            List<DateTime> liste = new List<DateTime>();
            string[] lignes = File.ReadAllLines($"DatesChauffeurs\\{salarie.Nss}.csv");
            string[] dates = lignes[1].Split(";");
            string[] dateAjout = new string[3];
            for (int i = 1; i<dates.Length;i++) 
            {
                dateAjout = dates[i].Split("/");
                date = new DateTime(Convert.ToInt16(dateAjout[2]), Convert.ToInt16(dateAjout[1]), Convert.ToInt16(dateAjout[0]));
                liste.Add(date);
            }
            return liste;
        }

        public static List<string> LectureCommandes(Salarie salarie)
        {
            List<string> liste = new List<string>();
            string[] lignes = File.ReadAllLines($"DatesChauffeurs\\{salarie.Nss}.csv");
            string[] commandes = lignes[0].Split(";");
            for (int i = 1; i<commandes.Length;i++)
            {
                liste.Add(commandes[i]);
            }
            return liste;
        }

        public static void AjouterCommande(Salarie salarie, Commande commande)
        {
            //Mise de la date au format jj/mm/aaaa
            string date2 = (commande.Date.Day < 10) ? ("0" + commande.Date.Day + "/") : (commande.Date.Day + "/");
            date2 += (commande.Date.Month < 10) ? ("0" + commande.Date.Month + "/") : (commande.Date.Month + "/");
            date2 += commande.Date.Year;

            string[] lignes = File.ReadAllLines($"DatesChauffeurs\\{salarie.Nss}.csv");
            if (!lignes[1].Contains(date2))
            {
                StreamWriter writer = new StreamWriter($"DatesChauffeurs\\{salarie.Nss}.csv");
                writer.Write(lignes[0] + ";" + commande.NumeroCommande + "\n");
                writer.Write(lignes[1] + ";" + date2 + "\n");
                writer.Close();

                salarie.ListeDatesOccupees.Add(commande.Date);
            }
        }

        public static void AnnulerCommande(Salarie salarie,Commande commande)
        {
            string date2 = (commande.Date.Day < 10) ? ("0" + commande.Date.Day + "/") : (commande.Date.Day + "/");
            date2 += (commande.Date.Month < 10) ? ("0" + commande.Date.Month + "/") : (commande.Date.Month + "/");
            date2 += commande.Date.Year;
            string[] lignes = File.ReadAllLines($"DatesChauffeurs\\{salarie.Nss}.csv");
            string[] commandes = lignes[0].Split(";");
            string[] dates = lignes[1].Split(";");
            if (dates.Contains(date2))
            {
                salarie.ListeDatesOccupees.Remove(commande.Date);

                string lignecommande = "";
                foreach (string c in commandes)
                {
                    if (c != Convert.ToString(commande.NumeroCommande))
                        lignecommande += c + ";";
                }
                lignecommande = lignecommande.Remove(lignecommande.Length - 1);
                lignecommande += "\n";

                string lignedate = "";
                foreach (string date in dates)
                {
                    if (date != date2)
                        lignedate+= date + ";";
                }
                lignedate = lignedate.Remove(lignedate.Length - 1);
                lignedate += "\n";
                StreamWriter writer = new StreamWriter($"DatesChauffeurs\\{salarie.Nss}.csv");
                
                writer.Write(lignecommande);
                writer.Write(lignedate);
                writer.Close();
            }
        }
    }
}

