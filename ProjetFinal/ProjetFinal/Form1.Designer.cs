namespace ProjetFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblScn = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtScn = new System.Windows.Forms.TextBox();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.btnAjouterFournisseur = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.btnRegistre = new System.Windows.Forms.Button();
            this.btnRechercheRegistre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(55, 42);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(36, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblScn
            // 
            this.lblScn.AutoSize = true;
            this.lblScn.Location = new System.Drawing.Point(61, 158);
            this.lblScn.Name = "lblScn";
            this.lblScn.Size = new System.Drawing.Size(35, 16);
            this.lblScn.TabIndex = 2;
            this.lblScn.Text = "SCN";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(124, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtScn
            // 
            this.txtScn.Location = new System.Drawing.Point(124, 158);
            this.txtScn.Name = "txtScn";
            this.txtScn.Size = new System.Drawing.Size(100, 22);
            this.txtScn.TabIndex = 5;
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAjouterContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouterContact.Location = new System.Drawing.Point(35, 212);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(98, 50);
            this.btnAjouterContact.TabIndex = 6;
            this.btnAjouterContact.Text = "Ajouter un contact";
            this.btnAjouterContact.UseVisualStyleBackColor = false;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // btnAjouterFournisseur
            // 
            this.btnAjouterFournisseur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAjouterFournisseur.Location = new System.Drawing.Point(35, 305);
            this.btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            this.btnAjouterFournisseur.Size = new System.Drawing.Size(100, 50);
            this.btnAjouterFournisseur.TabIndex = 7;
            this.btnAjouterFournisseur.Text = "Ajouter un fournisseur";
            this.btnAjouterFournisseur.UseVisualStyleBackColor = false;
            this.btnAjouterFournisseur.Click += new System.EventHandler(this.btnAjouterFournisseur_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRechercher.Location = new System.Drawing.Point(317, 212);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(185, 50);
            this.btnRechercher.TabIndex = 8;
            this.btnRechercher.Text = "Rechercher un contact dans la bd";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAfficher.Location = new System.Drawing.Point(169, 212);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(102, 50);
            this.btnAfficher.TabIndex = 9;
            this.btnAfficher.Text = "Afficher les contacts";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 16;
            this.listBoxContacts.Location = new System.Drawing.Point(250, 39);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(241, 132);
            this.listBoxContacts.TabIndex = 10;
            // 
            // btnRegistre
            // 
            this.btnRegistre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistre.Location = new System.Drawing.Point(169, 308);
            this.btnRegistre.Name = "btnRegistre";
            this.btnRegistre.Size = new System.Drawing.Size(102, 50);
            this.btnRegistre.TabIndex = 11;
            this.btnRegistre.Text = "Registre";
            this.btnRegistre.UseVisualStyleBackColor = false;
            this.btnRegistre.Click += new System.EventHandler(this.btnRegistre_Click);
            // 
            // btnRechercheRegistre
            // 
            this.btnRechercheRegistre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRechercheRegistre.Location = new System.Drawing.Point(317, 308);
            this.btnRechercheRegistre.Name = "btnRechercheRegistre";
            this.btnRechercheRegistre.Size = new System.Drawing.Size(185, 50);
            this.btnRechercheRegistre.TabIndex = 12;
            this.btnRechercheRegistre.Text = "Rechercher un contact dans le Registre";
            this.btnRechercheRegistre.UseVisualStyleBackColor = false;
            this.btnRechercheRegistre.Click += new System.EventHandler(this.btnRechercheRegistre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRechercheRegistre);
            this.Controls.Add(this.btnRegistre);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnAjouterFournisseur);
            this.Controls.Add(this.btnAjouterContact);
            this.Controls.Add(this.txtScn);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblScn);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblScn;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtScn;
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.Button btnAjouterFournisseur;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button btnRegistre;
        private System.Windows.Forms.Button btnRechercheRegistre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

