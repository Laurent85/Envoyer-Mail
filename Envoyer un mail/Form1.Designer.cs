namespace Envoyer_un_mail
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
            this.Destinataire = new System.Windows.Forms.TextBox();
            this.Envoyer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Expéditeur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.Objet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adresses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Destinataire
            // 
            this.Destinataire.Location = new System.Drawing.Point(141, 63);
            this.Destinataire.Name = "Destinataire";
            this.Destinataire.Size = new System.Drawing.Size(440, 20);
            this.Destinataire.TabIndex = 1;
            // 
            // Envoyer
            // 
            this.Envoyer.Location = new System.Drawing.Point(506, 278);
            this.Envoyer.Name = "Envoyer";
            this.Envoyer.Size = new System.Drawing.Size(75, 23);
            this.Envoyer.TabIndex = 4;
            this.Envoyer.Text = "Envoyer";
            this.Envoyer.UseVisualStyleBackColor = true;
            this.Envoyer.Click += new System.EventHandler(this.Envoyer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destinataire";
            // 
            // Expéditeur
            // 
            this.Expéditeur.Location = new System.Drawing.Point(141, 28);
            this.Expéditeur.Name = "Expéditeur";
            this.Expéditeur.Size = new System.Drawing.Size(440, 20);
            this.Expéditeur.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expéditeur";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(141, 141);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(440, 115);
            this.Message.TabIndex = 3;
            this.Message.Text = "";
            // 
            // Objet
            // 
            this.Objet.Location = new System.Drawing.Point(141, 99);
            this.Objet.Name = "Objet";
            this.Objet.Size = new System.Drawing.Size(440, 20);
            this.Objet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Objet";
            // 
            // Adresses
            // 
            this.Adresses.Location = new System.Drawing.Point(602, 61);
            this.Adresses.Name = "Adresses";
            this.Adresses.Size = new System.Drawing.Size(75, 23);
            this.Adresses.TabIndex = 8;
            this.Adresses.Text = "Adresses";
            this.Adresses.UseVisualStyleBackColor = true;
            this.Adresses.Click += new System.EventHandler(this.Adresses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 313);
            this.Controls.Add(this.Adresses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Objet);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Expéditeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Envoyer);
            this.Controls.Add(this.Destinataire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Envoyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Expéditeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Message;
        private System.Windows.Forms.TextBox Objet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Adresses;
        public System.Windows.Forms.TextBox Destinataire;
    }
}

