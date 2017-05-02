using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            System.IO.StreamReader file = new System.IO.StreamReader(@"\\serveur2008\laurent$\logiciels\mail\adresses.txt");

            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                //add the line to CheckedListBox, you need to pass the parameters "index" & "string"
                checkedListBox1.Items.Insert(counter, line);

                //increase the index
                counter++;
            }

            //close the file
            file.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liste_adresses.Text = "";
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {

                if (checkedListBox1.GetItemChecked(i))
                {
                    //coché                    
                    Liste_adresses.Text = Liste_adresses.Text + checkedListBox1.Items[i].ToString() + ";";
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
      
    }
}
