using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Envoyer_un_mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void MyrefeshMethod()
        {
            MessageBox.Show("refreshed");
        }

        private void Envoyer_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = "smtp.orange.fr";
            client.EnableSsl = false;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("laurent_manceau@orange.fr", "Lothlu85");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(Expéditeur.Text, Expéditeur.Text, Encoding.UTF8);

            mail.To.Add(new MailAddress(Destinataire.Text));
            mail.Subject = Objet.Text;
            mail.Body = Message.Text;
            mail.BodyEncoding = UTF8Encoding.UTF8;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            
            client.Send(mail);
        }

        private void Adresses_Click(object sender, EventArgs e)
        {
            Adresses1 Adresses2 = new Adresses1();
            Adresses2.Show();
            
        }

    }
}
