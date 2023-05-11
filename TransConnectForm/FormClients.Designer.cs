namespace TransConnectForm
{
    partial class FormClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.btn_AjouterClient = new System.Windows.Forms.Button();
            this.TableauClients = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.comboBox_tri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Actualiser = new System.Windows.Forms.Button();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.btn_Modifications = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableauClients)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AjouterClient
            // 
            this.btn_AjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AjouterClient.Location = new System.Drawing.Point(339, 306);
            this.btn_AjouterClient.Name = "btn_AjouterClient";
            this.btn_AjouterClient.Size = new System.Drawing.Size(200, 94);
            this.btn_AjouterClient.TabIndex = 6;
            this.btn_AjouterClient.Text = "Ajouter un client";
            this.btn_AjouterClient.UseVisualStyleBackColor = true;
            this.btn_AjouterClient.Click += new System.EventHandler(this.btn_AjouterClient_Click);
            // 
            // TableauClients
            // 
            this.TableauClients.AllowUserToDeleteRows = false;
            this.TableauClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauClients.Location = new System.Drawing.Point(24, 31);
            this.TableauClients.Name = "TableauClients";
            this.TableauClients.RowHeadersWidth = 51;
            this.TableauClients.RowTemplate.Height = 29;
            this.TableauClients.Size = new System.Drawing.Size(1046, 258);
            this.TableauClients.TabIndex = 8;
            this.TableauClients.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableauClients_CellValueChanged);
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
            this.menuStrip1.TabIndex = 10;
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
            // btn_Retour
            // 
            this.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Retour.Location = new System.Drawing.Point(67, 306);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(200, 94);
            this.btn_Retour.TabIndex = 12;
            this.btn_Retour.Text = "Retour au formulaire principal";
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // comboBox_tri
            // 
            this.comboBox_tri.FormattingEnabled = true;
            this.comboBox_tri.Items.AddRange(new object[] {
            "Nom",
            "Ville",
            "Montant achats cumulés"});
            this.comboBox_tri.Location = new System.Drawing.Point(897, 306);
            this.comboBox_tri.Name = "comboBox_tri";
            this.comboBox_tri.Size = new System.Drawing.Size(150, 28);
            this.comboBox_tri.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trier par ";
            // 
            // btn_Actualiser
            // 
            this.btn_Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Actualiser.Location = new System.Drawing.Point(823, 340);
            this.btn_Actualiser.Name = "btn_Actualiser";
            this.btn_Actualiser.Size = new System.Drawing.Size(224, 60);
            this.btn_Actualiser.TabIndex = 6;
            this.btn_Actualiser.Text = "Actualiser";
            this.btn_Actualiser.UseVisualStyleBackColor = true;
            this.btn_Actualiser.Click += new System.EventHandler(this.btn_Actualiser_Click);
            // 
            // btn_suppr
            // 
            this.btn_suppr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_suppr.Location = new System.Drawing.Point(595, 306);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(200, 94);
            this.btn_suppr.TabIndex = 15;
            this.btn_suppr.Text = "Supprimer le(s) client(s) selectionné(s)";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
            // 
            // btn_Modifications
            // 
            this.btn_Modifications.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modifications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Modifications.ForeColor = System.Drawing.Color.Black;
            this.btn_Modifications.Location = new System.Drawing.Point(67, 422);
            this.btn_Modifications.Name = "btn_Modifications";
            this.btn_Modifications.Size = new System.Drawing.Size(472, 37);
            this.btn_Modifications.TabIndex = 16;
            this.btn_Modifications.Text = "Valider les modifications d\'attributs";
            this.btn_Modifications.UseVisualStyleBackColor = true;
            this.btn_Modifications.Click += new System.EventHandler(this.btn_Modifications_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 483);
            this.Controls.Add(this.btn_Modifications);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_tri);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TableauClients);
            this.Controls.Add(this.btn_Actualiser);
            this.Controls.Add(this.btn_AjouterClient);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClients";
            this.Text = "Gestion des clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGestionClients_FormClosed);
            this.Load += new System.EventHandler(this.FormGestionClients_Load);
            this.Shown += new System.EventHandler(this.FormGestionClients_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TableauClients)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AjouterClient;
        private DataGridView TableauClients;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button btn_Retour;
        private ComboBox comboBox_tri;
        private Label label1;
        private Button btn_Actualiser;
        private Button btn_suppr;
        private Button btn_Modifications;
    }
}