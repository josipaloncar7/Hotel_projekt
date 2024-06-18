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
    public partial class Form5 : Form

    {
        public string username { get; set; }
        public Form3 form3;
        public Form5( Form3 f )
        {
            this.form3 = f;
            InitializeComponent();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            list = Prijave.ocitaj_dokument("../../gosti.txt");

            foreach (var x in list)
            {

                List<string> razbijeni = Prijave.razbij(x);
                listView3.Items.Add(new ListViewItem(new[] { razbijeni[0], razbijeni[1], razbijeni[5], razbijeni[2], razbijeni[4], razbijeni[6] }));
                username = razbijeni[7];

            }

        }

        private void listView3_Click(object sender, EventArgs e)
        {

            form3.izabran_korisnik = listView3.SelectedItems[0].SubItems[0].Text;
            form3.username = username;
            this.Close();

        }
    }
}
