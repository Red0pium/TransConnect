namespace TransConnectForm
{
    partial class FormGestionSauvegarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionSauvegarde));
            this.btn_sauvegarde = new System.Windows.Forms.Button();
            this.btn_charge = new System.Windows.Forms.Button();
            this.TableauSauvegardes = new System.Windows.Forms.DataGridView();
            this.btn_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableauSauvegardes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sauvegarde
            // 
            this.btn_sauvegarde.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sauvegarde.Location = new System.Drawing.Point(502, 344);
            this.btn_sauvegarde.Name = "btn_sauvegarde";
            this.btn_sauvegarde.Size = new System.Drawing.Size(170, 94);
            this.btn_sauvegarde.TabIndex = 5;
            this.btn_sauvegarde.Text = "Faire une sauvegarde des fichiers";
            this.btn_sauvegarde.UseVisualStyleBackColor = true;
            this.btn_sauvegarde.Click += new System.EventHandler(this.btn_sauvegarde_Click);
            // 
            // btn_charge
            // 
            this.btn_charge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_charge.Location = new System.Drawing.Point(313, 344);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(170, 94);
            this.btn_charge.TabIndex = 5;
            this.btn_charge.Text = "Charger la sauvegarde sélectionnée";
            this.btn_charge.UseVisualStyleBackColor = true;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // TableauSauvegardes
            // 
            this.TableauSauvegardes.AllowUserToAddRows = false;
            this.TableauSauvegardes.AllowUserToDeleteRows = false;
            this.TableauSauvegardes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauSauvegardes.Location = new System.Drawing.Point(12, 12);
            this.TableauSauvegardes.Name = "TableauSauvegardes";
            this.TableauSauvegardes.ReadOnly = true;
            this.TableauSauvegardes.RowHeadersWidth = 51;
            this.TableauSauvegardes.RowTemplate.Height = 29;
            this.TableauSauvegardes.Size = new System.Drawing.Size(776, 326);
            this.TableauSauvegardes.TabIndex = 6;
            // 
            // btn_Retour
            // 
            this.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Retour.Location = new System.Drawing.Point(127, 344);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(170, 94);
            this.btn_Retour.TabIndex = 5;
            this.btn_Retour.Text = "Retour au formulaire principal";
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // FormGestionSauvegarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableauSauvegardes);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.btn_sauvegarde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionSauvegarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des sauvegardes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGestionSauvegarde_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TableauSauvegardes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_sauvegarde;
        private Button btn_charge;
        private DataGridView TableauSauvegardes;
        private Button btn_Retour;
    }
}