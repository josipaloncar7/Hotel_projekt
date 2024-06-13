using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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
                this.Close();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }
    }
}
