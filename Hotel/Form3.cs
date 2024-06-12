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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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





        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        //botun Spremi za unos novog hotela
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        //botun odbaci za unos novog hotela
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        //botun spremi za unos nove sobe
        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        //botun odbaci za unos nove sobe
        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        //botun spremi za novu rezervaciju
        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        //botun odbaci za novu rezervaciju
        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        //botun spremi za unos novog gosta
        private void button6_Click(object sender, EventArgs e)
        {
            
        }


        //botun odbaci za unos novog gosta
        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

