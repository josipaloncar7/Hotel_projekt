using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.Location = new Point(26, 47);
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            tabControl4.Visible = false;

        }

        private void sobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = true;
            tabControl2.Location = new Point(26, 47);
            tabControl1.Visible = false;
            tabControl3.Visible = false;
            tabControl4.Visible = false;
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.Visible = true;
            tabControl3.Location = new Point(26, 47);
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl4.Visible = false;
        }

        private void gostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl4.Visible = true;
            tabControl4.Location = new Point(26, 47);
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
        }






        //otvara formu za odabir hotela
        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        //otvara formu za odabir gosta
        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        //otvara formu za odabir hotela
        private void button11_Click(object sender, EventArgs e)
        {
           
        }
        //otvara formu za odabir sobe
        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        //Spremi unos novog hotela
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label33.Visible = true;
                label33.Text = "Unesite naziv hotela!";
            }
            else if (textBox2.Text == "")
            {
                label33.Visible = true;
                label33.Text = "Unesite lokaciju hotela!";
            }
            else
            {
                label33.Visible = false;
                

            }
        }

        //odbaci unos novog hotela
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            numericUpDown1.Value = 5;
            label33.Visible = false;
        }

        //spremi unos nove sobe
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                label34.Visible = true;
                label34.Text = "Odaberite hotel!";

            }
            else if (maskedTextBox1.Text == "")
            {
                label34.Visible = true;
                label34.Text = "Unesite broj sobe!";
            }
            else if (textBox3.Text == "")
            {
                label34.Visible = true;
                label34.Text = "Unesite vrstu sobe!";
            }
            else if (maskedTextBox2.Text == "")
            {
                label34.Visible = true;
                label34.Text = "Unesite cijenu sobe!";
            }
            else
            {
                label34.Visible = false;
                
            }
        }

        //odbaci unos nove sobe
        private void button3_Click(object sender, EventArgs e)
        {

            textBox14.Text = null;
            maskedTextBox1.Text = null;
            textBox3.Text = null;
            maskedTextBox2.Text = null;
            numericUpDown2.Value = 1;
            label33.Visible = false;
        }

        //spremi novu rezervaciju
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                label35.Visible = true;
                label35.Text = "Odaberite ime gosta koji vrši rezervaciju!";
            }
            else if (textBox10.Text == "")
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
                
            }
        }

        // odbaci novu rezervaciju
        private void button7_Click(object sender, EventArgs e)
        {
            textBox9.Text = null;
            textBox10.Text = null;
            textBox8.Text = null;
            dateTimePicker1 = null;
            dateTimePicker2 = null;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 0;
            maskedTextBox6.Text = null;
            label35.Visible = false;
        }

        // spremi unos novog gosta
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite ime gosta!";
            }
            else if (textBox5.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite prezime gosta!";
            }
            else if (textBox6.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite adresu gosta!";
            }
            else if (comboBox1.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Odaberite dob gosta!";
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                label36.Visible = true;
                label36.Text = "Odaberite spol gosta!";
            }
            else if (maskedTextBox3.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite broj mobitela od gosta!";
            }
            else if (textBox7.Text == "")
            {
                label36.Visible = true;
                label36.Text = "Unesite e-mail adresu gosta!";
            }

            else
            {
                label36.Visible = false;
             
            }
        }


        // odbaci unos novog gosta
        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            comboBox1.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            maskedTextBox3.Text = null;
            textBox7.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
