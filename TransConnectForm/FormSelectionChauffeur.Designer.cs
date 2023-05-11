namespace TransConnectForm
{
    partial class FormSelectionChauffeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectionChauffeur));
            this.btn_Validation = new System.Windows.Forms.Button();
            this.TableauChauffeurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableauChauffeurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Validation
            // 
            this.btn_Validation.Location = new System.Drawing.Point(245, 342);
            this.btn_Validation.Name = "btn_Validation";
            this.btn_Validation.Size = new System.Drawing.Size(316, 96);
            this.btn_Validation.TabIndex = 0;
            this.btn_Validation.Text = "Valider la selection";
            this.btn_Validation.UseVisualStyleBackColor = true;
            this.btn_Validation.Click += new System.EventHandler(this.btn_Selection_Click);
            // 
            // TableauChauffeurs
            // 
            this.TableauChauffeurs.AllowUserToAddRows = false;
            this.TableauChauffeurs.AllowUserToDeleteRows = false;
            this.TableauChauffeurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableauChauffeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauChauffeurs.Location = new System.Drawing.Point(12, 12);
            this.TableauChauffeurs.Name = "TableauChauffeurs";
            this.TableauChauffeurs.ReadOnly = true;
            this.TableauChauffeurs.RowHeadersWidth = 51;
            this.TableauChauffeurs.RowTemplate.Height = 29;
            this.TableauChauffeurs.Size = new System.Drawing.Size(776, 324);
            this.TableauChauffeurs.TabIndex = 1;
            // 
            // FormSelectionChauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableauChauffeurs);
            this.Controls.Add(this.btn_Validation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectionChauffeur";
            this.Text = "Selection chauffeur";
            ((System.ComponentModel.ISupportInitialize)(this.TableauChauffeurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Validation;
        private DataGridView TableauChauffeurs;
    }
}