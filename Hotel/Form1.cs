using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            if (textBox1.Text == "")
            {
                label10.Visible = true;
                label10.Text = "Unesite korisničko ime!";
            }
            else if (textBox2.Text == "")
            {
                label10.Visible = true;
                label10.Text = "Unesite lozinku!";
            }
            else if (textBox5.Text == "")
            {
                label10.Visible = true;
                label10.Text = "Unesite svoje ime!";
            }
            else if (textBox6.Text == "")
            {
                label10.Visible = true;
                label10.Text = "Unesite svoje prezime!";
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
            {
                label11.Visible = true;
                label11.Text = "Unesite korisničko ime!";
            }
            else if (textBox4.Text == "")
            {
                label11.Visible = true;
                label11.Text = "Unesite lozinku!";
            }
            else if ((textBox3.Text == "josipa.loncar" && textBox4.Text == "josipa1234") || (textBox3.Text == "stela.pulic" && textBox4.Text == "stela1234"))
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                label11.Visible = true;
                label11.Text = "Neispravno korisničko ime ili lozinka!";
            }
        }
    }
}

