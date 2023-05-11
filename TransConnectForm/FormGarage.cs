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
    public partial class FormGarage : Form
    {
        private Vehicules vehicules;
        private Formulaire_principal predecesseur;
        public FormGarage(Formulaire_principal predecesseur)
        {
            this.predecesseur= predecesseur;
            vehicules= new Vehicules();
            InitializeComponent();
        }

        public void Actualiser()
        {
            vehicules.LectureFichierVehicule();
            TableauSauvegardes.DataSource = vehicules.ListeVehicules;
        }
        private void btn_Actualiser_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            predecesseur.Show();
        }

        private void FormGarage_FormClosed(object sender, FormClosedEventArgs e)
        {
            predecesseur.Close();
        }

        private void FormGarage_Shown(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            FormNouveauVehicule f = new FormNouveauVehicule(this, vehicules);
            f.Show();
        }

        private void btn_suppression_Click(object sender, EventArgs e)
        {
            if (TableauSauvegardes.SelectedRows.Count > 1) 
            {
                MessageBox.Show("Vous ne pouvez sélectionner qu'un seul vehicule à la fois");
            }
            else if (TableauSauvegardes.SelectedRows.Count==0)
            {
                MessageBox.Show("Aucune ligne du tableau n'a été selectionnée");
            }
            else
            {
                Vehicule selection = vehicules.TrouverVehicule(TableauSauvegardes.SelectedRows[0].Cells["PlaqueImmatriculation"].Value.ToString());
                vehicules.SupprimerVehicule(selection);
                Actualiser();
            }
        }
    }
}
