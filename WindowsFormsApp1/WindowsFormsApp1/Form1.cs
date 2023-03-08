using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebut_Click(object sender, EventArgs e)
        {
            if (yearb.Text == "" || nameb.Text == "" || szhb.Text == "" || countryb.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
            }

            else {
                try
                {
                    if (int.Parse(yearb.Text) <= 1989)
                    {
                        MessageBox.Show("Hiba!Az évszám nem megfelelő!");

                    }

                    else
                    {

                        try
                        {
                            if (!File.Exists("uj_dijazott.txt"))
                            {
                                using (StreamWriter sw = File.CreateText("uj_dijazott.txt"))
                                {
                                    sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                                    sw.WriteLine($"{yearb.Text};{nameb.Text};{szhb.Text};{countryb.Text}");
                                }
                            }

                            else
                            {
                                using (StreamWriter sw = File.AppendText("uj_dijazott.txt"))
                                {
                                    sw.WriteLine($"{yearb.Text};{nameb.Text};{szhb.Text};{countryb.Text}");

                                }




                            }
                        }

                        catch {
                            MessageBox.Show("Hiba az állomány írásánál!");

                        }

                    }
                }

                catch
                {
                    MessageBox.Show("Hiba!Az évszám nem megfelelő!");
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameb_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearb_TextChanged(object sender, EventArgs e)
        {

        }

        private void szhb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}           