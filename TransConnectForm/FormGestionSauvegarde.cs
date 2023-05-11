using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransConnectForm
{
    public partial class FormGestionSauvegarde : Form
    {
        private Formulaire_principal predecesseur;
        private List<string> sauvegardes;
        public FormGestionSauvegarde(Formulaire_principal predecesseur)
        {

            this.predecesseur= predecesseur;
            InitializeComponent();
            Actualiser();
        }

        private void LectureSauvegardes()
        {
            sauvegardes= new List<string>();
            foreach(string dossier in Directory.GetDirectories("Sauvegardes"))
            {
                sauvegardes.Add((dossier.Split("\\"))[1]);
            }
            sauvegardes.Sort();
        }

        private void Actualiser()
        {
            LectureSauvegardes();
            DataTable table = new DataTable();
            table.Columns.Add("Date de sauvegarde", typeof(string));

            foreach (String valeur in sauvegardes)
            {
                //Crée une nouvelle ligne de données
                DataRow row = table.NewRow();

                // valeur de la ligne
                row["Date de sauvegarde"] = valeur.Trim();

                // ajout de la ligne
                table.Rows.Add(row);
            }

            TableauSauvegardes.DataSource = table;
            TableauSauvegardes.Columns[0].Width = 200;
        }

        private void Sauvegarder()
        {
            string root = $"Sauvegardes\\{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}\\";
            Directory.CreateDirectory(root);
            string Chauffeurs = "Chauffeurs.csv";
            string Client = "Clients.csv";
            string Commandes = "Commandes.csv";
            string Salaries = "Salaries.csv";
            string Vehicules = "Vehicules.csv";
            string dossierDatesChauffeurs = "DatesChauffeurs";
            string dossierVehicules = "Vehicules";
            Directory.CreateDirectory(root + dossierDatesChauffeurs);
            Directory.CreateDirectory(root + dossierVehicules);
            string[] contenuDatesChauffeurs = Directory.GetFiles(dossierDatesChauffeurs);
            string[] contenuVehicules = Directory.GetFiles(dossierVehicules);
            File.Copy(Chauffeurs, root + Chauffeurs);
            File.Copy(Client, root + Client);
            File.Copy(Commandes, root + Commandes);
            File.Copy(Salaries, root + Salaries);
            File.Copy(Vehicules, root + Vehicules);
            foreach (string file in contenuDatesChauffeurs)
                File.Copy(file, root + file);
            foreach (string file in contenuVehicules)
                File.Copy(file,root + file);
            Actualiser();
        }

        private void btn_sauvegarde_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Voulez vous creez une sauvegarde des fichiers actuels ?", "Création sauvegarde", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Sauvegarder(); 
                MessageBox.Show($"La sauvegarde à été ajoutée au dossier de sauvegarde");
            }
            else if (dialogResult == DialogResult.No)
            {
                //this.Close();
            }
            
        }

        private void Charger(string sauvegarde)
        {
            string cheminSauvegarde = $"Sauvegardes\\{sauvegarde}\\";
            string Chauffeurs = $"Chauffeurs.csv";
            string Client = "Clients.csv";
            string Commandes = "Commandes.csv";
            string Salaries = "Salaries.csv";
            string Vehicules = "Vehicules.csv";
            string dossierDatesChauffeurs = "DatesChauffeurs";
            string dossierVehicules = "Vehicules";
            string[] contenuDatesChauffeurs = Directory.GetFiles(cheminSauvegarde+dossierDatesChauffeurs);
            string[] contenuVehicules = Directory.GetFiles(cheminSauvegarde+dossierVehicules);
            File.Copy(cheminSauvegarde+Chauffeurs,Chauffeurs,true);
            File.Copy(cheminSauvegarde + Client, Client, true);
            File.Copy(cheminSauvegarde + Commandes,Commandes, true);
            File.Copy(cheminSauvegarde + Salaries, Salaries, true);
            File.Copy(cheminSauvegarde + Vehicules,Vehicules, true);
            foreach (string file in contenuDatesChauffeurs)
                File.Copy(file, (file.Split("\\"))[2] + "\\" + (file.Split("\\"))[3], true);
            foreach (string file in contenuVehicules)
                File.Copy(file, (file.Split("\\"))[2] + "\\" + (file.Split("\\"))[3], true);
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            if(TableauSauvegardes.SelectedCells.Count == 0 ) 
            {
                MessageBox.Show("Veuillez sélectionner une sauvegarde");
            }
            else if (TableauSauvegardes.SelectedCells.Count> 1)
            {
                MessageBox.Show("Vous ne pouvez charger qu'une seule sauvegarde à la fois");
            }
            else if (TableauSauvegardes.SelectedCells[0].Value!= null)
            {
                string sauvegarde = TableauSauvegardes.SelectedCells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show($"Voulez vous charger la sauvegarde datant du {sauvegarde}?\n!!! ATTENTION !!! Toute donnée non sauvegardée sera écrasée", "Charger sauvegarde", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Charger(sauvegarde);
                    MessageBox.Show($"La sauvegarde du {sauvegarde} à été chargée");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //this.Close();
                }
            }
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            predecesseur.Show();
        }

        private void FormGestionSauvegarde_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.Close();
        }
    }
}
