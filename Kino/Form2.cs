using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kino
{
    public partial class Form2 : Form
    {
        SqlConnection cn = null;
        SqlDataReader reader = null;
        public Form2()
        {
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            InitializeComponent();

            PrikazFilmova();
        }

        void PrikazFilmova()
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Select ImeFilma,Slika,Redatelj,Glumci,Žanr,Trajanje,Država,PočetakPrikazivanja,Sadržaj from Filmovi WHERE PočetakPrikazivanja > getdate()", cn);
                reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    FlowLayoutPanel okvir = new FlowLayoutPanel();
                    okvir.BackColor = Color.White;
                    okvir.FlowDirection = FlowDirection.LeftToRight;
                    okvir.AutoSize = true;
                    okvir.MinimumSize = new Size(690, 0);
                    okvir.MaximumSize = new Size(690, 0);

                    FlowLayoutPanel lijevi = new FlowLayoutPanel();
                    lijevi.Size = new Size(152, 219);

                    PictureBox slika = new PictureBox();
                    slika.Size = new Size(152, 219);
                    byte[] picbyte = reader["Slika"] as byte[] ?? null;
                    if (picbyte != null)
                    {
                        MemoryStream mstream = new MemoryStream(picbyte);
                        slika.Image = Image.FromStream(mstream);
                        Bitmap bmp = new Bitmap(mstream);
                    }

                    lijevi.Controls.Add(slika);
                    okvir.Controls.Add(lijevi);

                    FlowLayoutPanel desni = new FlowLayoutPanel();
                    desni.FlowDirection = FlowDirection.TopDown;
                    desni.AutoSize = true;


                    Label naslov = new Label();
                    naslov.Text = "";
                    naslov.Text += reader["ImeFilma"];
                    naslov.AutoSize = true;
                    naslov.Font = new Font("Arial", 14, FontStyle.Bold);
                    naslov.ForeColor = ColorTranslator.FromHtml("#CC0000");
                    desni.Controls.Add(naslov);

                    Label redatelj = new Label();
                    redatelj.Text = "Redatelj: ";
                    redatelj.Text += reader["Redatelj"];
                    redatelj.AutoSize = true;
                    redatelj.Margin = new Padding(0, 10, 0, 0);
                    desni.Controls.Add(redatelj);

                    Label glumci = new Label();
                    glumci.Text = "Glumci: ";
                    glumci.Text += reader["Glumci"];
                    glumci.AutoSize = true;
                    glumci.Margin = new Padding(0, 5, 0, 0);
                    desni.Controls.Add(glumci);

                    Label žanr = new Label();
                    žanr.Text = "Žanr: ";
                    žanr.Text += reader["Žanr"];
                    žanr.AutoSize = true;
                    žanr.Margin = new Padding(0, 5, 0, 0);
                    desni.Controls.Add(žanr);

                    Label trajanje = new Label();
                    trajanje.Text = "Trajanje: ";
                    trajanje.Text += reader["Trajanje"];
                    trajanje.AutoSize = true;
                    trajanje.Margin = new Padding(0, 5, 0, 0);
                    desni.Controls.Add(trajanje);

                    Label država = new Label();
                    država.Text = "Država: ";
                    država.Text += reader["Država"];
                    država.AutoSize = true;
                    država.Margin = new Padding(0, 5, 0, 0);
                    desni.Controls.Add(država);

                    Label datum = new Label();
                    datum.Text = "Početak prikazivanja: ";
                    datum.Text += DateTime.Parse(reader["PočetakPrikazivanja"].ToString()).ToShortDateString();
                    datum.AutoSize = true;
                    datum.Margin = new Padding(0, 5, 0, 0);
                    desni.Controls.Add(datum);

                    Label sadržaj = new Label();
                    sadržaj.Text = "Sadržaj: ";
                    sadržaj.Text += reader["Sadržaj"];
                    sadržaj.AutoSize = true;
                    sadržaj.Margin = new Padding(0, 5, 0, 0);
                    sadržaj.MaximumSize = new Size(525, 0);
                    desni.Controls.Add(sadržaj);


                    okvir.Controls.Add(desni);
                    uskoro.Controls.Add(okvir);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (cn != null)
                    cn.Close();

            }

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
            uskoro.Controls.Add(kraj);

        }



        private void uskoro_MouseEnter(object sender, EventArgs e)
        {
            uskoro.Focus();
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

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trenutno_Click(object sender, EventArgs e)
        {
            Form3 Sada = new Form3();
            Sada.ShowDialog(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uskoro.Select();
        }
    }

}
