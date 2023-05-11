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
    internal partial class FormNouvelleCommande : Form
    {
        private FormCommandes predecesseur;
        private Vehicules vehicules;
        private Salaries salaries;
        private List<DateTime> datesPleines;
        private List<CamionBenne> camionsBenne;
        private List<CamionCiterne> camionsCiterne;
        private List<CamionFrigorifique> camionsFrigorifique;
        private List<Camionnette> camionnettes;
        private List<Car> cars;
        private DateTime dateSelectionnee;
        private int indiceComboBox;
        private Commandes commandes;
        private Clients clients;

        public FormNouvelleCommande(FormCommandes predecesseur, Vehicules vehicules, Salaries salaries)
        {
            this.predecesseur= predecesseur;
            commandes = new Commandes();
            clients = new Clients();
            camionsBenne = new List<CamionBenne>();
            camionsCiterne = new List<CamionCiterne>();
            camionsFrigorifique = new List<CamionFrigorifique>();
            camionnettes = new List<Camionnette>();
            cars = new List<Car>();
            datesPleines= new List<DateTime>();
            this.vehicules = vehicules;
            dateSelectionnee = DateTime.Today;

            //Remplissage des différentes listes
            foreach (Vehicule v in vehicules.ListeVehicules)
            {
                if (v is CamionBenne)
                {
                    camionsBenne.Add((CamionBenne)v);
                }
                else if (v is CamionCiterne)
                {
                    camionsCiterne.Add((CamionCiterne)v);
                }
                else if (v is CamionFrigorifique)
                {
                    camionsFrigorifique.Add((CamionFrigorifique)v);
                }
                else if (v is Camionnette)
                {
                    camionnettes.Add((Camionnette)v);
                }
                else if (v is Car)
                {
                    cars.Add((Car)v);
                }
            }
            this.salaries= salaries;
            InitializeComponent();
            btn_Nouveau.Hide();
            Calendrier.MinDate = DateTime.Today;
            DateTime date = DateTime.Today;
            for (int i=0;i<30;i++)
            {
                if (!(salaries.DatePossible(date)))
                    datesPleines.Add(date);
                
            }
            if (datesPleines != null && datesPleines.Count > 0)
            {
                DateTime[] datesPleines2 = new DateTime[datesPleines.Count];
                for (int i = 0; i < datesPleines.Count; i++)
                    datesPleines2[i] = datesPleines[i];
                Calendrier.BoldedDates = datesPleines2;
            }
            cbBox_Vehicule.SelectedIndex = 0;
            clients.LectureFichierClient();
            commandes.LectureFichierCommande(clients,vehicules,salaries);
            indiceComboBox = 0;
            Update();
        }



        private void Update()
        {
            btn_Dispo.Text = $"Voir les {cbBox_Vehicule.Text.ToLower()} disponible le {Calendrier.SelectionRange.Start.ToShortDateString()}";
        }


        #region event
        private void Calendrier_DateSelected(object sender, DateRangeEventArgs e)
        {
            Update();
        }

        private void cbBox_Vehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update();
        }
        #endregion


        private void btn_Dispo_Click(object sender, EventArgs e)
        {
            btn_Nouveau.Show();
            DateTime date = Calendrier.SelectionRange.Start;
            dateSelectionnee = date;
            indiceComboBox = cbBox_Vehicule.SelectedIndex;
            if (cbBox_Vehicule.SelectedIndex==-1)
            {
                MessageBox.Show("Type de vehicule selectionné impossible");
            }
            else if (cbBox_Vehicule.SelectedIndex == 0) 
            {
                List<CamionBenne> disponibles = new List<CamionBenne>();
                foreach (CamionBenne camionBenne in camionsBenne)
                {
                    if (camionBenne.EstDisponible(date))
                        disponibles.Add(camionBenne);
                }
                tableauVehicules.DataSource = disponibles;
            }
            else if (cbBox_Vehicule.SelectedIndex == 1)
            {
                List<CamionCiterne> disponibles = new List<CamionCiterne>();
                foreach (CamionCiterne camionCiterne in camionsCiterne)
                {
                    if (camionCiterne.EstDisponible(date))
                        disponibles.Add(camionCiterne);
                }
                tableauVehicules.DataSource = disponibles;
            }
            else if (cbBox_Vehicule.SelectedIndex == 2)
            {
                List<CamionFrigorifique> disponibles = new List<CamionFrigorifique>();
                foreach (CamionFrigorifique camionFrigorifique in camionsFrigorifique)
                {
                    if (camionFrigorifique.EstDisponible(date))
                        disponibles.Add(camionFrigorifique);
                }
                tableauVehicules.DataSource = disponibles;
            }
            else if (cbBox_Vehicule.SelectedIndex == 3)
            {
                List<Camionnette> disponibles = new List<Camionnette>();
                foreach (Camionnette camionnette in camionnettes)
                {
                    if (camionnette.EstDisponible(date))
                        disponibles.Add(camionnette);
                }
                tableauVehicules.DataSource = disponibles;
            }
            else if (cbBox_Vehicule.SelectedIndex == 4)
            {
                List<Car> disponibles = new List<Car>();
                foreach (Car car in cars)
                {
                    if (car.EstDisponible(date))
                        disponibles.Add(car);
                }
                tableauVehicules.DataSource = disponibles;
            }
        }

        

        private Client SelectionnerClient()
        {
            Client retour = null;
            using (FormSelectionClient f = new FormSelectionClient())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    retour = f.Retour;
                }
            }
            return retour;
        }


        private Salarie SelectionnerChauffeur(DateTime date)
        {
            Salarie retour = null;
            if (datesPleines != null && datesPleines.Contains(date))
            {
                MessageBox.Show("Aucun chauffeur n'est disponible à cette date");
            }
            else
            {
                List<Salarie> dispo = new List<Salarie>();
                DataGridView grid = new DataGridView();
                foreach (Salarie salarie in salaries.ListeChauffeurs)
                {
                    if (salarie.EstDisponible(date))
                        dispo.Add(salarie);
                }
                using(FormSelectionChauffeur f = new FormSelectionChauffeur(dispo))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        retour = f.Retour;
                    }
                }
                
            }
            return retour;
        }



        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            bool ajouter = true;
            if (dateSelectionnee != Calendrier.SelectionRange.Start)
            {
                ajouter = false;
                MessageBox.Show("La date selectionnée a été changée mais le tableau des vehicules disponible n'a pas été actualisé");
            }
            else if (indiceComboBox != cbBox_Vehicule.SelectedIndex)
            {
                ajouter = false;
                MessageBox.Show("Le type de vehicule selectionné a été changé mais le tableau des vehicules disponible n'a pas été actualisé");
            }

            if (ajouter)
            {
                if (tableauVehicules.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Aucune ligne du tableau n'a été sélectionnée");
                }
                else if (tableauVehicules.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Vous ne pouvez sélectionner qu'un seul vehicule à la fois");
                }
                else
                {
                    Salarie chauffeur = SelectionnerChauffeur(dateSelectionnee);
                    if (chauffeur != null)
                    {
                        Client client = SelectionnerClient();
                        if (client != null)
                        {
                            Vehicule selection = vehicules.TrouverVehicule(tableauVehicules.SelectedRows[0].Cells["PlaqueImmatriculation"].Value.ToString());
                            if (indiceComboBox == 0)
                            {
                                CamionBenne vehicule = (CamionBenne)selection;
                                FormCommandeCamionBenne f = new FormCommandeCamionBenne(this,client, chauffeur, vehicule, dateSelectionnee,commandes);
                                f.Show();
                            }
                            else if (indiceComboBox == 1)
                            {
                                CamionCiterne vehicule = (CamionCiterne)selection;
                                FormCommandeCamionCiterne f = new FormCommandeCamionCiterne(this,client,chauffeur,vehicule,dateSelectionnee,commandes);
                                f.Show();
                            }
                            else if (indiceComboBox == 2)
                            {
                                CamionFrigorifique vehicule = (CamionFrigorifique)selection;
                                FormCommandeCamionFrigorifique f = new FormCommandeCamionFrigorifique(this, client, chauffeur, vehicule, dateSelectionnee, commandes);
                                f.Show();
                            }
                            else if (indiceComboBox == 3)
                            {
                                Camionnette vehicule = (Camionnette)selection;
                                FormCommandeCamionnette f = new FormCommandeCamionnette(this, client, chauffeur, vehicule, dateSelectionnee, commandes);
                                f.Show();
                            }
                            else if (indiceComboBox == 4)
                            {
                                Car vehicule = (Car)selection;
                                FormCommandeCar f = new FormCommandeCar(this, client, chauffeur, vehicule, dateSelectionnee, commandes);
                                f.Show();
                            }
                        }
                    }
                }
            }
        }

        private void FormNouvelleCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.Actualiser();
        }
    }
}