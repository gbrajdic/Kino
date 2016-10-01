using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class PrintForma : Form
    {
        string ImeFilma;
        DateTime vrijeme;
        string sat;
        string ImeDvorane;
        string sjedala;
        string ukupno;
        string brojRacuna;
        int cijena_karte;
        
        int kol;
        public PrintForma()
        {
            InitializeComponent();

        }


        public PrintForma(string _ImeFilma, DateTime _vrijeme, string _sat, string _ImeDvorane, string _sjedala, string _ukupno, int _cijena_karte)
        {
            ImeFilma = _ImeFilma;
            vrijeme = _vrijeme;
            sat = _sat;
            ImeDvorane = _ImeDvorane;
            ukupno = _ukupno;
            sjedala = _sjedala;
            brojRacuna = DateTime.Now.Ticks.ToString();
            cijena_karte = _cijena_karte;
            kol = Convert.ToInt32(ukupno) / Convert.ToInt32(cijena_karte);


            InitializeComponent();
       
        }

        private void PrintForma_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            label2.Text = "Naziv filma: " + ImeFilma + ", " + vrijeme.ToShortDateString() + " u  " + sat + " h";
            label1.Text = "Broj računa: " + brojRacuna;
            label3.Text = "Dvorana: " + ImeDvorane;
            label4.Text = "Sjedala: " + sjedala;
            label6.Text = "Cijena karte: " + cijena_karte.ToString() + " kn " + "(" + kol.ToString() + "x)";
            label5.Text = "Ukupno: " + ukupno + " kn";
            CultureInfo culture = new CultureInfo("hr-HR");
            label7.Text = "Mjesto i datum izdavanja: Zagreb, " + DateTime.Now.ToString(culture);
            label11.Text = (Convert.ToDecimal(ukupno) - (Convert.ToDecimal(ukupno) * (decimal)(5.00 / 100.00))).ToString("F");
            label12.Text = (Convert.ToDecimal(ukupno) * (decimal)(5.00 / 100.00)).ToString("F");
            label13.Text = ukupno.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TopMost = false;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(Properties.Resources.kino, new Point(3, 0));

            e.Graphics.DrawString(label1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 160);
            e.Graphics.DrawString(label7.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 200);
            e.Graphics.DrawString(label2.Text, new Font("Broadway", 12, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 240);
            e.Graphics.DrawString(label3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 280);
            e.Graphics.DrawString(label4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 320);
            e.Graphics.DrawString(label6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 360);
            e.Graphics.DrawString("----------------------------------------------------------------", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 375);
            e.Graphics.DrawString(label5.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, Properties.Resources.kino.Height + 400);
            e.Graphics.DrawString("----------------------Obračun poreza---------------------", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 550);
            e.Graphics.DrawString("Osnovica: " + label11.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 565);
            e.Graphics.DrawString("PDV:         " + label12.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 585);
            e.Graphics.DrawString("----------------------------------------------------------------", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 600);
            e.Graphics.DrawString("Ukupno:  " + label13.Text + " kn", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 615);
            e.Graphics.DrawString("PDV se obračunava po stopi od 5%", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 100, Properties.Resources.kino.Height + 700);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
