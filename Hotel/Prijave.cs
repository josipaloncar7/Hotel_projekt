using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public static class Prijave
    {

        public static List<Korisnik> Korisniks( string filepath )
        {
            Korisnik korisnik = null;
            List<Korisnik> ljudi = new List<Korisnik>();
            StreamReader sr_username = new StreamReader( filepath + "/usernames.txt" );
            StreamReader sr_password = new StreamReader( filepath + "/sifre.txt" );
            StreamReader sr_ime = new StreamReader( filepath + "/imena.txt" );
            StreamReader sr_prezime = new StreamReader(filepath + "/prezimena.txt");
            string lineime;
            string lineprezime;
            string lineusername;
            string linesifra;
            while (( lineusername =  sr_username.ReadLine()) != null ) 
            { 
                lineprezime = sr_prezime.ReadLine();
                lineime = sr_ime.ReadLine();
                linesifra = sr_password.ReadLine();
                korisnik = new Korisnik( lineime, lineprezime, lineusername, linesifra );
                ljudi.Add( korisnik );
            
            }

            sr_ime.Close();
            sr_password.Close();
            sr_prezime.Close();
            sr_username.Close();

            return ljudi;

        }
        

        public static (bool , string) korisnik( List<Korisnik> korisnici, string username, string sifra )
        {

            foreach ( var x in korisnici )
            {
                if ( x.Username == username)
                {

                    if(x.Sifra == sifra)
                    {

                        return (true, "");

                    }
                    else
                    {
                        return (false, "Pogrešna šifra!" );
                    }
                }
                
            }

            return (false, "Nepostojeći korisnik!");

        }

        public static bool prijavaUrednika( string ime, string sifra, string filepath )
        {
            string lineime;
            string linesifra;
            StreamReader ime_admin = new StreamReader(filepath + "/adminimena.txt");
            StreamReader password_admin = new StreamReader(filepath + "/adminsifre.txt");
            while ( (  lineime = ime_admin.ReadLine() ) != null )
            {
                linesifra = password_admin.ReadLine();

                if( lineime == ime && linesifra == sifra)
                {

                    return true;

                }

            }

            MessageBox.Show("pogreska pri unosu");
            return false;

        }

        public static void upis( Korisnik upisani, string filepath )
        {
            List<Korisnik> lista = Prijave.Korisniks(filepath);
            StreamWriter sw_ime = new StreamWriter( filepath + "/imena.txt" );
            StreamWriter sw_Prezime = new StreamWriter( filepath + "/prezimena.txt" );
            StreamWriter sw_Username = new StreamWriter(filepath + "/usernames.txt");
            StreamWriter sw_sifra = new StreamWriter(filepath + "/sifre.txt" );


            lista.Add( upisani );

            foreach (var x in lista)
            {
                sw_ime.WriteLine(x.Ime);
                sw_Prezime.WriteLine(x.Prezime);
                sw_Username.WriteLine(x.Username);         
                sw_sifra.WriteLine(x.Sifra);
            }
            sw_ime.Close();
            sw_Username.Close();
            sw_sifra.Close();
            sw_Prezime .Close();

        }


    }
}
