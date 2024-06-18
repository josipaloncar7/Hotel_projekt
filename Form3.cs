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

        public string rezervacija_hotel
        {

            get { return textBox10.Text; }
            set { textBox10.Text = value;  }
        }
        public string izabran_hotel
        {

            get { return textBox14.Text; }
            set { textBox14.Text = value;  }
        }
        public string izabran_korisnik
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        
        }

        public string broj_sobe
        {

            get { return textBox8.Text; }
            set { textBox8.Text = value; }

        }
        public string vrsta_sobe
        {

            get { return textBox11.Text; }
            set { textBox11.Text = value; }

        }
        public string cijena_sobe
        {

            get { return textBox16.Text; }
            set { textBox16.Text = value; }

        }

        public string broj_noci
        {
            get { return textBox15.Text; }
            set { textBox15.Text = value; }
        }
        public string username
        {
            get;
            set;

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            tabControl1.Visible = true;
            tabControl1.Location = new Point(26, 47);
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            tabControl4.Visible = false;
            listView1.Items.Clear();
            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../hoteli.txt");
            foreach (var x in list)
            {

                List<string> razbijeni = Prijave.razbij(x);
                listView1.Items.Add(new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[2] }));

            }

        }

        private void sobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = true;
            tabControl2.Location = new Point(26, 47);
            tabControl1.Visible = false;
            tabControl3.Visible = false;
            tabControl4.Visible = false;
            listView2.Items.Clear();
            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../sobe.txt");
            foreach (var x in list)
            {

                List<string> razbijeni = Prijave.razbij(x);
                listView2.Items.Add(new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[3], razbijeni[2], razbijeni[4] }));

            }
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.Visible = true;
            tabControl3.Location = new Point(26, 47);
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl4.Visible = false;
            listView4.Items.Clear();
            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../rezervacije.txt");
            foreach (var x in list)
            {

                List<string> razbijeni = Prijave.razbij(x);
                listView4.Items.Add(new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[2], razbijeni[3], razbijeni[4], razbijeni[5],DateTime.Parse(razbijeni[6]).Date.ToString("dd/mm/yyyy"),DateTime.Parse(razbijeni[7]).Date.ToString("dd/mm/yyyy"), ((int)DateTime.Parse( razbijeni[7] ).Subtract( DateTime.Parse(razbijeni[6] )).TotalDays).ToString(), razbijeni[8]  }));

            }
        }

        private void gostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl4.Visible = true;
            tabControl4.Location = new Point(26, 47);
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            listView3.Items.Clear();
            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../gosti.txt");
            foreach (var x in list)
            {

                List<string> razbijeni = Prijave.razbij(x);
                listView3.Items.Add(new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[5], razbijeni[2], razbijeni[4], razbijeni[6] }));

            }

        }






        //otvara formu za odabir hotela
        private void button12_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4( null, this );
            form4.ShowDialog();
        }
        public string ime_gosta
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }

        //otvara formu za odabir gosta
        private void button10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5( this );
            form5.ShowDialog();
        }

        //otvara formu za odabir hotela
        private void button11_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4( null, this );
            form4.ShowDialog();
        }
        //otvara formu za odabir sobe
        private void button9_Click(object sender, EventArgs e)
        {
            if (izabran_hotel != null)
            {
                Form6 form6 = new Form6( rezervacija_hotel , dateTimePicker1.Value, dateTimePicker2.Value, null, this);
                form6.ShowDialog();
            }
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
                Prijave.zapiši_u_bazu("../../hoteli.txt", textBox1.Text + "," + textBox2.Text + "," + numericUpDown1.Value.ToString());
                textBox1.Text = null;
                textBox2.Text = null;

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
                Prijave.zapiši_u_bazu( "../../sobe.txt", maskedTextBox1.Text + "," + textBox3.Text + "," + numericUpDown2.Value.ToString() + "," + maskedTextBox2.Text +"," +textBox14.Text);
                maskedTextBox1.Text = null;
                textBox3.Text = null;
                maskedTextBox2.Text = null;
                textBox14.Text = null;


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
                if (Prijave.provjeri_raspoloživost(rezervacija_hotel, broj_sobe, dateTimePicker1.Value, dateTimePicker2.Value ) ) {
                    Prijave.zapiši_u_bazu("../../rezervacije.txt", ime_gosta + "," + rezervacija_hotel + "," + broj_sobe + "," + vrsta_sobe + "," + numericUpDown4.Value.ToString() + "," +
                        numericUpDown5.Value.ToString() + "," + dateTimePicker1.Value.ToString() + "," + dateTimePicker2.Value.ToString() + "," + cijena_sobe + "," + username);
                }
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
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 0;
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
                if ( !Prijave.imali_u_bazi( "../../usernames.txt", 0, textBox12.Text  ) )
                {
                    Korisnik upisani = new Korisnik( textBox4.Text, textBox5.Text, textBox12.Text, textBox13.Text );
                    Prijave.zapiši_u_bazu("../../gosti.txt", textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + numericUpDown1.Value.ToString() + "," 
                        + (radioButton1.Checked == true ? "muško" : "žensko") +
                        "," + maskedTextBox3.Text + "," + textBox7.Text + "," + textBox12.Text);
                    Prijave.upis(upisani, "../..");


                }

            }
        }


        // odbaci unos novog gosta
        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            maskedTextBox3.Text = null;
            textBox7.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            broj_noci = ((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays).ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            broj_noci = ((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays).ToString();
            if (textBox8.Text != "" && textBox8.Text != null)
            {

                List<string> sobe = Prijave.ocitaj_dokument("../../sobe.txt");
                foreach (var x in sobe)
                {

                    if (Prijave.razbij(x)[0] == this.broj_sobe && Prijave.razbij(x)[4] == this.rezervacija_hotel)
                    {

                        cijena_sobe = (float.Parse(Prijave.razbij(x)[3]) * int.Parse(broj_noci)).ToString();

                    }

                }

            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            broj_noci = ((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays).ToString();
            if (textBox8.Text != "" && textBox8.Text != null)
            {

                List<string> sobe = Prijave.ocitaj_dokument("../../sobe.txt");
                foreach (var x in sobe)
                {

                    if (Prijave.razbij(x)[0] == this.broj_sobe && Prijave.razbij(x)[4] == this.rezervacija_hotel)
                    {

                        cijena_sobe = (float.Parse(Prijave.razbij(x)[3]) * int.Parse(broj_noci)).ToString();

                    }

                }

            }
        }
    }
}
