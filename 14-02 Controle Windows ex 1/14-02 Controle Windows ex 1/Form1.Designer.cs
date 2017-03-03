namespace _14_02_Controle_Windows_ex_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbm3 = new System.Windows.Forms.Label();
            this.lbLitres = new System.Windows.Forms.Label();
            this.mtbm3 = new System.Windows.Forms.MaskedTextBox();
            this.mtbLitre = new System.Windows.Forms.MaskedTextBox();
            this.bConv = new System.Windows.Forms.Button();
            this.bConvInverse = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbm3);
            this.panel1.Controls.Add(this.lbLitres);
            this.panel1.Controls.Add(this.mtbm3);
            this.panel1.Controls.Add(this.mtbLitre);
            this.panel1.Controls.Add(this.bConv);
            this.panel1.Controls.Add(this.bConvInverse);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 132);
            this.panel1.TabIndex = 0;
            // 
            // lbm3
            // 
            this.lbm3.AutoSize = true;
            this.lbm3.Location = new System.Drawing.Point(220, 90);
            this.lbm3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbm3.Name = "lbm3";
            this.lbm3.Size = new System.Drawing.Size(18, 13);
            this.lbm3.TabIndex = 5;
            this.lbm3.Text = "m³";
            // 
            // lbLitres
            // 
            this.lbLitres.AutoSize = true;
            this.lbLitres.Location = new System.Drawing.Point(218, 20);
            this.lbLitres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLitres.Name = "lbLitres";
            this.lbLitres.Size = new System.Drawing.Size(32, 13);
            this.lbLitres.TabIndex = 4;
            this.lbLitres.Text = "Litres";
            // 
            // mtbm3
            // 
            this.mtbm3.Location = new System.Drawing.Point(46, 90);
            this.mtbm3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbm3.Name = "mtbm3";
            this.mtbm3.Size = new System.Drawing.Size(132, 20);
            this.mtbm3.TabIndex = 3;
            // 
            // mtbLitre
            // 
            this.mtbLitre.Location = new System.Drawing.Point(46, 17);
            this.mtbLitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbLitre.Name = "mtbLitre";
            this.mtbLitre.Size = new System.Drawing.Size(132, 20);
            this.mtbLitre.TabIndex = 2;
            // 
            // bConv
            // 
            this.bConv.Location = new System.Drawing.Point(78, 53);
            this.bConv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bConv.Name = "bConv";
            this.bConv.Size = new System.Drawing.Size(69, 19);
            this.bConv.TabIndex = 1;
            this.bConv.Text = "Conversion";
            this.bConv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.bConv, "Doit etre compris entre 4 et 7 carateres maximum.");
            this.bConv.UseVisualStyleBackColor = true;
            this.bConv.Click += new System.EventHandler(this.bConv_Click);
            // 
            // bConvInverse
            // 
            this.bConvInverse.Location = new System.Drawing.Point(222, 53);
            this.bConvInverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bConvInverse.Name = "bConvInverse";
            this.bConvInverse.Size = new System.Drawing.Size(124, 19);
            this.bConvInverse.TabIndex = 0;
            this.bConvInverse.Text = "Conversion inverse";
            this.bConvInverse.UseVisualStyleBackColor = true;
            this.bConvInverse.Click += new System.EventHandler(this.bConvInverse_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(56, 158);
            this.bAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(69, 19);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Ajouter";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSave
            // 
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(158, 158);
            this.bSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(69, 19);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Sauver";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Enabled = false;
            this.llbOpen.Location = new System.Drawing.Point(262, 162);
            this.llbOpen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(81, 13);
            this.llbOpen.TabIndex = 8;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "Ouvrir un fichier";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(45, 205);
            this.rtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(322, 172);
            this.rtb.TabIndex = 9;
            this.rtb.Text = "";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 400);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.llbOpen);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Conversion des litres en m³";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbm3;
        private System.Windows.Forms.Label lbLitres;
        private System.Windows.Forms.MaskedTextBox mtbm3;
        private System.Windows.Forms.MaskedTextBox mtbLitre;
        private System.Windows.Forms.Button bConv;
        private System.Windows.Forms.Button bConvInverse;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

