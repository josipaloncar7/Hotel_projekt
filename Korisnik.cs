using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Korisnik
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Sifra { get; set; }
        public string Username { get; set; }

        public Korisnik( string ime, string prezime, string username, string sifra ) 
        { 
        
            this.Prezime = prezime;
            this.Username = username;
            this.Sifra = sifra;
            this.Ime  = ime;
        
        }

        public void stvori_Korisnika()
        {




        }


    }
}
