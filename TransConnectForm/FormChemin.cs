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
    internal partial class FormChemin : Form
    {
        List<Noeud> chemin;
        public FormChemin(List<Noeud> chemin,string numeroDeCommande)
        {
            InitializeComponent();
            this.chemin = chemin;
            Text = "";
            if (chemin.Count == 1)
            {
                Text = chemin[0].Valeur;
            }
            else if (chemin.Count == 2)
            {
                if (chemin[0] == chemin[1])
                    Text= chemin[0].Valeur;
                else
                    Text = $"{chemin[0].Valeur} --> {chemin[1].Valeur}";
            }
            else
            {
                for (int i = 0; i < chemin.Count-1; i++) 
                {
                    Text += $"{chemin[i].Valeur} --> ";
                }
                Text += chemin[chemin.Count - 1].Valeur;
            }
            txt_text.Text = Text;
            this.Text = $"Chemin commande n°{numeroDeCommande}";
        }
    }
}
