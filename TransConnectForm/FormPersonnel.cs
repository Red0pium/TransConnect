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
    public partial class FormPersonnel : Form
    {
        private bool modification;
        private Arbre organigramme;
        private Salaries salaries;

        private Formulaire_principal formulaire_principal;
        public FormPersonnel(Formulaire_principal formulaire_principal)
        {
            modification = false;
            this.formulaire_principal = formulaire_principal;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

        }

        private void PersonnelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValidationSauvegarde();
            formulaire_principal.Close();
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette interface graphique à été crée par Mathys Bronnec à l'aide de Windows Forms qui n'est pas le plus courrant quand il s'agit de création de Formulaire, WPF aurait été plus adapté mais n'étais pas aussi simple d'utilisation à mes yeux");
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            ValidationSauvegarde();
            this.Hide();
            formulaire_principal.Show();
        }


        public void Actualiser()
        {
            textBox1.Show();
            TableauPersonnel.DataSource = "";
            salaries = new Salaries();
            salaries.LectureFichierSalaries();
            this.organigramme = salaries.MiseEnArbre();
            treeView1.Nodes.Clear();
            AfficherArbre(organigramme.Racine, treeView1.Nodes);
        }
        private void FormPersonnel_Load(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void AfficherArbre(NoeudArbre noeudArbre, TreeNodeCollection nodes)
        {
            TreeNode node = new TreeNode(noeudArbre.ToString());
            node.Name = noeudArbre.Valeur.Nss;
            nodes.Add(node);

            if (noeudArbre.Fils != null)
            {
                AfficherArbre(noeudArbre.Fils, node.Nodes);
            }

            if (noeudArbre.Frere != null)
            {
                AfficherArbre(noeudArbre.Frere, nodes);
            }
        }

        private Salarie salarieSelectionne()
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Vous avez double cliqué dans le vide sur l'arbre");
                return null;
            }
            else
                return salaries.ListeSalaries[salaries.indiceSalarieNss(treeView1.SelectedNode.Name)];
        }

        private Salarie salarieSelectionne2()
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Aucun salarié n'a été sélectionné dans l'arbre");
                return null;
            }
            else
                return salaries.ListeSalaries[salaries.indiceSalarieNss(treeView1.SelectedNode.Name)];
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Hide();
            Salarie selectionne = salarieSelectionne();
            List<Salarie> list = new List<Salarie> { selectionne };
            TableauPersonnel.DataSource = list;
            TableauPersonnel.Columns[0].ReadOnly = true;
            TableauPersonnel.Columns[1].ReadOnly = true;
            TableauPersonnel.Columns[2].ReadOnly = false;
            TableauPersonnel.Columns[3].ReadOnly = true;
            TableauPersonnel.Columns[4].ReadOnly = true;
            TableauPersonnel.Columns[5].ReadOnly = true;
            TableauPersonnel.Columns[6].ReadOnly = false;
            TableauPersonnel.Columns[7].ReadOnly = true;
            TableauPersonnel.Columns[8].ReadOnly = true;
            TableauPersonnel.Columns[9].ReadOnly = false;
            TableauPersonnel.Columns[10].ReadOnly = false;
            TableauPersonnel.Columns[11].ReadOnly = false;
        }

        private void ActualiserSalarie(object sender, TreeNodeMouseClickEventArgs e)
        {
            Salarie selectionne = salarieSelectionne();
            List<Salarie> list = new List<Salarie> { selectionne };
            TableauPersonnel.DataSource = list;
            TableauPersonnel.Columns[0].ReadOnly = true;
            TableauPersonnel.Columns[1].ReadOnly = true;
            TableauPersonnel.Columns[2].ReadOnly = false;
            TableauPersonnel.Columns[3].ReadOnly = true;
            TableauPersonnel.Columns[4].ReadOnly = true;
            TableauPersonnel.Columns[5].ReadOnly = true;
            TableauPersonnel.Columns[6].ReadOnly = false;
            TableauPersonnel.Columns[7].ReadOnly = true;
            TableauPersonnel.Columns[8].ReadOnly = true;
            TableauPersonnel.Columns[9].ReadOnly = false;
            TableauPersonnel.Columns[10].ReadOnly = false;
            TableauPersonnel.Columns[11].ReadOnly = false;
        }

        private void TableauPersonnel_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modification = true;
        }

        private void btn_sauvegarde_Click(object sender, EventArgs e)
        {
            if (modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Êtes vous sûr de vouloir valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    salaries.ActualiserFichier();
                    Actualiser();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                modification = false;
            }
            else
                MessageBox.Show("Aucune modification n'a été effectuée");
        }

        private void ValidationSauvegarde()
        {
            if (modification)
            {
                DialogResult dialogResult = MessageBox.Show($"Voulez-vous valider les modifications d'attribut effectuées ?", "Modification attributs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    salaries.ActualiserFichier();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                modification = false;
            }
        }

        private void btn_Recruter_Click(object sender, EventArgs e)
        {
            FormAjoutSalarie f = new FormAjoutSalarie(this);
            f.Show();
        }

        private void btn_Renvoi_Click(object sender, EventArgs e)
        {
            Salarie s = salarieSelectionne2();
            if (s != null)
            {
                if (s.aDesCommandesEnCours())
                    MessageBox.Show($"Le chauffeur {s.Prenom} {s.Nom} a des commandes à venir, veuillez annuler toutes celles-ci avant de pouvoir le renvoyer");
                else
                {
                    salaries.Renvoi(organigramme, s);
                    Actualiser();
                }
            }
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            Salarie s = salarieSelectionne2();
            if (s != null )
            {
                if (s.aDesCommandesEnCours())
                    MessageBox.Show($"Le chauffeur {s.Prenom} {s.Nom} a des commandes à venir, veuillez annuler toutes celles-ci avant de pouvoir le remplacer");
                else
                {
                    FormRemplacement f = new FormRemplacement(this, s, salaries);
                    f.Show();
                }
            }
        }
    }
    
}
