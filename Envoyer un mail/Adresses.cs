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
            Form1 form1 = new Form1();
            form1.Text = form1.Destinataire.Text;
            
        }

        //private Form1 form1;

        private void Adresses_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Test.txt");

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
                    //checkedListBox1.Items[i].ToString();
                    Liste_adresses.Text = Liste_adresses.Text + checkedListBox1.Items[i].ToString() + ";";
                }
                else
                {
                    //non coché
                    //checkedListBox1.Items[i].ToString();
                }                
            }
        }

        private void button_valider_Click(object sender, EventArgs e)
        {


            Form1 form1 = new Form1();
            
            form1.Destinataire.Text = Liste_adresses.Text;
            form1.MyrefeshMethod();
            form1.Show();
        }
        
    }
}
