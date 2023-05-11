namespace TransConnectForm
{
    partial class FormChemin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChemin));
            this.txt_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_text
            // 
            this.txt_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_text.Location = new System.Drawing.Point(0, 0);
            this.txt_text.Name = "txt_text";
            this.txt_text.ReadOnly = true;
            this.txt_text.Size = new System.Drawing.Size(800, 61);
            this.txt_text.TabIndex = 0;
            this.txt_text.Text = "";
            // 
            // FormChemin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 61);
            this.Controls.Add(this.txt_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChemin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChemin";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox txt_text;
    }
}