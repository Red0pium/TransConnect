using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Salaries
    {
        private List<Salarie> salaries;
        private int nbChefEquipe;
        private List<Salarie> chauffeurs;

        public List<Salarie> ListeSalaries { get { return salaries; } }

        public int NbChefEquipe { get { return nbChefEquipe; } }

        public List<Salarie> ListeChauffeurs { get { return chauffeurs; } }

        public Salaries(List<Salarie> salaries = null) { this.salaries = salaries; }


        //Méthode utilisée pour créer le fichier dans le bon répertoire, mise en commentaire car peut écraser le fichier
        /*
        public static void CreerFichier()
        {
            StreamWriter writer = new StreamWriter("Salaries.csv");
            writer.Write("Num SS;Nom;Prénom;Date de naissance;Adresse postale;Adresse mail;Numéro de téléphone;Date d'entrée;Poste;Salaire;Poste du supérieur;Est directeur\n");
            writer.Close();
        }
        */


        #region fichier
        /// <summary>
        /// Initialise la liste des salariés en prenant les informations du fichier Salaries.csv
        /// </summary>
        public void LectureFichierSalaries()
        {
            nbChefEquipe = 0;
            this.salaries = new List<Salarie>();
            this.chauffeurs = new List<Salarie>();
            string[] lignes = File.ReadAllLines("Salaries.csv");
            string[] attributs = new string[12];
            string[] date = new string[3];
            string[] dateDentree = new string[3];
            for (int i = 1; i < lignes.Length; i++)
            {
                attributs = lignes[i].Split(";");
                if (attributs[8].Contains("Chef Equipe"))
                    this.nbChefEquipe++;
                date = attributs[3].Split("/");
                dateDentree = attributs[7].Split('/');
                DateTime DateDeNaissance = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
                DateTime DateDentree = new DateTime(Convert.ToInt32(dateDentree[2]), Convert.ToInt32(dateDentree[1]), Convert.ToInt32(dateDentree[0]));
                Salarie s = new Salarie(attributs[0].Remove(15), attributs[1], attributs[2], DateDeNaissance, attributs[4], attributs[5], attributs[6].Remove(10), DateDentree, attributs[8], Convert.ToDouble(attributs[9]), attributs[10], Convert.ToBoolean(attributs[11]));
                if (s.Poste=="Chauffeur")
                    s.ListeDatesOccupees = EmploiDuTemps.LectureDates(s);
                this.salaries.Add(s);
                if (s.Poste == "Chauffeur")
                    this.chauffeurs.Add(s);
            }
        }

        /// <summary>
        /// Ajoute un salarié à la liste des salariés
        /// </summary>
        /// <param name="c"></param>
        public void AjouterSalarie(Salarie s)
        {
            if (!(this.SalarieExiste(s)))
            {
                if (s.Poste == "Chauffeur")
                {
                    chauffeurs.Add(s);
                    StreamWriter writer2 = new StreamWriter($"DatesChauffeurs\\{s.Nss}.csv");
                    writer2.WriteLine(-1);
                    writer2.WriteLine("01/01/2000");
                    writer2.Close();
                }
                salaries.Add(s);
                StreamWriter writer = new StreamWriter("Salaries.csv", true);


                //Affectation des valeurs
                writer.Write(s.Nss + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double
                writer.Write(s.Nom + ";");
                writer.Write(s.Prenom + ";");

                //Creation de la Date de naissance au format jj/mm/aaaa
                string dateNaissance = (s.DateDeNaissance.Day < 10) ? ("0" + s.DateDeNaissance.Day + "/") : (s.DateDeNaissance.Day + "/");
                dateNaissance += (s.DateDeNaissance.Month < 10) ? ("0" + s.DateDeNaissance.Month + "/") : (s.DateDeNaissance.Month + "/");
                dateNaissance += s.DateDeNaissance.Year;

                writer.Write(dateNaissance + ";");
                writer.Write(s.Adresse + ";");
                writer.Write(s.Mail + ";");
                writer.Write(s.Numerotel + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double

                //Creation de la Date d'entrée au format jj/mm/aaaa 
                string dateDentree = (s.DateDentree.Day < 10) ? ("0" + s.DateDentree.Day + "/") : (s.DateDentree.Day + "/");
                dateDentree += (s.DateDentree.Month < 10) ? ("0" + s.DateDentree.Month + "/") : (s.DateDentree.Month + "/");
                dateDentree += s.DateDentree.Year;

                writer.Write(dateDentree + ";");
                writer.Write(s.Poste + ";");
                writer.Write(s.Salaire + ";");
                writer.Write(s.PosteSuperieur + ";");
                writer.Write(s.EstDirecteur + "\n");

                writer.Close();
            }
        }

        /// <summary>
        /// Méthode auxiliaire à la méthode ActualiserFichier
        /// </summary>
        /// <param name="c"></param>
        private void AjouterSalariebis(Salarie s)
        {

            StreamWriter writer = new StreamWriter("Salaries.csv", true);

            //Affectation des valeurs
            writer.Write(s.Nss + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double
            writer.Write(s.Nom + ";");
            writer.Write(s.Prenom + ";");

            //Creation de la Date de naissance au format jj/mm/aaaa
            string dateNaissance = (s.DateDeNaissance.Day < 10) ? ("0" + s.DateDeNaissance.Day + "/") : (s.DateDeNaissance.Day + "/");
            dateNaissance += (s.DateDeNaissance.Month < 10) ? ("0" + s.DateDeNaissance.Month + "/") : (s.DateDeNaissance.Month + "/");
            dateNaissance += s.DateDeNaissance.Year;

            writer.Write(dateNaissance + ";");
            writer.Write(s.Adresse + ";");
            writer.Write(s.Mail + ";");
            writer.Write(s.Numerotel + "/;"); //Ajout d'un / pour bien préciser qu'il s'agit d'une chaîne de caractère et non d'un entier ou d'un double

            //Creation de la Date d'entrée au format jj/mm/aaaa 
            string dateDentree = (s.DateDentree.Day < 10) ? ("0" + s.DateDentree.Day + "/") : (s.DateDentree.Day + "/");
            dateDentree += (s.DateDentree.Month < 10) ? ("0" + s.DateDentree.Month + "/") : (s.DateDentree.Month + "/");
            dateDentree += s.DateDentree.Year;

            writer.Write(dateDentree + ";");
            writer.Write(s.Poste + ";");
            writer.Write(s.Salaire + ";");
            writer.Write(s.PosteSuperieur + ";");
            writer.Write(s.EstDirecteur + "\n");

            writer.Close();
        }

        public void NouveauSalarie(string nss, string nom, string prenom, DateTime dateDeNaissance, string adresse, string mail, string numerotel, DateTime dateDentree, string poste, double salaire, string posteSuperieur, bool estDirecteur)
        {
            Salarie s = new Salarie(nss, nom.ToUpper(), prenom, dateDeNaissance, adresse, mail, numerotel, dateDentree, poste, salaire, posteSuperieur, estDirecteur);
            if (poste == "Chauffeur")
            {
                StreamWriter writer = new StreamWriter($"DatesChauffeurs\\{nss}");
                writer.Close();
            }
            this.AjouterSalarie(s);
        }

        /// <summary>
        /// Actualise le fichier Salaries.csv par rapport à la liste
        /// </summary>
        public void ActualiserFichier()
        {
            StreamWriter writer = new StreamWriter("Salaries.csv");
            writer.Write("Num SS;Nom;Prénom;Date de naissance;Adresse postale;Adresse mail;Numéro de téléphone;Date d'entrée;Poste;Salaire;Poste du supérieur;Est directeur\n");
            writer.Close();
            foreach (Salarie salarie in salaries)
                AjouterSalariebis(salarie);
        }

        /// <summary>
        /// supprime le salarié du fichier Salaries.csv
        /// </summary>
        /// <param name="c"></param>
        private void SupprimerSalarie(Salarie s)
        {
            if (s.Poste == "Chauffeur")
                this.ListeChauffeurs.Remove(s);
            this.ListeSalaries.Remove(s);
            this.ActualiserFichier();
        }
        #endregion



        //Aussi faisable avec une interface mais j'aime que 2 objets soient égaux si les mêmes seulement
        public bool SalarieExiste(Salarie s)
        {
            bool flag = false;
            foreach (Salarie s2 in salaries)
                if (s.Nss == s2.Nss)
                    flag = true;
            return flag;
        }



        /// <summary>
        /// Met la liste des salariés sous forme d'arbre
        /// </summary>
        public Arbre MiseEnArbre()
        {
            Salarie directeur = null;
            bool found = false;
            List<Salarie> aPlacer = new List<Salarie>();
            List<Salarie> dejaPlace = new List<Salarie>();
            List<Salarie> temp = new List<Salarie>();
            foreach (Salarie s in salaries)
                aPlacer.Add(s);
            for (int i = 0; i < salaries.Count && (!found); i++)
            {
                if (salaries[i].Poste == "Directeur General")
                {
                    found = true;
                    directeur = salaries[i];
                }
            }
            NoeudArbre racine = new NoeudArbre(directeur);
            Arbre organigramme = new Arbre(racine);
            dejaPlace.Add(directeur);
            aPlacer.Remove(directeur);
            foreach (Salarie s in aPlacer)
            {
                if (s.PosteSuperieur == "Directeur General")
                {
                    if (racine.Fils == null) { racine.Fils = new NoeudArbre(s); }
                    else { organigramme.insererFrere(organigramme.Racine.Fils, new NoeudArbre(s)); }
                    dejaPlace.Add(s);
                }
            }

            foreach (Salarie s in dejaPlace) { aPlacer.Remove(s); }

            while (aPlacer.Count > 0)
            {
                foreach (Salarie s in aPlacer)
                {
                    foreach (Salarie superieur in dejaPlace)
                    {
                        if (superieur.Poste == s.PosteSuperieur)
                        {
                            organigramme.insererSalarie(organigramme.Racine, superieur, s);
                            temp.Add(s);
                        }
                    }
                }

                foreach (Salarie s in temp)
                {
                    aPlacer.Remove(s);
                    dejaPlace.Add(s);
                }
                temp = new List<Salarie>();
            }
            return organigramme;
        }

        /// <summary>
        /// retourne l'indice dans la liste des salariés du salarié dont le Nss est "nss" 
        /// </summary>
        /// <param name="nss"></param>
        /// <returns></returns>
        public int indiceSalarieNss(string nss)
        {
            Salarie s = null;
            int indice = -1;
            foreach (Salarie salarie in salaries)
                if (salarie.Nss == nss)
                    s = salarie;
            if (s != null)
                indice = indiceSalarie(s);
            return indice;

        }

        public int indiceSalarie(Salarie s)
        { return ListeSalaries.IndexOf(s); }

        #region gestionSalarie
        /// <summary>
        /// Méthode à utiliser pour renvoyer un salarié
        /// </summary>
        /// <param name="organigramme"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Renvoi(Arbre organigramme, Salarie s)
        {
            bool val = false;
            if (s.EstDirecteur)
            {
                if (organigramme.RechercherNoeudArbre(organigramme.Racine, s).Fils == null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir renvoyer {s.Prenom} {s.Nom}/{s.Poste} ?", "Renvoi salarié", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SupprimerSalarie(s);
                        val = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Le salarié que vous essayez de renvoyé à des employés à sa charge, il ne peut qu'être remplacé");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir renvoyer {s.Prenom} {s.Nom}/{s.Poste} ?", "Renvoi salarié", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SupprimerSalarie(s);
                    val = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            return val;
        }

        public void Remplacement(Salarie remplace, Salarie remplacant)
        {
            DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir remplacer {remplace.Prenom} {remplace.Nom} par {remplacant.Prenom} {remplacant.Nom} au poste de {remplace.Poste} ?", "Remplacement salarié", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                remplace.Remplacer(remplacant);
                ActualiserFichier();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        #endregion

        public Salarie TrouverSalarie(string nss) //Peut ne pas être trouvé si le Salarié à été viré
        {
            Salarie salarieRetourne = null;
            if (salaries != null)
                for (int i = 0; i < salaries.Count && salarieRetourne == null; i++)
                { if (salaries[i].Nss == nss) salarieRetourne = salaries[i]; }
            return salarieRetourne;
        }

        #region Disponibilité chauffeurs
        
        /// <summary>
        /// Retourne le prochain chauffeur disponible
        /// </summary>
        /// <returns></returns>
        public Salarie ProchainChauffeurDispo()
        {
            Salarie chauffeur = chauffeurs[0];
            DateTime date = chauffeurs[0].ProchaineDispoChauffeur();
            if (chauffeurs.Count>1)
                for (int i = 1;i<chauffeurs.Count;i++)
                {
                    if (chauffeurs[i].ProchaineDispoChauffeur() < date)
                    {
                        date = chauffeurs[i].ProchaineDispoChauffeur();
                        chauffeur = chauffeurs[i];
                    }
                }
            return chauffeur; 
        }

        /// <summary>
        /// Retourne la prochaine date de disponibilité d'un chauffeur
        /// </summary>
        /// <returns></returns>
        public DateTime ProchaineDispoDate()//Privilégier l'utilisation de .ProchaineDispoSalarie() sur le Prochain chauffeur dispo
        {
            DateTime date = chauffeurs[0].ProchaineDispoChauffeur();
            if (chauffeurs.Count > 1)
                for (int i = 1; i < chauffeurs.Count; i++)
                {
                    if (chauffeurs[i].ProchaineDispoChauffeur() < date)
                    {
                        date = chauffeurs[i].ProchaineDispoChauffeur();
                    }
                }
            return date;
        }

        public Salarie ChauffeurDispo(DateTime date) 
        { 
            Salarie dispo=null;
            for (int i=0;i<chauffeurs.Count && dispo==null;i++)
                if (!EmploiDuTemps.LectureDates(chauffeurs[i]).Contains(date))
                    dispo= chauffeurs[i];
            return dispo;
        }

        public bool DatePossible(DateTime date)
        {
            return !(ChauffeurDispo(date) == null);
        }
        #endregion
    }
}