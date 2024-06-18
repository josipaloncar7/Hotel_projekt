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
    public partial class Form6 : Form
    {
        public string hotel;
        public DateTime odlazak;
        public DateTime dolazak;
        public Form2 form2;
        public Form3 form3;
        public Form6( string hotel, DateTime dolazak, DateTime odlazak, Form2 f, Form3 f2)
        {
            form3 = f2;
            form2 = f;
            this.odlazak = odlazak;
            this.dolazak = dolazak;
            this.hotel = hotel;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../sobe.txt");

            foreach (var x in list)
            {

                if ( Prijave.razbij(x)[4] == this.hotel ) {
                     List<string> razbijeni = Prijave.razbij(x);
                    listView2.Items.Add(new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[3], Prijave.provjeri_raspoloživost(this.hotel, razbijeni[0], dolazak, odlazak) ? "Raspoloživo" : "Zauzeto", razbijeni[2] }));

                    }
            }


        }

        private void listView2_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.cijena = float.Parse(listView2.SelectedItems[0].SubItems[2].Text) * form2.broj_noci;
                form2.broj_sobe = listView2.SelectedItems[0].SubItems[0].Text;
                form2.vrsta = int.Parse(listView2.SelectedItems[0].SubItems[4].Text);
            }
            else
            {
                form3.cijena_sobe = (float.Parse(listView2.SelectedItems[0].SubItems[2].Text) * int.Parse(form3.broj_noci)).ToString();
                form3.broj_sobe = listView2.SelectedItems[0].SubItems[0].Text;
                form3.vrsta_sobe = int.Parse(listView2.SelectedItems[0].SubItems[4].Text).ToString();

            }

        }
    }
}
