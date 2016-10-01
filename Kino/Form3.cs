using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form3 : Form
    {
        SqlConnection cn = null;
        SqlConnection cn2 = null;
        SqlConnection cn3 = null;
        SqlConnection cn4 = null;
        SqlConnection cn5 = null;
        SqlDataReader reader = null;
        SqlDataReader reader2 = null;
        SqlDataReader reader3 = null;
        int broj;

        bool postoji;
        public Form3()
        {
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn2 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn3 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn4 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn5 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            InitializeComponent();

            PrikazFilmova(0);
        }

        void PrikazFilmova(int dan)
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Select DISTINCT Filmovi.ImeFilma,Filmovi.Slika,Filmovi.Redatelj,Filmovi.Glumci,Filmovi.Žanr,Filmovi.Trajanje,Filmovi.Država,Filmovi.PočetakPrikazivanja,Filmovi.Sadržaj from Filmovi LEFT JOIN Termini ON Filmovi.ImeFilma=Termini.ImeFilma WHERE Termini.DatumPrikazivanja = cast( dateadd(day,@dani,getdate()) as date)", cn);
                cm.Parameters.Add("@dani", SqlDbType.Int);
                cm.Parameters["@dani"].Value = dan;
                reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    postoji = false;
                    FlowLayoutPanel okvir = new FlowLayoutPanel();
                    okvir.BackColor = Color.White;
                    okvir.FlowDirection = FlowDirection.LeftToRight;
                    okvir.Margin = new Padding(0, 7, 0, 0);
                    okvir.Padding = new Padding(0, 0, 0, 10);
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
                    trenutno.Controls.Add(okvir);

                    try
                    {
                        cn2.Open();
                        SqlCommand cm2 = new SqlCommand("Select DISTINCT ImeDvorane FROM Termini WHERE ImeFilma=@ime", cn2);
                        cm2.Parameters.Add("@ime", SqlDbType.VarChar);
                        cm2.Parameters["@ime"].Value = reader["ImeFilma"].ToString();
                        reader2 = cm2.ExecuteReader();

                        while (reader2.Read())
                        {
                            FlowLayoutPanel termini = new FlowLayoutPanel();
                            termini.BackColor = Color.White;
                            termini.FlowDirection = FlowDirection.LeftToRight;
                            termini.AutoSize = true;
                            termini.Margin = new Padding(0);
                            termini.MinimumSize = new Size(690, 0);
                            termini.MaximumSize = new Size(690, 0);

                            Label dvorana = new Label();
                            dvorana.Text = "";
                            dvorana.TextAlign = ContentAlignment.MiddleRight;
                            dvorana.Margin = new Padding(0, 0, 3, 1);
                            dvorana.Size = new Size(155, 25);
                            dvorana.Font = new Font("Arial", 10, FontStyle.Bold);
                            dvorana.ForeColor = ColorTranslator.FromHtml("#220000");
                            dvorana.BackColor = Color.Coral;
                            dvorana.Text += reader2["ImeDvorane"];
                            termini.Controls.Add(dvorana);

                            try
                            {
                                cn3.Open();
                                string ime2 = reader2["ImeDvorane"].ToString();
                                string ime3 = reader["ImeFilma"].ToString();
                                SqlCommand cm3 = new SqlCommand("Select DISTINCT Sat, Id FROM Termini WHERE ImeDvorane=@ime2 AND ImeFilma=@ime3 AND DatumPrikazivanja = cast( dateadd(day,@dani,getdate()) as date)", cn3);
                                cm3.Parameters.Add("@ime2", SqlDbType.VarChar);
                                cm3.Parameters["@ime2"].Value = reader2["ImeDvorane"].ToString();
                                cm3.Parameters.Add("@ime3", SqlDbType.VarChar);
                                cm3.Parameters["@ime3"].Value = reader["ImeFilma"].ToString();
                                cm3.Parameters.Add("@dani", SqlDbType.Int);
                                cm3.Parameters["@dani"].Value = dan;
                                reader3 = cm3.ExecuteReader();

                                while (reader3.Read())
                                {
                                    int cnt = 0;
                                    try
                                    {

                                        cn4.Open();
                                        SqlCommand cm4 = new SqlCommand("Select COUNT(IdZauzetosti) FROM Zauzetost INNER JOIN Sjedala ON Zauzetost.IdSjedala=Sjedala.IdSjedala WHERE ImeDvorane=@ImeDvor AND IdTermina=@Id", cn4);
                                        cm4.Parameters.Add("@ImeDvor", SqlDbType.VarChar);
                                        cm4.Parameters["@ImeDvor"].Value = ime2.Trim();
                                        cm4.Parameters.Add("@Id", SqlDbType.Int);
                                        cm4.Parameters["@Id"].Value = reader3["Id"];

                                        cnt = (int)cm4.ExecuteScalar();
                                    }
                                    catch (Exception e)
                                    {
                                        MessageBox.Show(e.ToString());
                                    }
                                    finally
                                    {
                                        if (cn4 != null)
                                            cn4.Close();
                                    }

                                    MyButton sat = new MyButton(ime3.Trim(), ime2.Trim(), DateTime.Now.AddDays(dan));

                                    try
                                    {
                                        cn5.Open();
                                        SqlCommand cm5 = new SqlCommand("Select BrojSjedala FROM Dvorane WHERE ImeDvorane=@ImeDvor", cn5);
                                        cm5.Parameters.Add("@ImeDvor", SqlDbType.VarChar);
                                        cm5.Parameters["@ImeDvor"].Value = ime2.Trim();

                                        if (cnt == (int)cm5.ExecuteScalar())
                                        {
                                            sat.BackColor = Color.Firebrick;
                                            sat.FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                            sat.Flag = true;

                                        }

                                        else
                                        {
                                            sat.BackColor = Color.Coral;
                                            sat.FlatAppearance.MouseOverBackColor = Color.LightGreen;
                                        }
                                    }

                                    catch (Exception f)
                                    {
                                        MessageBox.Show(f.ToString());
                                    }
                                    finally
                                    {
                                        if (cn5 != null)
                                            cn5.Close();
                                    }


                                    sat.Text = "";
                                    sat.TextAlign = ContentAlignment.MiddleCenter;
                                    sat.FlatStyle = FlatStyle.Flat;
                                    sat.FlatAppearance.BorderSize = 0;
                                    

                                    sat.UseCompatibleTextRendering = true;

                                    sat.Margin = new Padding(0, 0, 1, 1);
                                    sat.Size = new Size(60, 25);

                                    sat.Font = new Font("Arial", 10, FontStyle.Bold);
                                    sat.ForeColor = ColorTranslator.FromHtml("#220000");
                                    sat.Text += reader3["Sat"];
                                    sat.Click += Sat_Click;
                                    if (dan == 0)
                                    {
                                        string vrijeme = DateTime.Now.Hour.ToString();

                                        if (sat.Text.CompareTo(vrijeme) > 0)
                                        {
                                            termini.Controls.Add(sat);
                                        }
                                    }
                                    else
                                        termini.Controls.Add(sat);
                                }
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.ToString());
                            }
                            finally
                            {
                                if (reader3 != null)
                                    reader3.Close();

                                if (cn3 != null)
                                    cn3.Close();

                            }
                            if (termini.Controls.Count > 1)
                            {
                                trenutno.Controls.Add(termini);
                                postoji = true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                    finally
                    {
                        if (reader2 != null)
                            reader2.Close();

                        if (cn2 != null)
                            cn2.Close();

                    }
                    if (postoji == false)
                    {
                        okvir.Dispose();
                    }
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
        }


        private void Sat_Click(object sender, EventArgs e)
        {
            if (((MyButton)sender).Flag) { MessageBox.Show("Nema slobodnih mjesta!"); }

            else
            {
                switch (((MyButton)sender).Dvorana)
                {
                    case "Real3D":
                        DateTime dt = new DateTime(((MyButton)sender).Datum.Year, ((MyButton)sender).Datum.Month, ((MyButton)sender).Datum.Day);
                        Real3D real3d = new Real3D(((MyButton)sender).ImeFilma, dt, ((MyButton)sender).Text.Trim());
                        
                        real3d.ShowDialog();
                        break;
                    case "GoldClass":
                        DateTime dt1 = new DateTime(((MyButton)sender).Datum.Year, ((MyButton)sender).Datum.Month, ((MyButton)sender).Datum.Day);
                        GoldClass goldClass = new GoldClass(((MyButton)sender).ImeFilma, dt1, ((MyButton)sender).Text.Trim());
                        
                        goldClass.ShowDialog();
                        break;
                    case "Auro4K":
                        DateTime dt2 = new DateTime(((MyButton)sender).Datum.Year, ((MyButton)sender).Datum.Month, ((MyButton)sender).Datum.Day);
                        Auro4K auro4K = new Auro4K(((MyButton)sender).ImeFilma, dt2, ((MyButton)sender).Text.Trim());
                        
                        auro4K.ShowDialog();
                        break;
                    case "Extreme":
                        DateTime dt3 = new DateTime(((MyButton)sender).Datum.Year, ((MyButton)sender).Datum.Month, ((MyButton)sender).Datum.Day);
                        Extreme extreme = new Extreme(((MyButton)sender).ImeFilma, dt3, ((MyButton)sender).Text.Trim());
                        
                        extreme.ShowDialog();
                        break;
                    case "Imax":
                        DateTime dt4 = new DateTime(((MyButton)sender).Datum.Year, ((MyButton)sender).Datum.Month, ((MyButton)sender).Datum.Day);
                        Imax imax = new Imax(((MyButton)sender).ImeFilma, dt4, ((MyButton)sender).Text.Trim());
                        
                        imax.ShowDialog();
                        break;

                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            trenutno.Select();
            int dan = (int)DateTime.Now.DayOfWeek;
            switch (dan)
            {
                case 0:
                    button2.Text = "Pon";
                    button3.Text = "Uto";
                    button4.Text = "Sri";
                    button5.Text = "Čet";
                    button6.Text = "Pet";
                    button7.Text = "Sub";
                    button1.Text = "Ned";
                    break;
                case 1:
                    button1.Text = "Pon";
                    button2.Text = "Uto";
                    button3.Text = "Sri";
                    button4.Text = "Čet";
                    button5.Text = "Pet";
                    button6.Text = "Sub";
                    button7.Text = "Ned";
                    break;
                case 2:
                    button7.Text = "Pon";
                    button1.Text = "Uto";
                    button2.Text = "Sri";
                    button3.Text = "Čet";
                    button4.Text = "Pet";
                    button5.Text = "Sub";
                    button6.Text = "Ned";
                    break;
                case 3:
                    button6.Text = "Pon";
                    button7.Text = "Uto";
                    button1.Text = "Sri";
                    button2.Text = "Čet";
                    button3.Text = "Pet";
                    button4.Text = "Sub";
                    button5.Text = "Ned";
                    break;
                case 4:
                    button5.Text = "Pon";
                    button6.Text = "Uto";
                    button7.Text = "Sri";
                    button1.Text = "Čet";
                    button2.Text = "Pet";
                    button3.Text = "Sub";
                    button4.Text = "Ned";
                    break;
                case 5:
                    button4.Text = "Pon";
                    button5.Text = "Uto";
                    button6.Text = "Sri";
                    button7.Text = "Čet";
                    button1.Text = "Pet";
                    button2.Text = "Sub";
                    button3.Text = "Ned";
                    break;
                case 6:
                    button3.Text = "Pon";
                    button4.Text = "Uto";
                    button5.Text = "Sri";
                    button6.Text = "Čet";
                    button7.Text = "Pet";
                    button1.Text = "Sub";
                    button2.Text = "Ned";
                    break;

            }
        }

        private void trenutno_MouseEnter(object sender, EventArgs e)
        {
            trenutno.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 0;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 1;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 2;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 3;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 4;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 5;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            broj = 6;
            PrikazFilmova(broj);
            trenutno.Select();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            trenutno.Controls.Clear();
            PrikazFilmova(broj);
        }
    }


    public class MyButton : Button
    {
        string imeFilma;
        string dvorana;
        DateTime datum;
        bool flag;
        public MyButton() : base() { }
        public MyButton(string _imeFilma, string _dvorana, DateTime _datum) : base()
        {
            imeFilma = _imeFilma;
            dvorana = _dvorana;
            datum = _datum;
            flag = false;
        }

        public string ImeFilma
        {
            get { return imeFilma; }
        }

        public string Dvorana
        {
            get { return dvorana; }
        }

        public DateTime Datum
        {
            get { return datum; }
        }

        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}