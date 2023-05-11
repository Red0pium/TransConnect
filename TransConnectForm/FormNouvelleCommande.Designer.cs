namespace TransConnectForm
{
    partial class FormNouvelleCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNouvelleCommande));
            this.Calendrier = new System.Windows.Forms.MonthCalendar();
            this.cbBox_Vehicule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dispo = new System.Windows.Forms.Button();
            this.tableauVehicules = new System.Windows.Forms.DataGridView();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableauVehicules)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendrier
            // 
            this.Calendrier.Location = new System.Drawing.Point(4, 18);
            this.Calendrier.MaxSelectionCount = 1;
            this.Calendrier.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.TabIndex = 8;
            this.Calendrier.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendrier_DateSelected);
            // 
            // cbBox_Vehicule
            // 
            this.cbBox_Vehicule.FormattingEnabled = true;
            this.cbBox_Vehicule.Items.AddRange(new object[] {
            "Camion benne",
            "Camion citerne",
            "Camion frigorifique",
            "Camionnette",
            "Car"});
            this.cbBox_Vehicule.Location = new System.Drawing.Point(129, 248);
            this.cbBox_Vehicule.Name = "cbBox_Vehicule";
            this.cbBox_Vehicule.Size = new System.Drawing.Size(137, 28);
            this.cbBox_Vehicule.TabIndex = 9;
            this.cbBox_Vehicule.SelectedIndexChanged += new System.EventHandler(this.cbBox_Vehicule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type de vehicule";
            // 
            // btn_Dispo
            // 
            this.btn_Dispo.Location = new System.Drawing.Point(4, 292);
            this.btn_Dispo.Name = "btn_Dispo";
            this.btn_Dispo.Size = new System.Drawing.Size(262, 98);
            this.btn_Dispo.TabIndex = 11;
            this.btn_Dispo.Text = "Voir les \"\" disponible le \"\"";
            this.btn_Dispo.UseVisualStyleBackColor = true;
            this.btn_Dispo.Click += new System.EventHandler(this.btn_Dispo_Click);
            // 
            // tableauVehicules
            // 
            this.tableauVehicules.AllowUserToAddRows = false;
            this.tableauVehicules.AllowUserToDeleteRows = false;
            this.tableauVehicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauVehicules.Location = new System.Drawing.Point(278, 18);
            this.tableauVehicules.Name = "tableauVehicules";
            this.tableauVehicules.ReadOnly = true;
            this.tableauVehicules.RowHeadersWidth = 51;
            this.tableauVehicules.RowTemplate.Height = 29;
            this.tableauVehicules.Size = new System.Drawing.Size(516, 207);
            this.tableauVehicules.TabIndex = 12;
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(398, 292);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(285, 98);
            this.btn_Nouveau.TabIndex = 11;
            this.btn_Nouveau.Text = "Nouvelle commande avec le vehicule et la date selectionnée";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // FormNouvelleCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableauVehicules);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Dispo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBox_Vehicule);
            this.Controls.Add(this.Calendrier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNouvelleCommande";
            this.Text = "Nouvelle commande";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNouvelleCommande_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tableauVehicules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar Calendrier;
        private ComboBox cbBox_Vehicule;
        private Label label1;
        private Button btn_Dispo;
        private DataGridView tableauVehicules;
        private Button btn_Nouveau;
    }
}