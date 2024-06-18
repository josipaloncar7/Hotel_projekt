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

        public static bool prijava_admina( string ime, string password )
        {

            List<string> imena = ocitaj_dokument( "../../adminimena.txt" );
            List<string> sifre = ocitaj_dokument("../../adminsifre.txt");
            foreach ( var x in imena )
            {

                if ( x == ime )
                {

                    if ( sifre[ imena.IndexOf( x ) ] == password )
                    {

                        return true;

                    }
                    else
                    {

                        MessageBox.Show("kriva sifra");
                        return false;

                    }

                }

            }
            return false;

        }

        public static bool imali_u_bazi( string filepath, int index, string kljuc ) 
        {
            StreamReader sr = new StreamReader(filepath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {

                if (line != "")
                {
                    if (razbij(line)[index] == kljuc)
                    {
                        return true;

                    }
                }

            }
            sr.Close();

            return false;
        
        }

        public static void zapiši_u_bazu( string filepath, string unos )
        {

            StreamReader sr = new StreamReader( filepath );
            List<string> elementi = new List<string>();
            string line;
            while ( ( line = sr.ReadLine() ) != null )
            {

                elementi.Add(line);

            }
            sr.Close();
            elementi.Add( unos );
            StreamWriter sw = new StreamWriter(filepath);
            foreach ( var x in elementi )
            {
                if (!string.IsNullOrEmpty(x))
                {
                    sw.WriteLine(x);
                }
            }
            sw.Close();

        }

        public static bool provjeri_raspoloživost( string hotel, string broj_sobe, DateTime dolazak, DateTime odlazak )
        {

            List<string> rezervacije = ocitaj_dokument( "../../rezervacije.txt" );
            List<string> line = new List<string>();
            foreach ( var x in rezervacije )
            {
                line = Prijave.razbij(x);

                if ( line[1] == hotel && line[2] == broj_sobe ) {
                DateTime datum1 = DateTime.Parse(line[6]);
                DateTime datum2 = DateTime.Parse(line[7]); 

                if ((( datum1 <= odlazak ) && ( dolazak <= datum2 ))) 
                {

                    return false;

                }
                }
            }

            return true;

        }

        public static List<string> ocitaj_dokument( string filepath)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(filepath);
            string line;
            while((line = sr.ReadLine()) != null){

                if( line!= "" && line!=null)
                {

                    list.Add(line);

                }

            }
            sr.Close();
            return list;

        }

        public static List<string> razbij( string unos )
        {
            string v = ",";
            List <string> list = new List<string>();
            list = unos.Split( v.ToCharArray()  ).ToList();
            return list;

        }

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
                if ( !string.IsNullOrEmpty( x.Ime ) && !string.IsNullOrEmpty(x.Prezime) && !string.IsNullOrEmpty(x.Username) && !string.IsNullOrEmpty(x.Sifra)) 
                {
                    sw_ime.WriteLine(x.Ime);
                    sw_Prezime.WriteLine(x.Prezime);
                    sw_Username.WriteLine(x.Username);
                    sw_sifra.WriteLine(x.Sifra);
                }
                }
            sw_ime.Close();
            sw_Username.Close();
            sw_sifra.Close();
            sw_Prezime .Close();

        }


    }
}
