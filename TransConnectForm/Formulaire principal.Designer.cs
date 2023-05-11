namespace TransConnectForm
{
    partial class Formulaire_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulaire_principal));
            this.btn_Personnel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_commandes = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_garage = new System.Windows.Forms.Button();
            this.btn_Gestion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Personnel
            // 
            this.btn_Personnel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Personnel.Location = new System.Drawing.Point(47, 183);
            this.btn_Personnel.Name = "btn_Personnel";
            this.btn_Personnel.Size = new System.Drawing.Size(217, 94);
            this.btn_Personnel.TabIndex = 0;
            this.btn_Personnel.Text = "Personnel";
            this.btn_Personnel.UseVisualStyleBackColor = true;
            this.btn_Personnel.Click += new System.EventHandler(this.btn_Personnel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
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
            // btn_clients
            // 
            this.btn_clients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clients.Location = new System.Drawing.Point(47, 283);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(217, 94);
            this.btn_clients.TabIndex = 2;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_commandes
            // 
            this.btn_commandes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_commandes.Location = new System.Drawing.Point(540, 283);
            this.btn_commandes.Name = "btn_commandes";
            this.btn_commandes.Size = new System.Drawing.Size(217, 94);
            this.btn_commandes.TabIndex = 3;
            this.btn_commandes.Text = "Commandes";
            this.btn_commandes.UseVisualStyleBackColor = true;
            this.btn_commandes.Click += new System.EventHandler(this.btn_commandes_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_stats.Location = new System.Drawing.Point(540, 183);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(217, 94);
            this.btn_stats.TabIndex = 4;
            this.btn_stats.Text = "Statistiques";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransConnectForm.Properties.Resources.TransConnect_banniere1;
            this.pictureBox1.Location = new System.Drawing.Point(47, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_garage
            // 
            this.btn_garage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_garage.Location = new System.Drawing.Point(296, 283);
            this.btn_garage.Name = "btn_garage";
            this.btn_garage.Size = new System.Drawing.Size(217, 94);
            this.btn_garage.TabIndex = 3;
            this.btn_garage.Text = "Garage";
            this.btn_garage.UseVisualStyleBackColor = true;
            this.btn_garage.Click += new System.EventHandler(this.btn_garage_Click);
            // 
            // btn_Gestion
            // 
            this.btn_Gestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Gestion.Location = new System.Drawing.Point(296, 183);
            this.btn_Gestion.Name = "btn_Gestion";
            this.btn_Gestion.Size = new System.Drawing.Size(217, 94);
            this.btn_Gestion.TabIndex = 4;
            this.btn_Gestion.Text = "Gestion des fichiers";
            this.btn_Gestion.UseVisualStyleBackColor = true;
            this.btn_Gestion.Click += new System.EventHandler(this.btn_GestionSauvegardes_Click);
            // 
            // Formulaire_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Gestion);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_garage);
            this.Controls.Add(this.btn_commandes);
            this.Controls.Add(this.btn_clients);
            this.Controls.Add(this.btn_Personnel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulaire_principal";
            this.Text = "Formulaire principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Personnel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button btn_clients;
        private Button btn_commandes;
        private Button btn_stats;
        private PictureBox pictureBox1;
        private Button btn_garage;
        private Button btn_Gestion;
    }
}