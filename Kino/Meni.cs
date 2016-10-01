using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();

            PrikaziMeni();
        }

        void PrikaziMeni()
        {
            FlowLayoutPanel okvir = new FlowLayoutPanel();
            okvir.BackColor = Color.White;
            okvir.FlowDirection = FlowDirection.LeftToRight;
            okvir.AutoSize = true;
            okvir.Margin = new Padding(3, 3, 3, 1);
            okvir.MinimumSize = new Size(690, 0);
            okvir.MaximumSize = new Size(690, 0);

            FlowLayoutPanel lijevi = new FlowLayoutPanel();
            lijevi.FlowDirection = FlowDirection.TopDown;
            lijevi.AutoSize = true;
            lijevi.MaximumSize = new Size(179, 0);
            lijevi.MinimumSize = new Size(179, 0);

            Label naslov = new Label();
            naslov.Text = "1. VIRIDIANA";
            naslov.AutoSize = true;
            naslov.Font = new Font("Arial", 14, FontStyle.Bold);
            naslov.ForeColor = ColorTranslator.FromHtml("#CC0000");
            lijevi.Controls.Add(naslov);

            Label podnaslov = new Label();
            podnaslov.Text = "Tortilla s piletinom";
            podnaslov.Font = new Font("Arial", 14, FontStyle.Italic);
            podnaslov.ForeColor = ColorTranslator.FromHtml("#CC0000");
            podnaslov.AutoSize = true;
            podnaslov.Margin = new Padding(3, 1, 0, 0);
            lijevi.Controls.Add(podnaslov);

            Label količina = new Label();
            količina.Text = "• 2 komada;";
            količina.AutoSize = true;
            količina.Margin = new Padding(0, 10, 0, 0);
            lijevi.Controls.Add(količina);

            Label sastojak1 = new Label();
            sastojak1.Text = "• pileći file 80g;";
            sastojak1.AutoSize = true;
            sastojak1.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak1);

            Label sastojak2 = new Label();
            sastojak2.Text = "• svježi sir 30g;";
            sastojak2.AutoSize = true;
            sastojak2.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak2);

            Label sastojak3 = new Label();
            sastojak3.Text = "• kukuruz 30g;";
            sastojak3.AutoSize = true;
            sastojak3.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak3);

            Label sastojak4 = new Label();
            sastojak4.Text = "• grah 30g;";
            sastojak4.AutoSize = true;
            sastojak4.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak4);

            Label sastojak5 = new Label();
            sastojak5.Text = "• svježa rajčica 30g;";
            sastojak5.AutoSize = true;
            sastojak5.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak5);

            Label sastojak6 = new Label();
            sastojak6.Text = "• zelena salata kristal 30g;";
            sastojak6.AutoSize = true;
            sastojak6.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak6);

            Label sastojak7 = new Label();
            sastojak7.Text = "• sol, papar";
            sastojak7.AutoSize = true;
            sastojak7.Margin = new Padding(0, 5, 0, 0);
            lijevi.Controls.Add(sastojak7);

            FlowLayoutPanel desni = new FlowLayoutPanel();
            desni.Size = new Size(152, 219);
            desni.Margin = new Padding(3, 0, 0, 3);

            PictureBox slika = new PictureBox();
            slika.Size = new Size(152, 219);
            slika.Image = new Bitmap(Properties.Resources.meni1);
            slika.SizeMode = PictureBoxSizeMode.CenterImage;
            desni.Controls.Add(slika);

            okvir.Controls.Add(lijevi);
            okvir.Controls.Add(desni);

            FlowLayoutPanel lijevi2 = new FlowLayoutPanel();
            lijevi2.Margin = new Padding(10, 3, 3, 3);
            lijevi2.FlowDirection = FlowDirection.TopDown;
            lijevi2.AutoSize = true;
            lijevi2.MaximumSize = new Size(179, 0);
            lijevi2.MinimumSize = new Size(179, 0);

            Label naslov2 = new Label();
            naslov2.Text = "2. A FISH WANDA";
            naslov2.AutoSize = true;
            naslov2.Font = new Font("Arial", 14, FontStyle.Bold);
            naslov2.ForeColor = ColorTranslator.FromHtml("#CC0000");
            lijevi2.Controls.Add(naslov2);

            Label podnaslov2 = new Label();
            podnaslov2.Text = "Toast of tune";
            podnaslov2.Font = new Font("Arial", 14, FontStyle.Italic);
            podnaslov2.ForeColor = ColorTranslator.FromHtml("#CC0000");
            podnaslov2.AutoSize = true;
            podnaslov2.Margin = new Padding(3, 1, 0, 0);
            lijevi2.Controls.Add(podnaslov2);

            Label količina2 = new Label();
            količina2.Text = "• 4 komada;";
            količina2.AutoSize = true;
            količina2.Margin = new Padding(0, 10, 0, 0);
            lijevi2.Controls.Add(količina2);

            Label sastojak12 = new Label();
            sastojak12.Text = "• tuna 80g;";
            sastojak12.AutoSize = true;
            sastojak12.Margin = new Padding(0, 5, 0, 0);
            lijevi2.Controls.Add(sastojak12);

            Label sastojak22 = new Label();
            sastojak22.Text = "• toast kruh(bijelo brašno) 60g;";
            sastojak22.AutoSize = true;
            sastojak22.Margin = new Padding(0, 5, 0, 0);
            lijevi2.Controls.Add(sastojak22);

            Label sastojak32 = new Label();
            sastojak32.Text = "• vrhnje 20g;";
            sastojak32.AutoSize = true;
            sastojak32.Margin = new Padding(0, 5, 0, 0);
            lijevi2.Controls.Add(sastojak32);

            Label sastojak42 = new Label();
            sastojak42.Text = "• jaja, sol, papar, maslinovo ulje, luk;";
            sastojak42.AutoSize = true;
            sastojak42.Margin = new Padding(0, 5, 0, 0);
            lijevi2.Controls.Add(sastojak42);

            Label sastojak52 = new Label();
            sastojak52.Text = "• umak od vrhnja s ketchupom";
            sastojak52.AutoSize = true;
            sastojak52.Margin = new Padding(0, 5, 0, 0);
            lijevi2.Controls.Add(sastojak52);

            FlowLayoutPanel desni2 = new FlowLayoutPanel();
            desni2.Size = new Size(152, 219);
            desni2.Margin = new Padding(3, 0, 0, 3);

            PictureBox slika2 = new PictureBox();
            slika2.Size = new Size(152, 219);
            slika2.Image = new Bitmap(Properties.Resources.meni2);
            slika2.SizeMode = PictureBoxSizeMode.CenterImage;
            desni2.Controls.Add(slika2);

            okvir.Controls.Add(lijevi2);
            okvir.Controls.Add(desni2);

            FlowLayoutPanel okvir2 = new FlowLayoutPanel();
            okvir2.BackColor = Color.White;
            okvir2.FlowDirection = FlowDirection.LeftToRight;
            okvir2.AutoSize = true;
            okvir2.Margin = new Padding(3, 0, 3, 1);
            okvir2.MinimumSize = new Size(690, 0);
            okvir2.MaximumSize = new Size(690, 0);

            FlowLayoutPanel lijevi3 = new FlowLayoutPanel();
            lijevi3.FlowDirection = FlowDirection.TopDown;
            lijevi3.AutoSize = true;
            lijevi3.MaximumSize = new Size(179, 0);
            lijevi3.MinimumSize = new Size(179, 0);

            Label naslov3 = new Label();
            naslov3.Text = "3. SHANGAI";
            naslov3.AutoSize = true;
            naslov3.Font = new Font("Arial", 14, FontStyle.Bold);
            naslov3.ForeColor = ColorTranslator.FromHtml("#CC0000");
            lijevi3.Controls.Add(naslov3);

            Label podnaslov3 = new Label();
            podnaslov3.Text = "Spring Rolls";
            podnaslov3.Font = new Font("Arial", 14, FontStyle.Italic);
            podnaslov3.ForeColor = ColorTranslator.FromHtml("#CC0000");
            podnaslov3.AutoSize = true;
            podnaslov3.Margin = new Padding(3, 1, 0, 0);
            lijevi3.Controls.Add(podnaslov3);

            Label količina3 = new Label();
            količina3.Text = "• 7 komada;";
            količina3.AutoSize = true;
            količina3.Margin = new Padding(0, 10, 0, 0);
            lijevi3.Controls.Add(količina3);

            Label sastojak13 = new Label();
            sastojak13.Text = "• filo tijesto 60g;";
            sastojak13.AutoSize = true;
            sastojak13.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak13);

            Label sastojak23 = new Label();
            sastojak23.Text = "• mrkva 20g;";
            sastojak23.AutoSize = true;
            sastojak23.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak23);

            Label sastojak33 = new Label();
            sastojak33.Text = "• poriluk 20g;";
            sastojak33.AutoSize = true;
            sastojak33.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak33);

            Label sastojak43 = new Label();
            sastojak43.Text = "• kupus 20g;";
            sastojak43.AutoSize = true;
            sastojak43.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak43);

            Label sastojak53 = new Label();
            sastojak53.Text = "• zelena salata 20g;";
            sastojak53.AutoSize = true;
            sastojak53.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak53);

            Label sastojak63 = new Label();
            sastojak63.Text = "• svježa rajčica 10g;";
            sastojak63.AutoSize = true;
            sastojak63.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak63);

            Label sastojak73 = new Label();
            sastojak73.Text = "• slatko kiseli umak s chilly                   papričicom";
            sastojak73.AutoSize = true;
            sastojak73.Margin = new Padding(0, 5, 0, 0);
            lijevi3.Controls.Add(sastojak73);

            FlowLayoutPanel desni3 = new FlowLayoutPanel();
            desni3.Size = new Size(152, 219);
            desni3.Margin = new Padding(3, 0, 0, 3);

            PictureBox slika3 = new PictureBox();
            slika3.Size = new Size(152, 219);
            slika3.Image = new Bitmap(Properties.Resources.meni3);
            slika3.SizeMode = PictureBoxSizeMode.CenterImage;
            desni3.Controls.Add(slika3);

            okvir2.Controls.Add(lijevi3);
            okvir2.Controls.Add(desni3);

            FlowLayoutPanel lijevi4 = new FlowLayoutPanel();
            lijevi4.Margin = new Padding(10, 3, 3, 3);
            lijevi4.FlowDirection = FlowDirection.TopDown;
            lijevi4.AutoSize = true;
            lijevi4.MaximumSize = new Size(179, 0);
            lijevi4.MinimumSize = new Size(179, 0);

            Label naslov24 = new Label();
            naslov24.Text = "4. SABATA";
            naslov24.AutoSize = true;
            naslov24.Font = new Font("Arial", 14, FontStyle.Bold);
            naslov24.ForeColor = ColorTranslator.FromHtml("#CC0000");
            lijevi4.Controls.Add(naslov24);

            Label podnaslov24 = new Label();
            podnaslov24.Text = "Tortellini s tartufima";
            podnaslov24.Font = new Font("Arial", 14, FontStyle.Italic);
            podnaslov24.ForeColor = ColorTranslator.FromHtml("#CC0000");
            podnaslov24.AutoSize = true;
            podnaslov24.Margin = new Padding(3, 1, 0, 0);
            lijevi4.Controls.Add(podnaslov24);

            Label količina24 = new Label();
            količina24.Text = "• 4 komada;";
            količina24.AutoSize = true;
            količina24.Margin = new Padding(0, 10, 0, 0);
            lijevi4.Controls.Add(količina24);

            Label sastojak14 = new Label();
            sastojak14.Text = "• tortellini punjeni sirom 120g;";
            sastojak14.AutoSize = true;
            sastojak14.Margin = new Padding(0, 5, 0, 0);
            lijevi4.Controls.Add(sastojak14);

            Label sastojak24 = new Label();
            sastojak24.Text = "• vrhnje za kuhanje 70g;";
            sastojak24.AutoSize = true;
            sastojak24.Margin = new Padding(0, 5, 0, 0);
            lijevi4.Controls.Add(sastojak24);

            Label sastojak34 = new Label();
            sastojak34.Text = "• ulje s tartufima 1g;";
            sastojak34.AutoSize = true;
            sastojak34.Margin = new Padding(0, 5, 0, 0);
            lijevi4.Controls.Add(sastojak34);

            Label sastojak44 = new Label();
            sastojak44.Text = "• maslac 5g;";
            sastojak44.AutoSize = true;
            sastojak44.Margin = new Padding(0, 5, 0, 0);
            lijevi4.Controls.Add(sastojak44);

            Label sastojak54 = new Label();
            sastojak54.Text = "• začini 2g;";
            sastojak54.AutoSize = true;
            sastojak54.Margin = new Padding(0, 5, 0, 0);
            lijevi4.Controls.Add(sastojak54);

            Label sastojak64 = new Label();
            sastojak64.Text = "• pržene sjemenke 20g";
            sastojak64.AutoSize = true;
            sastojak64.Margin = new Padding(0, 5, 0, 0);
            lijevi4.Controls.Add(sastojak64);

            FlowLayoutPanel desni4 = new FlowLayoutPanel();
            desni4.Size = new Size(152, 219);
            desni4.Margin = new Padding(3, 0, 0, 3);

            PictureBox slika4 = new PictureBox();
            slika4.Size = new Size(152, 219);
            slika4.Image = new Bitmap(Properties.Resources.meni4);
            slika4.SizeMode = PictureBoxSizeMode.CenterImage;
            desni4.Controls.Add(slika4);

            okvir2.Controls.Add(lijevi4);
            okvir2.Controls.Add(desni4);

            FlowLayoutPanel okvir3 = new FlowLayoutPanel();
            okvir3.BackColor = Color.White;
            okvir3.FlowDirection = FlowDirection.LeftToRight;
            okvir3.AutoSize = true;
            okvir3.Margin = new Padding(3, 0, 3, 1);
            okvir3.MinimumSize = new Size(690, 0);
            okvir3.MaximumSize = new Size(690, 0);

            FlowLayoutPanel lijevi5 = new FlowLayoutPanel();
            lijevi5.FlowDirection = FlowDirection.TopDown;
            lijevi5.AutoSize = true;
            lijevi5.MaximumSize = new Size(179, 0);
            lijevi5.MinimumSize = new Size(179, 0);

            Label naslov5 = new Label();
            naslov5.Text = "5. EL GRECO";
            naslov5.AutoSize = true;
            naslov5.Font = new Font("Arial", 14, FontStyle.Bold);
            naslov5.ForeColor = ColorTranslator.FromHtml("#CC0000");
            lijevi5.Controls.Add(naslov5);

            Label podnaslov5 = new Label();
            podnaslov5.Text = "Mesne okruglice";
            podnaslov5.Font = new Font("Arial", 14, FontStyle.Italic);
            podnaslov5.ForeColor = ColorTranslator.FromHtml("#CC0000");
            podnaslov5.AutoSize = true;
            podnaslov5.Margin = new Padding(3, 1, 0, 0);
            lijevi5.Controls.Add(podnaslov5);

            Label količina5 = new Label();
            količina5.Text = "• 6 komada;";
            količina5.AutoSize = true;
            količina5.Margin = new Padding(0, 10, 0, 0);
            lijevi5.Controls.Add(količina5);

            Label sastojak15 = new Label();
            sastojak15.Text = "• mljeveno meso 140g                         (svinjetina, junetina);";
            sastojak15.AutoSize = true;
            sastojak15.Margin = new Padding(0, 5, 0, 0);
            lijevi5.Controls.Add(sastojak15);

            Label sastojak25 = new Label();
            sastojak25.Text = "• jaja 20g;";
            sastojak25.AutoSize = true;
            sastojak25.Margin = new Padding(0, 5, 0, 0);
            lijevi5.Controls.Add(sastojak25);

            Label sastojak35 = new Label();
            sastojak35.Text = "• krušne mrvice 20g;";
            sastojak35.AutoSize = true;
            sastojak35.Margin = new Padding(0, 5, 0, 0);
            lijevi5.Controls.Add(sastojak35);

            Label sastojak45 = new Label();
            sastojak45.Text = "• sol, papar, majčina dušica";
            sastojak45.AutoSize = true;
            sastojak45.Margin = new Padding(0, 5, 0, 0);
            lijevi5.Controls.Add(sastojak45);


            FlowLayoutPanel desni5 = new FlowLayoutPanel();
            desni5.Size = new Size(152, 219);
            desni5.Margin = new Padding(3, 0, 0, 3);

            PictureBox slika33 = new PictureBox();
            slika33.Size = new Size(152, 219);
            slika33.Image = new Bitmap(Properties.Resources.meni5);
            slika33.SizeMode = PictureBoxSizeMode.CenterImage;
            desni5.Controls.Add(slika33);

            okvir3.Controls.Add(lijevi5);
            okvir3.Controls.Add(desni5);

            FlowLayoutPanel lijevi6 = new FlowLayoutPanel();
            lijevi6.Margin = new Padding(10, 3, 3, 3);
            lijevi6.FlowDirection = FlowDirection.TopDown;
            lijevi6.AutoSize = true;
            lijevi6.MaximumSize = new Size(179, 0);
            lijevi6.MinimumSize = new Size(179, 0);

            Label naslov6 = new Label();
            naslov6.Text = "6. AMARCORD";
            naslov6.AutoSize = true;
            naslov6.Font = new Font("Arial", 14, FontStyle.Bold);
            naslov6.ForeColor = ColorTranslator.FromHtml("#CC0000");
            lijevi6.Controls.Add(naslov6);

            Label podnaslov6 = new Label();
            podnaslov6.Text = "Bruschetta";
            podnaslov6.Font = new Font("Arial", 14, FontStyle.Italic);
            podnaslov6.ForeColor = ColorTranslator.FromHtml("#CC0000");
            podnaslov6.AutoSize = true;
            podnaslov6.Margin = new Padding(3, 1, 0, 0);
            lijevi6.Controls.Add(podnaslov6);

            Label količina6 = new Label();
            količina6.Text = "• 3 komada;";
            količina6.AutoSize = true;
            količina6.Margin = new Padding(0, 10, 0, 0);
            lijevi6.Controls.Add(količina6);

            Label sastojak16 = new Label();
            sastojak16.Text = "• kruh 80g;";
            sastojak16.AutoSize = true;
            sastojak16.Margin = new Padding(0, 5, 0, 0);
            lijevi6.Controls.Add(sastojak16);

            Label sastojak26 = new Label();
            sastojak26.Text = "• pršut 30g;";
            sastojak26.AutoSize = true;
            sastojak26.Margin = new Padding(0, 5, 0, 0);
            lijevi6.Controls.Add(sastojak26);

            Label sastojak36 = new Label();
            sastojak36.Text = "• svježa rajčica 30g;";
            sastojak36.AutoSize = true;
            sastojak36.Margin = new Padding(0, 5, 0, 0);
            lijevi6.Controls.Add(sastojak36);

            Label sastojak46 = new Label();
            sastojak46.Text = "• mozzarella 30g;";
            sastojak46.AutoSize = true;
            sastojak46.Margin = new Padding(0, 5, 0, 0);
            lijevi6.Controls.Add(sastojak46);

            Label sastojak56 = new Label();
            sastojak56.Text = "• masline 10g;";
            sastojak56.AutoSize = true;
            sastojak56.Margin = new Padding(0, 5, 0, 0);
            lijevi6.Controls.Add(sastojak56);

            Label sastojak57 = new Label();
            sastojak57.Text = "• sol, papar, maslinovo ulje, češnjak";
            sastojak57.AutoSize = true;
            sastojak57.Margin = new Padding(0, 5, 0, 0);
            lijevi6.Controls.Add(sastojak57);

            FlowLayoutPanel desni6 = new FlowLayoutPanel();
            desni6.Size = new Size(152, 219);
            desni6.Margin = new Padding(3, 0, 0, 3);

            PictureBox slika6 = new PictureBox();
            slika6.Size = new Size(152, 219);
            slika6.Image = new Bitmap(Properties.Resources.meni6);
            slika6.SizeMode = PictureBoxSizeMode.CenterImage;
            desni6.Controls.Add(slika6);

            okvir3.Controls.Add(lijevi6);
            okvir3.Controls.Add(desni6);

            flowLayoutPanel1.Controls.Add(okvir);
            flowLayoutPanel1.Controls.Add(okvir2);
            flowLayoutPanel1.Controls.Add(okvir3);


            FlowLayoutPanel kraj = new FlowLayoutPanel();
            kraj.BackColor = Color.Transparent;
            kraj.FlowDirection = FlowDirection.RightToLeft;
            kraj.AutoSize = true;
            kraj.MinimumSize = new Size(690, 0);
            kraj.MaximumSize = new Size(690, 0);

            Button nazad = new Button();
            nazad.Text = "Natrag";
            nazad.Name = "Izlaz";
            nazad.BackColor = Color.White;
            nazad.AutoSize = true;
            nazad.MinimumSize = new Size(165, 0);
            nazad.Font = new Font("Arial", 14, FontStyle.Bold);
            nazad.ForeColor = ColorTranslator.FromHtml("#CC0000");
            nazad.Margin = new Padding(30, 15, 0, 0);
            nazad.FlatStyle = FlatStyle.Flat;
            nazad.FlatAppearance.BorderSize = 0;
            nazad.Click += new EventHandler(Nazad_Click);

            kraj.Controls.Add(nazad);
            flowLayoutPanel1.Controls.Add(kraj);
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Meni_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Select();
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }
    }
}