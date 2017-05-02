namespace Envoyer_un_mail
{
    partial class Principal
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
            this.Destinataire = new System.Windows.Forms.TextBox();
            this.Envoyer = new System.Windows.Forms.Button();
            this.Expéditeur = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.Objet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adresses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Parcourir = new System.Windows.Forms.Button();
            this.pj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Destinataire
            // 
            this.Destinataire.Location = new System.Drawing.Point(141, 118);
            this.Destinataire.Multiline = true;
            this.Destinataire.Name = "Destinataire";
            this.Destinataire.Size = new System.Drawing.Size(440, 62);
            this.Destinataire.TabIndex = 1;
            // 
            // Envoyer
            // 
            this.Envoyer.Location = new System.Drawing.Point(141, 395);
            this.Envoyer.Name = "Envoyer";
            this.Envoyer.Size = new System.Drawing.Size(75, 23);
            this.Envoyer.TabIndex = 4;
            this.Envoyer.Text = "Envoyer";
            this.Envoyer.UseVisualStyleBackColor = true;
            this.Envoyer.Click += new System.EventHandler(this.Envoyer_Click);
            // 
            // Expéditeur
            // 
            this.Expéditeur.Location = new System.Drawing.Point(141, 76);
            this.Expéditeur.Name = "Expéditeur";
            this.Expéditeur.Size = new System.Drawing.Size(440, 20);
            this.Expéditeur.TabIndex = 0;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(141, 241);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(440, 134);
            this.Message.TabIndex = 3;
            this.Message.Text = "";
            // 
            // Objet
            // 
            this.Objet.Location = new System.Drawing.Point(141, 201);
            this.Objet.Name = "Objet";
            this.Objet.Size = new System.Drawing.Size(440, 20);
            this.Objet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Objet";
            // 
            // Adresses
            // 
            this.Adresses.Location = new System.Drawing.Point(60, 140);
            this.Adresses.Name = "Adresses";
            this.Adresses.Size = new System.Drawing.Size(75, 20);
            this.Adresses.TabIndex = 8;
            this.Adresses.Text = "Destinataire";
            this.Adresses.UseVisualStyleBackColor = true;
            this.Adresses.Click += new System.EventHandler(this.Adresses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Votre nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message";
            // 
            // Parcourir
            // 
            this.Parcourir.Location = new System.Drawing.Point(506, 395);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Size = new System.Drawing.Size(75, 23);
            this.Parcourir.TabIndex = 11;
            this.Parcourir.Text = "Joindre...";
            this.Parcourir.UseVisualStyleBackColor = true;
            this.Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // pj
            // 
            this.pj.AutoSize = true;
            this.pj.Location = new System.Drawing.Point(235, 322);
            this.pj.Name = "pj";
            this.pj.Size = new System.Drawing.Size(0, 13);
            this.pj.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Envoyer_un_mail.Properties.Resources.LOGO_ST_JACQUES_2;
            this.pictureBox1.Location = new System.Drawing.Point(595, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pj);
            this.Controls.Add(this.Parcourir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adresses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Objet);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Expéditeur);
            this.Controls.Add(this.Envoyer);
            this.Controls.Add(this.Destinataire);
            this.Name = "Principal";
            this.Text = "Client Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Envoyer;
        private System.Windows.Forms.TextBox Expéditeur;
        private System.Windows.Forms.RichTextBox Message;
        private System.Windows.Forms.TextBox Objet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Adresses;
        public System.Windows.Forms.TextBox Destinataire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Parcourir;
        private System.Windows.Forms.Label pj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

