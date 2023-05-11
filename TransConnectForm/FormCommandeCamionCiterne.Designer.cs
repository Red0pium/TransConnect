namespace TransConnectForm
{
    partial class FormCommandeCamionCiterne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandeCamionCiterne));
            this.btn_NouvelleCommande = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ChauffeurInfo = new System.Windows.Forms.Label();
            this.lbl_ClientInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBox_PointB = new System.Windows.Forms.ComboBox();
            this.cbBox_PointA = new System.Windows.Forms.ComboBox();
            this.lbl_TypeFluide = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NouvelleCommande
            // 
            this.btn_NouvelleCommande.Location = new System.Drawing.Point(298, 272);
            this.btn_NouvelleCommande.Name = "btn_NouvelleCommande";
            this.btn_NouvelleCommande.Size = new System.Drawing.Size(230, 76);
            this.btn_NouvelleCommande.TabIndex = 17;
            this.btn_NouvelleCommande.Text = "Créer une nouvelle commande";
            this.btn_NouvelleCommande.UseVisualStyleBackColor = true;
            this.btn_NouvelleCommande.Click += new System.EventHandler(this.btn_NouvelleCommande_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(377, 93);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(79, 20);
            this.lbl_Date.TabIndex = 9;
            this.lbl_Date.Text = "jj/mm/aaa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chauffeur";
            // 
            // lbl_ChauffeurInfo
            // 
            this.lbl_ChauffeurInfo.AutoSize = true;
            this.lbl_ChauffeurInfo.Location = new System.Drawing.Point(377, 62);
            this.lbl_ChauffeurInfo.Name = "lbl_ChauffeurInfo";
            this.lbl_ChauffeurInfo.Size = new System.Drawing.Size(97, 20);
            this.lbl_ChauffeurInfo.TabIndex = 11;
            this.lbl_ChauffeurInfo.Text = "Prenom Nom";
            // 
            // lbl_ClientInfo
            // 
            this.lbl_ClientInfo.AutoSize = true;
            this.lbl_ClientInfo.Location = new System.Drawing.Point(377, 30);
            this.lbl_ClientInfo.Name = "lbl_ClientInfo";
            this.lbl_ClientInfo.Size = new System.Drawing.Size(97, 20);
            this.lbl_ClientInfo.TabIndex = 12;
            this.lbl_ClientInfo.Text = "Prenom Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Point d\'arrivée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Point de départ";
            // 
            // cbBox_PointB
            // 
            this.cbBox_PointB.FormattingEnabled = true;
            this.cbBox_PointB.Location = new System.Drawing.Point(377, 226);
            this.cbBox_PointB.Name = "cbBox_PointB";
            this.cbBox_PointB.Size = new System.Drawing.Size(182, 28);
            this.cbBox_PointB.TabIndex = 4;
            // 
            // cbBox_PointA
            // 
            this.cbBox_PointA.FormattingEnabled = true;
            this.cbBox_PointA.Location = new System.Drawing.Point(377, 183);
            this.cbBox_PointA.Name = "cbBox_PointA";
            this.cbBox_PointA.Size = new System.Drawing.Size(182, 28);
            this.cbBox_PointA.TabIndex = 5;
            // 
            // lbl_TypeFluide
            // 
            this.lbl_TypeFluide.AutoSize = true;
            this.lbl_TypeFluide.Location = new System.Drawing.Point(377, 123);
            this.lbl_TypeFluide.Name = "lbl_TypeFluide";
            this.lbl_TypeFluide.Size = new System.Drawing.Size(55, 20);
            this.lbl_TypeFluide.TabIndex = 11;
            this.lbl_TypeFluide.Text = "liquide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type de fluide";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Location = new System.Drawing.Point(377, 154);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(60, 20);
            this.lbl_Volume.TabIndex = 9;
            this.lbl_Volume.Text = "30000 L";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Volume";
            // 
            // FormCommandeCamionCiterne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NouvelleCommande);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Volume);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TypeFluide);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ChauffeurInfo);
            this.Controls.Add(this.lbl_ClientInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBox_PointB);
            this.Controls.Add(this.cbBox_PointA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommandeCamionCiterne";
            this.Text = "Nouvelle commande : Camion Citerne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_NouvelleCommande;
        private Label label8;
        private Label lbl_Date;
        private Label label6;
        private Label lbl_ChauffeurInfo;
        private Label lbl_ClientInfo;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbBox_PointB;
        private ComboBox cbBox_PointA;
        private Label lbl_TypeFluide;
        private Label label2;
        private Label lbl_Volume;
        private Label label9;
    }
}