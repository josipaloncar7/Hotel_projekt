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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hotel
{
    public partial class Form2 : Form
    {
        public Korisnik prijavljeni;
        public Form2( Korisnik korisnik )
        {
            this.prijavljeni = korisnik;
            InitializeComponent();
        }

        public string izabran_hotel
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; }
        }
        public string broj_sobe
        {

            get { return textBox8.Text; }
            set { textBox8.Text = value;  }
        }

        public int vrsta
        {

            get { return int.Parse(textBox11.Text); }
            set { textBox11.Text = value.ToString(); }

        }
        public float cijena
        {

            get { return float.Parse(textBox2.Text);  }
            set { textBox2.Text = value.ToString(); }

        }
        public int broj_noci 
        {
            get { return int.Parse(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        
        
        }

        //otvara formu za odabir hotela
        private void button11_Click(object sender, EventArgs e)
        {

            textBox11.Text = null;
            textBox8.Text = null;
            textBox2.Text = null;
            Form4 form4 = new Form4( this, null );
            form4.ShowDialog();
            

        }

        //otvara formu za odabir sobe
        private void button9_Click(object sender, EventArgs e)
        {
            if ( textBox10.Text != "" && textBox10.Text != null ) 
            {

            Form6 form6 = new Form6( textBox10.Text, dateTimePicker1.Value, dateTimePicker2.Value, this, null );
            form6.ShowDialog();
            
            }

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
                if ( Prijave.provjeri_raspoloživost( izabran_hotel, broj_sobe, dateTimePicker1.Value, dateTimePicker2.Value ) ) {
                    Prijave.zapiši_u_bazu("../../rezervacije.txt", textBox4.Text + "," + izabran_hotel + "," + broj_sobe + "," + vrsta + "," + numericUpDown4.Value.ToString() + ","
                        + numericUpDown5.Value.ToString() + "," + dateTimePicker1.Value.ToString() + "," + dateTimePicker2.Value.ToString() + ","
                        + cijena + "," + this.prijavljeni.Username);
                }
                else
                {

                    label35.Visible = true;
                    label35.Text = "Zauteto je tada";

                }
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
            else if (numericUpDown1.Value.ToString() == "")
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
                if ( !Prijave.imali_u_bazi( "../../gosti.txt", 7, this.prijavljeni.Username ) ) {
                    Prijave.zapiši_u_bazu("../../gosti.txt", textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + numericUpDown1.Value.ToString() + "," + (radioButton1.Checked == true ? "muško" : "žensko") + "," + maskedTextBox3.Text + "," + textBox7.Text + "," + this.prijavljeni.Username);
                }
                else
                {

                    MessageBox.Show("Već ste registirani kao gost");

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = null;
            textBox8.Text = null;
            dateTimePicker1 = null;
            dateTimePicker2 = null;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 0;
            textBox2.Text = null;
            label35.Visible = false;
            textBox11.Text = null;
            textBox4.Text = prijavljeni.Ime;
            textBox5.Text = prijavljeni.Prezime;
            textBox6.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            maskedTextBox3.Text = null;
            textBox7.Text = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            textBox4.Text = this.prijavljeni.Ime;
            textBox5.Text= this.prijavljeni.Prezime;
            broj_noci = ((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            broj_noci = ((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays);
            if ( textBox8.Text != "" && textBox8.Text != null )
            {

                List<string> sobe = Prijave.ocitaj_dokument( "../../sobe.txt" );
                foreach( var x in sobe)
                {

                    if( Prijave.razbij(x)[0] == this.broj_sobe && Prijave.razbij(x)[4] == this.izabran_hotel)
                    {

                        cijena = float.Parse(Prijave.razbij(x)[3]) * broj_noci;

                    }

                }

            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            broj_noci = ((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays);
            if (textBox8.Text != "" && textBox8.Text != null)
            {

                List<string> sobe = Prijave.ocitaj_dokument("../../sobe.txt");
                foreach (var x in sobe)
                {

                    if (Prijave.razbij(x)[0] == this.broj_sobe && Prijave.razbij(x)[4] == this.izabran_hotel)
                    {

                        cijena = float.Parse(Prijave.razbij(x)[3]) * broj_noci;

                    }

                }

            }

        }
    }
}
