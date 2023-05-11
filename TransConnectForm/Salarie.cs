using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal class Salarie : Personne
    {
        private DateTime dateDentree;
        private string poste;
        private double salaire;
        private string posteSuperieur;
        private bool directeur; //Est-ce un poste de directeur ?
        private List<DateTime> datesOccuppees;

        public Salarie(string nss, string nom, string prenom, DateTime dateDeNaissance, string adresse, string mail, string numerotel, DateTime dateDentree, string poste, double salaire, string posteSuperieur = null, bool directeur = false) : base(nss, nom.ToUpper(), prenom, dateDeNaissance, adresse, mail, numerotel)
        {
            this.dateDentree = dateDentree;
            this.poste = poste;
            this.salaire = salaire;
            this.posteSuperieur = posteSuperieur;
            this.directeur = directeur;
            this.datesOccuppees = null;
        }

        public DateTime DateDentree
        { get { return dateDentree; } }

        public string Poste
        { get { return poste; } set { poste = value; } }

        public double Salaire
        { get { return salaire; } set { salaire = value; } }

        public string PosteSuperieur { get { return posteSuperieur; } }

        public bool EstDirecteur { get { return directeur; } }

        public List<DateTime> ListeDatesOccupees { get { return datesOccuppees; } set { datesOccuppees = value; } }

        public override void Remplacer(Salarie nouveau)
        {
            base.Remplacer(nouveau);
            this.dateDentree=nouveau.DateDentree;
            this.poste = nouveau.poste;
            this.salaire=nouveau.salaire;
            this.posteSuperieur=nouveau.posteSuperieur;
            this.directeur=nouveau.directeur;
        }

        public bool EstDisponible(DateTime date)
        {
            bool flag = true;
            if (ListeDatesOccupees != null && ListeDatesOccupees.Count > 0)
            {
                for (int i = 0; i < ListeDatesOccupees.Count && flag; i++)
                {
                    if (date.Date == ListeDatesOccupees[i])
                        flag = false;
                }
            }
            return flag;
        }

        public DateTime ProchaineDispoChauffeur()
        {
            List<DateTime> dates = null;
            TimeSpan huitHeure = new TimeSpan(8, 0, 0);
            TimeSpan heureActuelle = DateTime.Now.TimeOfDay;
            DateTime date = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

            //Si l'on est après 8h, pas de nouvelle commande pour le jour même
            if (heureActuelle > huitHeure)
                date.AddDays(1);

            if (poste=="Chauffeur")
            {
                dates = EmploiDuTemps.LectureDates(this); //Toutes les dates déjà occupées
                while (dates.Contains(date)) //Avance le jour 1 par 1 jusqu'à trouver la prochaine disponibilité
                    date.AddDays(1);
            }
            return date;
        }

        public bool aDesCommandesEnCours()
        {
            bool valeur = false;
            if (Poste == "Chauffeur")
            {
                List<DateTime> dates = new List<DateTime>();
                dates = EmploiDuTemps.LectureDates(this);
                for (int i = 0; i < dates.Count && !valeur; i++)
                {
                    if (dates[i] >= DateTime.Today)
                        valeur = true;
                }
            }
            return valeur;
        }

        public void AjouterCommande(Commande commande)
        {
            EmploiDuTemps.AjouterCommande(this, commande);
        }

        public void AnnulerCommande(Commande commande)
        {
            EmploiDuTemps.AnnulerCommande(this, commande);
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom}";
        }

    }
}
