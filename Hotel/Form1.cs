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
                this.Hide();
                Form2 forma = new Form2();
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

            if (Prijave.prijavaUrednika(textBox3.Text, textBox4.Text, "../.."))
            {

                this.Hide();
                Form4 novaforma = new Form4();
                novaforma.ShowDialog();

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
