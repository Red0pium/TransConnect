namespace TransConnectForm
{
    partial class FormCommandeCamionnette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandeCamionnette));
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
            this.SuspendLayout();
            // 
            // btn_NouvelleCommande
            // 
            this.btn_NouvelleCommande.Location = new System.Drawing.Point(299, 215);
            this.btn_NouvelleCommande.Name = "btn_NouvelleCommande";
            this.btn_NouvelleCommande.Size = new System.Drawing.Size(230, 76);
            this.btn_NouvelleCommande.TabIndex = 28;
            this.btn_NouvelleCommande.Text = "Créer une nouvelle commande";
            this.btn_NouvelleCommande.UseVisualStyleBackColor = true;
            this.btn_NouvelleCommande.Click += new System.EventHandler(this.btn_NouvelleCommande_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(378, 90);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(79, 20);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "jj/mm/aaa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Chauffeur";
            // 
            // lbl_ChauffeurInfo
            // 
            this.lbl_ChauffeurInfo.AutoSize = true;
            this.lbl_ChauffeurInfo.Location = new System.Drawing.Point(378, 59);
            this.lbl_ChauffeurInfo.Name = "lbl_ChauffeurInfo";
            this.lbl_ChauffeurInfo.Size = new System.Drawing.Size(97, 20);
            this.lbl_ChauffeurInfo.TabIndex = 23;
            this.lbl_ChauffeurInfo.Text = "Prenom Nom";
            // 
            // lbl_ClientInfo
            // 
            this.lbl_ClientInfo.AutoSize = true;
            this.lbl_ClientInfo.Location = new System.Drawing.Point(378, 27);
            this.lbl_ClientInfo.Name = "lbl_ClientInfo";
            this.lbl_ClientInfo.Size = new System.Drawing.Size(97, 20);
            this.lbl_ClientInfo.TabIndex = 24;
            this.lbl_ClientInfo.Text = "Prenom Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Point d\'arrivée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Point de départ";
            // 
            // cbBox_PointB
            // 
            this.cbBox_PointB.FormattingEnabled = true;
            this.cbBox_PointB.Location = new System.Drawing.Point(378, 169);
            this.cbBox_PointB.Name = "cbBox_PointB";
            this.cbBox_PointB.Size = new System.Drawing.Size(182, 28);
            this.cbBox_PointB.TabIndex = 18;
            // 
            // cbBox_PointA
            // 
            this.cbBox_PointA.FormattingEnabled = true;
            this.cbBox_PointA.Location = new System.Drawing.Point(378, 126);
            this.cbBox_PointA.Name = "cbBox_PointA";
            this.cbBox_PointA.Size = new System.Drawing.Size(182, 28);
            this.cbBox_PointA.TabIndex = 19;
            // 
            // FormCommandeCamionnette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NouvelleCommande);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ChauffeurInfo);
            this.Controls.Add(this.lbl_ClientInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBox_PointB);
            this.Controls.Add(this.cbBox_PointA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommandeCamionnette";
            this.Text = "Nouvelle commande : Camionnette";
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
    }
}