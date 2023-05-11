namespace TransConnectForm
{
    partial class FormStatistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistiques));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_retour = new System.Windows.Forms.Button();
            this.Tableau = new System.Windows.Forms.DataGridView();
            this.cbBox_StatAAfficher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Selection = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.lbl_date2 = new System.Windows.Forms.Label();
            this.lbl_clientSelect = new System.Windows.Forms.Label();
            this.lbl_clientSelect2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tableau)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
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
            this.btn_retour.Location = new System.Drawing.Point(73, 325);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(183, 94);
            this.btn_retour.TabIndex = 5;
            this.btn_retour.Text = "Retour au formulaire principal";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // Tableau
            // 
            this.Tableau.AllowUserToAddRows = false;
            this.Tableau.AllowUserToDeleteRows = false;
            this.Tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tableau.Location = new System.Drawing.Point(32, 31);
            this.Tableau.Name = "Tableau";
            this.Tableau.ReadOnly = true;
            this.Tableau.RowHeadersWidth = 51;
            this.Tableau.RowTemplate.Height = 29;
            this.Tableau.Size = new System.Drawing.Size(744, 275);
            this.Tableau.TabIndex = 6;
            // 
            // cbBox_StatAAfficher
            // 
            this.cbBox_StatAAfficher.FormattingEnabled = true;
            this.cbBox_StatAAfficher.Items.AddRange(new object[] {
            "Nombre de livraison par chauffeur",
            "Commandes selon une période de temps",
            "Moyenne des prix de commandes",
            "Liste des commandes pour un client"});
            this.cbBox_StatAAfficher.Location = new System.Drawing.Point(479, 325);
            this.cbBox_StatAAfficher.Name = "cbBox_StatAAfficher";
            this.cbBox_StatAAfficher.Size = new System.Drawing.Size(297, 28);
            this.cbBox_StatAAfficher.TabIndex = 7;
            this.cbBox_StatAAfficher.SelectedIndexChanged += new System.EventHandler(this.cbBox_StatAAfficher_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Statistique à afficher";
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Afficher.Location = new System.Drawing.Point(631, 359);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(145, 60);
            this.btn_Afficher.TabIndex = 5;
            this.btn_Afficher.Text = "Afficher la statistique";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Selection
            // 
            this.btn_Selection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Selection.Location = new System.Drawing.Point(479, 359);
            this.btn_Selection.Name = "btn_Selection";
            this.btn_Selection.Size = new System.Drawing.Size(145, 60);
            this.btn_Selection.TabIndex = 5;
            this.btn_Selection.Text = "Selectionner un client";
            this.btn_Selection.UseVisualStyleBackColor = true;
            this.btn_Selection.Click += new System.EventHandler(this.btn_SelectionClient_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 359);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(479, 390);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 27);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Location = new System.Drawing.Point(360, 362);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(113, 20);
            this.lbl_date1.TabIndex = 8;
            this.lbl_date1.Text = "Commandes du";
            // 
            // lbl_date2
            // 
            this.lbl_date2.AutoSize = true;
            this.lbl_date2.Location = new System.Drawing.Point(448, 395);
            this.lbl_date2.Name = "lbl_date2";
            this.lbl_date2.Size = new System.Drawing.Size(25, 20);
            this.lbl_date2.TabIndex = 8;
            this.lbl_date2.Text = "au";
            // 
            // lbl_clientSelect
            // 
            this.lbl_clientSelect.AutoSize = true;
            this.lbl_clientSelect.Location = new System.Drawing.Point(475, 422);
            this.lbl_clientSelect.Name = "lbl_clientSelect";
            this.lbl_clientSelect.Size = new System.Drawing.Size(133, 20);
            this.lbl_clientSelect.TabIndex = 8;
            this.lbl_clientSelect.Text = "Client sélectionné :";
            // 
            // lbl_clientSelect2
            // 
            this.lbl_clientSelect2.AutoSize = true;
            this.lbl_clientSelect2.Location = new System.Drawing.Point(603, 422);
            this.lbl_clientSelect2.Name = "lbl_clientSelect2";
            this.lbl_clientSelect2.Size = new System.Drawing.Size(114, 20);
            this.lbl_clientSelect2.TabIndex = 8;
            this.lbl_clientSelect2.Text = "Mathys Bronnec";
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_date2);
            this.Controls.Add(this.lbl_clientSelect2);
            this.Controls.Add(this.lbl_clientSelect);
            this.Controls.Add(this.lbl_date1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBox_StatAAfficher);
            this.Controls.Add(this.Tableau);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Selection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStatistiques";
            this.Text = "StatistiquesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatistiquesForm_FormClosed);
            this.Load += new System.EventHandler(this.FormStatistiques_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tableau)).EndInit();
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
        private DataGridView Tableau;
        private ComboBox cbBox_StatAAfficher;
        private Label label1;
        private Button btn_Afficher;
        private Button btn_Selection;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lbl_date1;
        private Label lbl_date2;
        private Label lbl_clientSelect;
        private Label lbl_clientSelect2;
    }
}