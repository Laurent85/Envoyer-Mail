using System;
using System.Windows.Forms;

namespace Envoyer_un_mail
{
    public partial class Adresses1 : Form
    {
        public Adresses1()
        {
            InitializeComponent();           
        }

        public static string Liste;
        private void Adresses_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            //System.IO.StreamReader file = new System.IO.StreamReader(@"\\serveur2008\laurent$\logiciels\mail\adresses.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\test.txt");
            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                //add the line to CheckedListBox, you need to pass the parameters "index" & "string"
                Choix_adresses.Items.Insert(counter, line);

                //increase the index
                counter++;
            }

            //close the file
            file.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liste_adresses.Text = "";
            for (int i = 0; i <= (Choix_adresses.Items.Count - 1); i++)
            {

                if (Choix_adresses.GetItemChecked(i))
                {
                    //coché                    
                    Liste_adresses.Text = Liste_adresses.Text + Choix_adresses.Items[i].ToString() + ";";
                }
                else
                {
                    //non coché                    
                }                
            }
        }

        private void button_valider_Click(object sender, EventArgs e)
        {            
            Liste = Liste_adresses.Text;            
            this.Close();                     
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
