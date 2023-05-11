namespace TransConnectForm
{
    partial class FormCommandeCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandeCar));
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
            this.lbl_NombrePassager = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NouvelleCommande
            // 
            this.btn_NouvelleCommande.Location = new System.Drawing.Point(300, 245);
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
            this.label8.Location = new System.Drawing.Point(332, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(379, 93);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(79, 20);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "jj/mm/aaa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Chauffeur";
            // 
            // lbl_ChauffeurInfo
            // 
            this.lbl_ChauffeurInfo.AutoSize = true;
            this.lbl_ChauffeurInfo.Location = new System.Drawing.Point(379, 62);
            this.lbl_ChauffeurInfo.Name = "lbl_ChauffeurInfo";
            this.lbl_ChauffeurInfo.Size = new System.Drawing.Size(97, 20);
            this.lbl_ChauffeurInfo.TabIndex = 23;
            this.lbl_ChauffeurInfo.Text = "Prenom Nom";
            // 
            // lbl_ClientInfo
            // 
            this.lbl_ClientInfo.AutoSize = true;
            this.lbl_ClientInfo.Location = new System.Drawing.Point(379, 30);
            this.lbl_ClientInfo.Name = "lbl_ClientInfo";
            this.lbl_ClientInfo.Size = new System.Drawing.Size(97, 20);
            this.lbl_ClientInfo.TabIndex = 24;
            this.lbl_ClientInfo.Text = "Prenom Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Point d\'arrivée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Point de départ";
            // 
            // cbBox_PointB
            // 
            this.cbBox_PointB.FormattingEnabled = true;
            this.cbBox_PointB.Location = new System.Drawing.Point(379, 199);
            this.cbBox_PointB.Name = "cbBox_PointB";
            this.cbBox_PointB.Size = new System.Drawing.Size(182, 28);
            this.cbBox_PointB.TabIndex = 18;
            // 
            // cbBox_PointA
            // 
            this.cbBox_PointA.FormattingEnabled = true;
            this.cbBox_PointA.Location = new System.Drawing.Point(379, 156);
            this.cbBox_PointA.Name = "cbBox_PointA";
            this.cbBox_PointA.Size = new System.Drawing.Size(182, 28);
            this.cbBox_PointA.TabIndex = 19;
            // 
            // lbl_NombrePassager
            // 
            this.lbl_NombrePassager.AutoSize = true;
            this.lbl_NombrePassager.Location = new System.Drawing.Point(379, 124);
            this.lbl_NombrePassager.Name = "lbl_NombrePassager";
            this.lbl_NombrePassager.Size = new System.Drawing.Size(25, 20);
            this.lbl_NombrePassager.TabIndex = 21;
            this.lbl_NombrePassager.Text = "35";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre de place";
            // 
            // FormCommandeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NouvelleCommande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NombrePassager);
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
            this.Name = "FormCommandeCar";
            this.Text = "Nouvelle commande : Car";
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
        private Label lbl_NombrePassager;
        private Label label2;
    }
}