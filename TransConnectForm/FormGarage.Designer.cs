namespace TransConnectForm
{
    partial class FormGarage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGarage));
            this.TableauSauvegardes = new System.Windows.Forms.DataGridView();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_charge = new System.Windows.Forms.Button();
            this.btn_suppression = new System.Windows.Forms.Button();
            this.btn_Actualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableauSauvegardes)).BeginInit();
            this.SuspendLayout();
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
            this.TableauSauvegardes.TabIndex = 10;
            // 
            // btn_Retour
            // 
            this.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Retour.Location = new System.Drawing.Point(39, 344);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(170, 94);
            this.btn_Retour.TabIndex = 7;
            this.btn_Retour.Text = "Retour au formulaire principal";
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // btn_charge
            // 
            this.btn_charge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_charge.Location = new System.Drawing.Point(417, 344);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(170, 94);
            this.btn_charge.TabIndex = 8;
            this.btn_charge.Text = "Nouveau vehicule";
            this.btn_charge.UseVisualStyleBackColor = true;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // btn_suppression
            // 
            this.btn_suppression.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_suppression.Location = new System.Drawing.Point(606, 344);
            this.btn_suppression.Name = "btn_suppression";
            this.btn_suppression.Size = new System.Drawing.Size(170, 94);
            this.btn_suppression.TabIndex = 9;
            this.btn_suppression.Text = "Supprimer le vehicule sélectionné";
            this.btn_suppression.UseVisualStyleBackColor = true;
            this.btn_suppression.Click += new System.EventHandler(this.btn_suppression_Click);
            // 
            // btn_Actualiser
            // 
            this.btn_Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Actualiser.Location = new System.Drawing.Point(228, 344);
            this.btn_Actualiser.Name = "btn_Actualiser";
            this.btn_Actualiser.Size = new System.Drawing.Size(170, 94);
            this.btn_Actualiser.TabIndex = 7;
            this.btn_Actualiser.Text = "Actualiser le tableau";
            this.btn_Actualiser.UseVisualStyleBackColor = true;
            this.btn_Actualiser.Click += new System.EventHandler(this.btn_Actualiser_Click);
            // 
            // FormGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableauSauvegardes);
            this.Controls.Add(this.btn_Actualiser);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.btn_suppression);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGarage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGarage_FormClosed);
            this.Shown += new System.EventHandler(this.FormGarage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TableauSauvegardes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView TableauSauvegardes;
        private Button btn_Retour;
        private Button btn_charge;
        private Button btn_suppression;
        private Button btn_Actualiser;
    }
}