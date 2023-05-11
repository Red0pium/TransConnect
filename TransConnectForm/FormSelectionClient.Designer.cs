namespace TransConnectForm
{
    partial class FormSelectionClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectionClient));
            this.TableauClient = new System.Windows.Forms.DataGridView();
            this.btn_Validation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableauClient)).BeginInit();
            this.SuspendLayout();
            // 
            // TableauClient
            // 
            this.TableauClient.AllowUserToAddRows = false;
            this.TableauClient.AllowUserToDeleteRows = false;
            this.TableauClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableauClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauClient.Location = new System.Drawing.Point(12, 12);
            this.TableauClient.Name = "TableauClient";
            this.TableauClient.ReadOnly = true;
            this.TableauClient.RowHeadersWidth = 51;
            this.TableauClient.RowTemplate.Height = 29;
            this.TableauClient.Size = new System.Drawing.Size(776, 324);
            this.TableauClient.TabIndex = 3;
            // 
            // btn_Validation
            // 
            this.btn_Validation.Location = new System.Drawing.Point(245, 342);
            this.btn_Validation.Name = "btn_Validation";
            this.btn_Validation.Size = new System.Drawing.Size(316, 96);
            this.btn_Validation.TabIndex = 2;
            this.btn_Validation.Text = "Valider la selection";
            this.btn_Validation.UseVisualStyleBackColor = true;
            this.btn_Validation.Click += new System.EventHandler(this.btn_Validation_Click);
            // 
            // FormSelectionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableauClient);
            this.Controls.Add(this.btn_Validation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectionClient";
            this.Text = "FormSelectionClient";
            ((System.ComponentModel.ISupportInitialize)(this.TableauClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView TableauClient;
        private Button btn_Validation;
    }
}