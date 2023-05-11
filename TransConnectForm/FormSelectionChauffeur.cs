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
    internal partial class FormSelectionChauffeur : Form
    {
        private Salarie retour;
        List<Salarie> dispo;
        public Salarie Retour { get { return retour; } }
        public FormSelectionChauffeur(List<Salarie> dispo)
        {
            this.retour= null;
            this.dispo = dispo;
            InitializeComponent();
            TableauChauffeurs.DataSource = dispo;
        }

        private void btn_Selection_Click(object sender, EventArgs e)
        {
            if(TableauChauffeurs.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Aucune ligne n'a été sélectionnée");
            }
            else if(TableauChauffeurs.SelectedRows.Count> 1)
            {
                MessageBox.Show("Il n'est possible de sélectionner qu'un seul chauffeur à la fois");
            }
            else
            {
                int indice = TableauChauffeurs.SelectedRows[0].Index;
                DialogResult dialogResult = MessageBox.Show($"Selectionner {dispo[indice].Prenom} {dispo[indice].Nom} en tant que chauffeur pour la commande ?", "Selection chauffeur", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show($"{dispo[indice].Prenom} {dispo[indice].Nom} à été sélectionné comme chauffeur de la commande");
                    retour = dispo[indice];
                    DialogResult= DialogResult.OK;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
