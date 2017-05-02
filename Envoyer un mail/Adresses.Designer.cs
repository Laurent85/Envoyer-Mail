namespace Envoyer_un_mail
{
    partial class Adresses1
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
            this.Choix_adresses = new System.Windows.Forms.CheckedListBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.Liste_adresses = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choix_adresses
            // 
            this.Choix_adresses.BackColor = System.Drawing.Color.Gainsboro;
            this.Choix_adresses.CheckOnClick = true;
            this.Choix_adresses.ForeColor = System.Drawing.Color.Blue;
            this.Choix_adresses.FormattingEnabled = true;
            this.Choix_adresses.Location = new System.Drawing.Point(58, 12);
            this.Choix_adresses.Name = "Choix_adresses";
            this.Choix_adresses.Size = new System.Drawing.Size(395, 289);
            this.Choix_adresses.TabIndex = 0;
            this.Choix_adresses.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(58, 355);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 1;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // Liste_adresses
            // 
            this.Liste_adresses.Location = new System.Drawing.Point(58, 320);
            this.Liste_adresses.Name = "Liste_adresses";
            this.Liste_adresses.Size = new System.Drawing.Size(395, 20);
            this.Liste_adresses.TabIndex = 2;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(378, 355);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // Adresses1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(520, 390);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.Liste_adresses);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.Choix_adresses);
            this.Name = "Adresses1";
            this.Text = "Adresses";
            this.Load += new System.EventHandler(this.Adresses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Choix_adresses;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.TextBox Liste_adresses;
        private System.Windows.Forms.Button btn_annuler;
    }
}