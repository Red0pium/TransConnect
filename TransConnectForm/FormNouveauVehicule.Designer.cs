namespace TransConnectForm
{
    partial class FormNouveauVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNouveauVehicule));
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.lbl_Volume1 = new System.Windows.Forms.Label();
            this.Box_Volume = new System.Windows.Forms.TextBox();
            this.lbl_Volume2 = new System.Windows.Forms.Label();
            this.Box_plaqueImmatriculation3 = new System.Windows.Forms.TextBox();
            this.Box_plaqueImmatriculation2 = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.Box_plaqueImmatriculation1 = new System.Windows.Forms.TextBox();
            this.lbl_Nss = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBox_TypeDeVehicule = new System.Windows.Forms.ComboBox();
            this.lbl_CamionCiterne1 = new System.Windows.Forms.Label();
            this.cbBox_TypeDeCuve = new System.Windows.Forms.ComboBox();
            this.Box_nbPlace = new System.Windows.Forms.TextBox();
            this.lbl_nbPlace1 = new System.Windows.Forms.Label();
            this.lbl_nbPlace2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ajout
            // 
            this.btn_Ajout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Ajout.Location = new System.Drawing.Point(248, 240);
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.Size = new System.Drawing.Size(281, 94);
            this.btn_Ajout.TabIndex = 41;
            this.btn_Ajout.Text = "Ajouter le vehicule";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            this.btn_Ajout.Click += new System.EventHandler(this.btn_Ajout_Click);
            // 
            // lbl_Volume1
            // 
            this.lbl_Volume1.AutoSize = true;
            this.lbl_Volume1.Location = new System.Drawing.Point(234, 112);
            this.lbl_Volume1.Name = "lbl_Volume1";
            this.lbl_Volume1.Size = new System.Drawing.Size(59, 20);
            this.lbl_Volume1.TabIndex = 32;
            this.lbl_Volume1.Text = "Volume";
            // 
            // Box_Volume
            // 
            this.Box_Volume.Location = new System.Drawing.Point(299, 109);
            this.Box_Volume.Name = "Box_Volume";
            this.Box_Volume.Size = new System.Drawing.Size(171, 27);
            this.Box_Volume.TabIndex = 29;
            // 
            // lbl_Volume2
            // 
            this.lbl_Volume2.AutoSize = true;
            this.lbl_Volume2.Location = new System.Drawing.Point(476, 112);
            this.lbl_Volume2.Name = "lbl_Volume2";
            this.lbl_Volume2.Size = new System.Drawing.Size(44, 20);
            this.lbl_Volume2.TabIndex = 28;
            this.lbl_Volume2.Text = "Litres";
            // 
            // Box_plaqueImmatriculation3
            // 
            this.Box_plaqueImmatriculation3.Location = new System.Drawing.Point(442, 14);
            this.Box_plaqueImmatriculation3.Name = "Box_plaqueImmatriculation3";
            this.Box_plaqueImmatriculation3.Size = new System.Drawing.Size(43, 27);
            this.Box_plaqueImmatriculation3.TabIndex = 27;
            // 
            // Box_plaqueImmatriculation2
            // 
            this.Box_plaqueImmatriculation2.Location = new System.Drawing.Point(362, 14);
            this.Box_plaqueImmatriculation2.Name = "Box_plaqueImmatriculation2";
            this.Box_plaqueImmatriculation2.Size = new System.Drawing.Size(62, 27);
            this.Box_plaqueImmatriculation2.TabIndex = 25;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(174, 65);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(119, 20);
            this.lbl_Nom.TabIndex = 24;
            this.lbl_Nom.Text = "Type de vehicule";
            // 
            // Box_plaqueImmatriculation1
            // 
            this.Box_plaqueImmatriculation1.Location = new System.Drawing.Point(299, 14);
            this.Box_plaqueImmatriculation1.Name = "Box_plaqueImmatriculation1";
            this.Box_plaqueImmatriculation1.Size = new System.Drawing.Size(43, 27);
            this.Box_plaqueImmatriculation1.TabIndex = 23;
            // 
            // lbl_Nss
            // 
            this.lbl_Nss.AutoSize = true;
            this.lbl_Nss.Location = new System.Drawing.Point(118, 17);
            this.lbl_Nss.Name = "lbl_Nss";
            this.lbl_Nss.Size = new System.Drawing.Size(175, 20);
            this.lbl_Nss.TabIndex = 22;
            this.lbl_Nss.Text = "Plaque d\'immatriculation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "-";
            // 
            // cbBox_TypeDeVehicule
            // 
            this.cbBox_TypeDeVehicule.FormattingEnabled = true;
            this.cbBox_TypeDeVehicule.Items.AddRange(new object[] {
            "Camion benne",
            "Camion citerne",
            "Camion frigorifique",
            "Camionnette",
            "Car"});
            this.cbBox_TypeDeVehicule.Location = new System.Drawing.Point(299, 62);
            this.cbBox_TypeDeVehicule.Name = "cbBox_TypeDeVehicule";
            this.cbBox_TypeDeVehicule.Size = new System.Drawing.Size(220, 28);
            this.cbBox_TypeDeVehicule.TabIndex = 42;
            this.cbBox_TypeDeVehicule.SelectedIndexChanged += new System.EventHandler(this.cbBox_TypeDeVehicule_SelectedIndexChanged);
            // 
            // lbl_CamionCiterne1
            // 
            this.lbl_CamionCiterne1.AutoSize = true;
            this.lbl_CamionCiterne1.Location = new System.Drawing.Point(198, 161);
            this.lbl_CamionCiterne1.Name = "lbl_CamionCiterne1";
            this.lbl_CamionCiterne1.Size = new System.Drawing.Size(95, 20);
            this.lbl_CamionCiterne1.TabIndex = 24;
            this.lbl_CamionCiterne1.Text = "Type de cuve";
            // 
            // cbBox_TypeDeCuve
            // 
            this.cbBox_TypeDeCuve.FormattingEnabled = true;
            this.cbBox_TypeDeCuve.Items.AddRange(new object[] {
            "Liquide",
            "Gazeux"});
            this.cbBox_TypeDeCuve.Location = new System.Drawing.Point(299, 158);
            this.cbBox_TypeDeCuve.Name = "cbBox_TypeDeCuve";
            this.cbBox_TypeDeCuve.Size = new System.Drawing.Size(220, 28);
            this.cbBox_TypeDeCuve.TabIndex = 42;
            // 
            // Box_nbPlace
            // 
            this.Box_nbPlace.Location = new System.Drawing.Point(299, 109);
            this.Box_nbPlace.Name = "Box_nbPlace";
            this.Box_nbPlace.Size = new System.Drawing.Size(164, 27);
            this.Box_nbPlace.TabIndex = 29;
            // 
            // lbl_nbPlace1
            // 
            this.lbl_nbPlace1.AutoSize = true;
            this.lbl_nbPlace1.Location = new System.Drawing.Point(168, 112);
            this.lbl_nbPlace1.Name = "lbl_nbPlace1";
            this.lbl_nbPlace1.Size = new System.Drawing.Size(125, 20);
            this.lbl_nbPlace1.TabIndex = 32;
            this.lbl_nbPlace1.Text = "Nombre de place";
            // 
            // lbl_nbPlace2
            // 
            this.lbl_nbPlace2.AutoSize = true;
            this.lbl_nbPlace2.Location = new System.Drawing.Point(469, 112);
            this.lbl_nbPlace2.Name = "lbl_nbPlace2";
            this.lbl_nbPlace2.Size = new System.Drawing.Size(51, 20);
            this.lbl_nbPlace2.TabIndex = 28;
            this.lbl_nbPlace2.Text = "places";
            // 
            // FormNouveauVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBox_TypeDeCuve);
            this.Controls.Add(this.cbBox_TypeDeVehicule);
            this.Controls.Add(this.btn_Ajout);
            this.Controls.Add(this.lbl_Volume1);
            this.Controls.Add(this.Box_nbPlace);
            this.Controls.Add(this.Box_Volume);
            this.Controls.Add(this.Box_plaqueImmatriculation3);
            this.Controls.Add(this.lbl_CamionCiterne1);
            this.Controls.Add(this.Box_plaqueImmatriculation2);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Box_plaqueImmatriculation1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Nss);
            this.Controls.Add(this.lbl_nbPlace1);
            this.Controls.Add(this.lbl_Volume2);
            this.Controls.Add(this.lbl_nbPlace2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNouveauVehicule";
            this.Text = "FormNouveauVehicule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNouveauVehicule_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Ajout;
        private Label lbl_Volume1;
        private TextBox Box_Volume;
        private Label lbl_Volume2;
        private TextBox Box_plaqueImmatriculation3;
        private TextBox Box_plaqueImmatriculation2;
        private Label lbl_Nom;
        private TextBox Box_plaqueImmatriculation1;
        private Label lbl_Nss;
        private Label label1;
        private Label label5;
        private ComboBox cbBox_TypeDeVehicule;
        private Label lbl_CamionCiterne1;
        private ComboBox cbBox_TypeDeCuve;
        private TextBox Box_nbPlace;
        private Label lbl_nbPlace1;
        private Label lbl_nbPlace2;
    }
}