using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DateTime dt = new DateTime(2016, 2, 16);
             //Form4 pocetna = new Form4("Joy",dt,"18");
            //Form1 pocetna = new Form1();
            //Zaposlenici pocetna = new Zaposlenici();
            NultaForma pocetna = new NultaForma();
           // BazaFilmova filmovi = new BazaFilmova();
           // BazaZaposlenika zaposlenici = new BazaZaposlenika();
           // BazaZaduženja zaduzenja = new BazaZaduženja();
           // BazaTermina termini = new BazaTermina();
            Application.Run(pocetna);
            
        }
    }
}
