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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //otvara formu za odabir hotela
        private void button11_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        //otvara formu za odabir sobe
        private void button9_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                label35.Visible = true;
                label35.Text = "Odaberite hotel!";
            }
            else if (textBox8.Text == "" && textBox11.Text == "")
            {
                label35.Visible = true;
                label35.Text = "Odaberite sobu!";
            }
            else if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                label35.Visible = true;
                label35.Text = "Unesite točan datum dolaska i odlaska!!";
            }
            else
            {
                label35.Visible = false;
                //spremit podatke za rezervaciju u bazu podataka
            }

            if (textBox4.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite ime!";
            }
            else if (textBox5.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite prezime!";
            }
            else if (textBox6.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite adresu!";
            }
            else if (comboBox1.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Odaberite dob!";
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                label36.Visible = true;
                label36.Text = "Odaberite spol!";
            }
            else if (maskedTextBox3.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite broj mobitela!";
            }
            else if (textBox7.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite e-mail adresu!";
            }
            //jos dodat fukcije za izradit racun?
            else
            {
                label36.Visible = false;
                //spremit podatke novog gosta u bazu podataka
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = null;
            textBox8.Text = null;
            dateTimePicker1 = null;
            dateTimePicker2 = null;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 0;
            maskedTextBox6.Text = null;
            label35.Visible = false;

            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            comboBox1.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            maskedTextBox3.Text = null;
            textBox7.Text = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
