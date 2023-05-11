namespace TransConnectForm
{
    partial class FormCommandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_NouvelleCommande = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Actualiser = new System.Windows.Forms.Button();
            this.TableauCommandes = new System.Windows.Forms.DataGridView();
            this.btn_Chemin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableauCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 26);
            this.toolStripMenuItem2.Text = "À &propos";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_retour.Location = new System.Drawing.Point(67, 306);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(147, 94);
            this.btn_retour.TabIndex = 5;
            this.btn_retour.Text = "Retour au formulaire principal";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_NouvelleCommande
            // 
            this.btn_NouvelleCommande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_NouvelleCommande.Location = new System.Drawing.Point(669, 306);
            this.btn_NouvelleCommande.Name = "btn_NouvelleCommande";
            this.btn_NouvelleCommande.Size = new System.Drawing.Size(147, 94);
            this.btn_NouvelleCommande.TabIndex = 5;
            this.btn_NouvelleCommande.Text = "Nouvelle commande";
            this.btn_NouvelleCommande.UseVisualStyleBackColor = true;
            this.btn_NouvelleCommande.Click += new System.EventHandler(this.btn_NouvelleCommande_click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Annuler.Location = new System.Drawing.Point(277, 306);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(147, 94);
            this.btn_Annuler.TabIndex = 5;
            this.btn_Annuler.Text = "Annuler la commande sélectionnée";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Actualiser
            // 
            this.btn_Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Actualiser.Location = new System.Drawing.Point(879, 306);
            this.btn_Actualiser.Name = "btn_Actualiser";
            this.btn_Actualiser.Size = new System.Drawing.Size(147, 94);
            this.btn_Actualiser.TabIndex = 5;
            this.btn_Actualiser.Text = "Actualiser les commandes";
            this.btn_Actualiser.UseVisualStyleBackColor = true;
            this.btn_Actualiser.Click += new System.EventHandler(this.btn_Actualiser_Click);
            // 
            // TableauCommandes
            // 
            this.TableauCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauCommandes.Location = new System.Drawing.Point(24, 31);
            this.TableauCommandes.Name = "TableauCommandes";
            this.TableauCommandes.RowHeadersWidth = 51;
            this.TableauCommandes.RowTemplate.Height = 29;
            this.TableauCommandes.Size = new System.Drawing.Size(1046, 258);
            this.TableauCommandes.TabIndex = 6;
            // 
            // btn_Chemin
            // 
            this.btn_Chemin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Chemin.Location = new System.Drawing.Point(476, 306);
            this.btn_Chemin.Name = "btn_Chemin";
            this.btn_Chemin.Size = new System.Drawing.Size(147, 94);
            this.btn_Chemin.TabIndex = 5;
            this.btn_Chemin.Text = "Afficher le chemin à emprunter";
            this.btn_Chemin.UseVisualStyleBackColor = true;
            this.btn_Chemin.Click += new System.EventHandler(this.btn_Chemin_Click);
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 433);
            this.Controls.Add(this.TableauCommandes);
            this.Controls.Add(this.btn_Chemin);
            this.Controls.Add(this.btn_Actualiser);
            this.Controls.Add(this.btn_NouvelleCommande);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Annuler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommandes";
            this.Text = "Commandes en cours";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommandesForm_FormClosed);
            this.Load += new System.EventHandler(this.FormCommandes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableauCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button btn_retour;
        private Button btn_NouvelleCommande;
        private Button btn_Annuler;
        private Button btn_Actualiser;
        private DataGridView TableauCommandes;
        private Button btn_Chemin;
    }
}