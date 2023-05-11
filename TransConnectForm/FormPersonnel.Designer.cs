namespace TransConnectForm
{
    partial class FormPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonnel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_retour = new System.Windows.Forms.Button();
            this.TableauPersonnel = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_sauvegarde = new System.Windows.Forms.Button();
            this.btn_Recruter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Renvoi = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableauPersonnel)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1265, 28);
            this.menuStrip1.TabIndex = 2;
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
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click_1);
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
            this.btn_retour.Location = new System.Drawing.Point(292, 271);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(291, 94);
            this.btn_retour.TabIndex = 4;
            this.btn_retour.Text = "Retour au formulaire principal";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // TableauPersonnel
            // 
            this.TableauPersonnel.AllowUserToDeleteRows = false;
            this.TableauPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauPersonnel.Location = new System.Drawing.Point(292, 31);
            this.TableauPersonnel.Name = "TableauPersonnel";
            this.TableauPersonnel.RowHeadersWidth = 51;
            this.TableauPersonnel.RowTemplate.Height = 29;
            this.TableauPersonnel.Size = new System.Drawing.Size(955, 89);
            this.TableauPersonnel.TabIndex = 9;
            this.TableauPersonnel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableauPersonnel_CellValueChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(30, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(233, 334);
            this.treeView1.TabIndex = 10;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // btn_sauvegarde
            // 
            this.btn_sauvegarde.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sauvegarde.Location = new System.Drawing.Point(956, 271);
            this.btn_sauvegarde.Name = "btn_sauvegarde";
            this.btn_sauvegarde.Size = new System.Drawing.Size(291, 94);
            this.btn_sauvegarde.TabIndex = 4;
            this.btn_sauvegarde.Text = "Sauvegarder les modifications";
            this.btn_sauvegarde.UseVisualStyleBackColor = true;
            this.btn_sauvegarde.Click += new System.EventHandler(this.btn_sauvegarde_Click);
            // 
            // btn_Recruter
            // 
            this.btn_Recruter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Recruter.Location = new System.Drawing.Point(292, 146);
            this.btn_Recruter.Name = "btn_Recruter";
            this.btn_Recruter.Size = new System.Drawing.Size(291, 94);
            this.btn_Recruter.TabIndex = 4;
            this.btn_Recruter.Text = "Recruter un nouveau salarié";
            this.btn_Recruter.UseVisualStyleBackColor = true;
            this.btn_Recruter.Click += new System.EventHandler(this.btn_Recruter_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(627, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualiser l\'arbre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FormPersonnel_Load);
            // 
            // btn_Renvoi
            // 
            this.btn_Renvoi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Renvoi.Location = new System.Drawing.Point(627, 146);
            this.btn_Renvoi.Name = "btn_Renvoi";
            this.btn_Renvoi.Size = new System.Drawing.Size(291, 94);
            this.btn_Renvoi.TabIndex = 4;
            this.btn_Renvoi.Text = "Renvoyer le salarié selectionné";
            this.btn_Renvoi.UseVisualStyleBackColor = true;
            this.btn_Renvoi.Click += new System.EventHandler(this.btn_Renvoi_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Replace.Location = new System.Drawing.Point(956, 146);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(291, 94);
            this.btn_Replace.TabIndex = 4;
            this.btn_Replace.Text = "Remplacer le salarié selectionné";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(510, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 47);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Afin de visualiser ou modifier les attributs d\'un salarié, merci de double clique" +
    "r sur celui-ci ";
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 377);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.TableauPersonnel);
            this.Controls.Add(this.btn_Recruter);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.btn_Renvoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sauvegarde);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonnel";
            this.Text = "Personnel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonnelForm_FormClosed);
            this.Load += new System.EventHandler(this.FormPersonnel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableauPersonnel)).EndInit();
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
        private DataGridView TableauPersonnel;
        private TreeView treeView1;
        private Button btn_sauvegarde;
        private Button btn_Recruter;
        private Button button1;
        private Button btn_Renvoi;
        private Button btn_Replace;
        private TextBox textBox1;
    }
}