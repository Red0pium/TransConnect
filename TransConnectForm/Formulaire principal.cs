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
    public partial class Formulaire_principal : Form
    {
        FormPersonnel personnelForm;
        FormClients clientForm;
        FormStatistiques statForm;
        FormCommandes commandesForm;
        FormGestionSauvegarde gestionSauvegardeForm;
        FormGarage garageForm;
        bool personnelFormbool;
        bool clientFormbool;
        bool statFormbool;
        bool commandesFormbool;
        bool gestionSauvegardeFormbool;
        bool garageFormbool;

        public Formulaire_principal()
        {
            StartPosition = FormStartPosition.CenterScreen;
            personnelFormbool= false;
            clientFormbool= false;
            statFormbool= false;
            commandesFormbool= false;
            gestionSauvegardeFormbool = false;
            garageFormbool= false;
            InitializeComponent();
        }


        private void btn_Personnel_Click(object sender, EventArgs e)
        {
            if (!personnelFormbool) 
            { 
                personnelForm = new FormPersonnel(this); 
                personnelFormbool = true;
            }
            this.Hide();
            personnelForm.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette interface graphique à été crée par Mathys Bronnec à l'aide de Windows Forms qui n'est pas le plus courrant quand il s'agit de création de Formulaire, WPF aurait été plus adapté mais n'étais pas aussi simple d'utilisation à mes yeux");
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            if(!clientFormbool)
            {
                clientForm = new FormClients(this);
                clientFormbool = true;
            }
            this.Hide();
            clientForm.ActualiserListeClient();
            clientForm.Show();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            if (!statFormbool)
            {
                statForm = new FormStatistiques(this);
                statFormbool = true;
            }
            this.Hide();
            statForm.Show();
        }

        private void btn_commandes_Click(object sender, EventArgs e)
        {
            if (!commandesFormbool)
            {
                commandesForm = new FormCommandes(this);
                commandesFormbool = true;
            }
            this.Hide();
            commandesForm.Show();
        }


        private void btn_GestionSauvegardes_Click(object sender, EventArgs e)
        {
            if (!gestionSauvegardeFormbool)
            {
                gestionSauvegardeForm = new FormGestionSauvegarde(this);
                gestionSauvegardeFormbool = true;
            }
            this.Hide();
            gestionSauvegardeForm.Show();
        }

        private void btn_garage_Click(object sender, EventArgs e)
        {
            if (!garageFormbool)
            {
                garageForm= new FormGarage(this);
                garageFormbool = true;
            }
            this.Hide();
            garageForm.Show();
        }
    }
}
