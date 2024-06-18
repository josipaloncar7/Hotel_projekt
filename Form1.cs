using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
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

        private void button1_Click(object sender, EventArgs e)
        {

            (bool upit, string greska) = Prijave.korisnik(Prijave.Korisniks("../.."), textBox1.Text, textBox2.Text);
            if (upit)
            {

                Korisnik prijavljeni = new Korisnik( "", "", textBox1.Text, textBox2.Text);
                List<Korisnik> korisnici = Prijave.Korisniks( "../.." );
                foreach ( var x in korisnici )
                {
                    
                    if( x.Username == prijavljeni.Username)
                    {

                        prijavljeni.Ime = x.Ime;
                        prijavljeni.Prezime = x.Prezime;
                        break;

                    }

                }
                this.Hide();
                Form2 forma = new Form2( prijavljeni );
                forma.ShowDialog();

            }
            else
            {
                label10.Visible = true;
                label10.Text=greska;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Prijave.prijava_admina(textBox3.Text, textBox4.Text))
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();

        }
    }
}
