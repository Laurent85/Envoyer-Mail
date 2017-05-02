using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace Envoyer_un_mail
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Objet.Text = " ";
            Message.Text = " ";
            Adresses1.Liste = "";
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
            mail.From = new MailAddress("prof@clg-stjacques.fr", Expéditeur.Text, Encoding.UTF8);

            string[] toAddressArray;
            toAddressArray = Destinataire.Text.ToString().Split(new char[] { ';' });
            foreach (string a in toAddressArray)
            {
                mail.To.Add(new MailAddress(a));
            }

            mail.Subject = Objet.Text;
            mail.Body = Message.Text;
            mail.BodyEncoding = UTF8Encoding.UTF8;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            Attachment attachment;
            attachment = new Attachment(pj.Text.ToString());
            mail.Attachments.Add(attachment);
            client.Send(mail);
        }
       

        private void Adresses_Click(object sender, EventArgs e)
        {
            Adresses1 frm2 = new Adresses1();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Adresses1.Liste != "")
            {
                Adresses1.Liste = Adresses1.Liste.Remove(Adresses1.Liste.Length - 1);
                Destinataire.Text = Adresses1.Liste;
            }                      
        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            pj.Text = openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
