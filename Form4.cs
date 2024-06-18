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
    public partial class Form4 : Form
    {
        Form2 form2;
        Form3 form3;
        public Form4( Form2 f, Form3 f2)
        {
            InitializeComponent();
            form2 = f;
            form3 = f2;
        }



        private void Form4_Load(object sender, EventArgs e)
       
        {
            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../hoteli.txt");
           
            foreach ( var x in list )
            {

                List<string> razbijeni = Prijave.razbij(x);
                listView1.Items.Add( new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[2] }) );

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (form2 != null)
            {
                form2.izabran_hotel = listView1.SelectedItems[0].SubItems[0].Text;
                this.Close();
            }
            else
            {

                form3.izabran_hotel = listView1.SelectedItems[0].SubItems[0].Text;
                form3.rezervacija_hotel = listView1.SelectedItems[0].SubItems[0].Text;
                this.Close();
            }

        }
    }
}
