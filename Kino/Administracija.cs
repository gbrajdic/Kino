using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Administracija : Form
    {
        public Administracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BazaFilmova filmovi = new BazaFilmova();
            filmovi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BazaTermina termini = new BazaTermina();
            termini.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BazaZaposlenika zaposlenici = new BazaZaposlenika();
            zaposlenici.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BazaZaduženja zaduzenja = new BazaZaduženja();
            zaduzenja.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
