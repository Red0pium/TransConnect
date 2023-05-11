using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal abstract class Personne 
    {
        private string nss;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string adresse; //Ville
        private string mail;
        private string numerotel;

        public Personne(string nss, string nom, string prenom, DateTime dateDeNaissance, string adresse, string mail, string numerotel)
        {
            this.nss = nss;
            this.nom = nom;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
            this.adresse = adresse;
            this.mail = mail;
            this.numerotel = numerotel;
        }

        public string Nss
        { get { return nss; } }
        public string Nom
        { get { return nom; } set { nom = value; } }

        public string Prenom
        { get { return prenom; } }

        public DateTime DateDeNaissance
        { get { return dateDeNaissance; } }

        public string Adresse
        { get { return adresse; } set { adresse = value; } }

        public string Mail
        { get { return mail; } set { mail = value; } }

        public string Numerotel
        { get { return numerotel; } set { numerotel = value; } }

        public virtual void Remplacer(Salarie s)
        {
            this.nss = s.Nss;
            this.nom = s.Nom;
            this.prenom = s.Prenom;
            this.dateDeNaissance = s.DateDeNaissance;
            this.adresse = s.adresse;
            this.mail = s.mail;
            this.numerotel=s.numerotel;
        }
    }
}
