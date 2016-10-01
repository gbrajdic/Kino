using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;

namespace Kino
{
    public partial class Dvorane : Form
    {
        SqlConnection cn = null;
        SqlConnection cn2 = null;
        SqlConnection cn3 = null;
        SqlConnection cn4 = null;
        SqlConnection cn5 = null;
        
        SqlDataReader reader = null;
        SqlDataReader reader2 = null;
        SqlDataReader reader3 = null;
        Label opis;
        Label opis2;
        Label opis3;
        Label opis4;
        Label opis5;
        Button meni;
        string imed = "Auro4K";

        public Dvorane()
        {
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn2 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn3 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn4 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn5 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            
            InitializeComponent();

            opis = new Label();
            opis.AutoSize = false;
            opis.Size = new Size(604, 354);
            opis.BackColor = Color.LightSalmon;
            opis.Font = new Font("Verdana", 10, FontStyle.Bold);
            opis.Padding = new Padding(10);
            opis.Location = new Point(29, 60);
            opis.Anchor = AnchorStyles.None;
            opis.Text = "Novi istinski nevjerojatan 3D kino zvuk!\n\nPrirodniji i intenzivniji od bilo kojeg drugog formata.Kao i drugi audio sustavi na tržištu – stereo, surround 5.1.i 7.1. – Auro 11.1 je audio tehnologija bazirana na kanalima.Auro 11.1 pretvara surround zvuk u potpuno virtualno iskustvo 3D zvuka, pri čemu zvukovi dolaze iz čak 11 smjerova te prikazuje filmove i do nevjerojatne brzine od 60 sličica u sekundi.\n \nProjektiran je na tri prostorne osi -širina, dubina i visina - umjesto na dvije osi tradicionalnog surround zvuka.Ova tehnologija gledatelju omogućuje prirodniju i realniju percepciju zvuka.\n \nU prirodi je slušatelj sa svih strana okružen akustičnim refleksijama koje su neophodne da ljudski mozak spontano i ispravno postavi zvučne izvore. To je temeljna razlika 3D  i 2D audio sustava. 3D audio sustav omogućava gledatelju potpuni doživljaj zvučnih efekata što rezultira iznimno intenzivnim doživljajem!";
            this.Controls.Add(opis);
            opis.Hide();

            opis2 = new Label();
            opis2.AutoSize = false;
            opis2.Size = new Size(604, 354);
            opis2.BackColor = Color.LightSalmon;
            opis2.Font = new Font("Verdana", 10, FontStyle.Bold);
            opis2.Padding = new Padding(10);
            opis2.Location = new Point(29, 60);
            opis2.Anchor = AnchorStyles.None;
            opis2.Text = "Čisti adrenalin – EXtreme ! Veće platno, jači zvuk, jači doživljaj!\n \nEkskluzivan standard za ljubitelje uzbuđenja i posebnog filmskog doživljaja. Audiovizualno iskustvo gledanja najvećih blockbuster  filmova u našim eXtreme dvoranama će u vama zasigurno potaknuti lučenje adrenalina i val uzbuđenja koji ga prati.\n\nRiječ je o dosad tehnički najbolje opremljenim, tzv. ultimativnim kinodvoranama, koje omogućuju  gledateljima ne samo da uživaju u filmu, već i da svim svojim osjetilima budu dio istoga.\n\nTEHNOLOGIJA\nZa razliku od redovnih kinodvorana,  eXtreme dvorane odlikuju se sljedećim karakteristikama:\n• Nevjerojatno čist zvuk donose najmoderniji JBL zvučni sustav na svijetu\n• Gigantska filmska platna premazana srebrom specijalno su dizajnirana kako bi se povećala količina svjetla koje se reflektira u publiku\n• RealD 3D uz najmodernije polarizirane 3D naočale";
            this.Controls.Add(opis2);
            opis2.Hide();

            opis3 = new Label();
            opis3.AutoSize = false;
            opis3.Size = new Size(604, 354);
            opis3.BackColor = Color.LightSalmon;
            opis3.Font = new Font("Verdana", 10, FontStyle.Bold);
            opis3.Padding = new Padding(10);
            opis3.Location = new Point(29, 60);
            opis3.Anchor = AnchorStyles.None;
            opis3.Text = "GOLD CLASS - privatna usluga!\n\nU cijenu Vaše ulaznice uključen je jedan meni koji ćete izabrati prilikom kupnje ulaznica, a koji će Vam konobar servirati prije početka filma, za vrijeme trajanja filmskih trailera.Na svakom stoliću nalazi se tipka kojom možete pozvati naše ljubazno osoblje u bilo kojem trenutku za vrijeme filmske projekcije ako želite naručiti i nešto drugo. Uživajte u vrhunskim vinima i koktelima, brižno osmišljenim Gold Class menuima pripravljenim od svježih i biranih namirnica te slasnim desertima.Naručenu hranu servirat ćemo Vam na Vašem stoliću.\n\nOSTALE POSEBNOSTI:\n• Zaseban pult sa Concierge-om, vrhunski opremljen lobby bar\n• Garderoba\n• Gold Class fotelje umjesto regularnih sjedala u dvorani\n• Elektronički podesive fotelje(posjetitelj sam regulira položaj)\n• Stolić za hranu između fotelja\n• Pretinac za osobne stvari";
            opis3.MouseLeave += new EventHandler(this.opis3_MouseLeave);
            opis3.MouseEnter += new EventHandler(this.opis3_MouseEnter);
            meni = new Button();
            meni.AutoSize = true;
            meni.Location = new Point(15, 320);
            meni.Text = "Izbor Gold Class menu-a";
            meni.Click += new EventHandler(this.meni_Click);
            opis3.Controls.Add(meni);
            this.Controls.Add(opis3);
            opis3.Hide();

            opis4 = new Label();
            opis4.AutoSize = false;
            opis4.Size = new Size(604, 354);
            opis4.BackColor = Color.LightSalmon;
            opis4.Font = new Font("Verdana", 10, FontStyle.Bold);
            opis4.Padding = new Padding(10);
            opis4.Location = new Point(29, 60);
            opis4.Anchor = AnchorStyles.None;
            opis4.Text = "Veća slika. Bolji zvuk. Oštriji 3D.\n\nIMAX tehnologija kombinira različite tehnološke inovacije: specijalne kamere i projektore, specijalna divovska platna i posebno dizajnirane dvorane. IMAX je najveći i najuzbudljiviji filmski format na svijetu tako da se danas filmovi za IMAX kina snimaju na poseban način.\n\nUpravo zbog vrhunskog načina na koji se danas snimaju filmovi, u IMAX dvoranama potrebna su čak dva projektora kako bi gledatelj u potpunosti mogao uživati u svim kvalitetama IMAX filma.Dimenzije IMAX® platna su 24,3 x 13,7 metara (333m2) što ga čini uvjerljivo najvećim filmskim platnom u Hrvatskoj, te jednim od većih digitalnih platna u Europi.\n\nIMAX sustav podešava se kalibracijom koja omogućava sustavu da postigne apsolutno savršen skald između slike, zvuka i svjetla.Kristalno čista slika, laserski precizan digitalni zvuk, najoštriji 3D elementi su savršenog doživljaja filma koji se može iskusiti samo u IMAX kinu!Inovativna audio tehnologija omogućava da slušajući doživite i vidite snagu IMAX-a.";
            this.Controls.Add(opis4);
            opis4.Hide();

            opis5 = new Label();
            opis5.AutoSize = false;
            opis5.Size = new Size(604, 354);
            opis5.BackColor = Color.LightSalmon;
            opis5.Font = new Font("Verdana", 10, FontStyle.Bold);
            opis5.Padding = new Padding(10);
            opis5.Location = new Point(29, 60);
            opis5.Anchor = AnchorStyles.None;
            opis5.Text = "3D - toliko stvaran da je nestvaran!\n\nRealD 3D je nova generacija zabave sa svježim, bistrim, ultrarealističnim slikama koje su tako stvarne da imate osjećaj da ste zakoračili u film. RealD 3D dodaje dubinu koja vas uvodi u samu akciju bez obzira na to jeste li krenuli na putovanje u neku neotkrivenu zemlju ili izbjegavate predmete koji s ekrana izlijeću u kino.\n\nRealD 3D tehnologija bila je uvod u današnju digitalnu 3D tehnologiju i danas je najrasprostranjenija 3D kino tehnologija. RealD 3D je 100% digitalna tehnologija, tako da vam svaki put donosi zapanjujuće realistično i posve obuzimajuće iskustvo. I, za razliku od prijašnjih ne tako lijepih naočala, RealD 3D naočale izgledaju kao sunčane naočale, pogodne su za recikliranje i dizajnirane su tako da pristaju svim gledateljima te da se lako nose preko naočala za vid.\n\nRealD 3D je toliko napredna tehnologija da ne omogućuje samo gledanje nego i osjećanje onoga što se nalazi na ekranu. Nemojte samo gledati film, s RealD 3D tehnologijom doživite novu dimenziju zabave.";
            this.Controls.Add(opis5);
            opis5.Hide();

            PrikazFilmova(imed);
        }

        void PrikazFilmova(string imedvorane)
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Select DISTINCT Filmovi.ImeFilma,Filmovi.Slika,Filmovi.Redatelj,Filmovi.Glumci,Filmovi.Žanr,Filmovi.Trajanje,Filmovi.Država,Filmovi.PočetakPrikazivanja,Filmovi.Sadržaj from Filmovi LEFT JOIN Termini ON Filmovi.ImeFilma=Termini.ImeFilma WHERE Termini.ImeDvorane = @dvorana", cn);
                cm.Parameters.Add("@dvorana", SqlDbType.VarChar);
                cm.Parameters["@dvorana"].Value = imedvorane;
                reader = cm.ExecuteReader();

                while (reader.Read())
                {
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
                    naslov.Text += reader["ImeFilma"] + " - " + imedvorane;
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
                    dvorana.Controls.Add(okvir);

                    try
                    {
                        cn2.Open();
                        string ime = reader["ImeFilma"].ToString();
                        SqlCommand cm2 = new SqlCommand("Select DISTINCT Sat FROM Termini WHERE ImeFilma=@ime AND ImeDvorane=@ime2", cn2);
                        cm2.Parameters.Add("@ime", SqlDbType.VarChar);
                        cm2.Parameters["@ime"].Value = reader["ImeFilma"].ToString();
                        cm2.Parameters.Add("@ime2", SqlDbType.VarChar);
                        cm2.Parameters["@ime2"].Value = imedvorane;
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

                            Label sat = new Label();
                            sat.Text = "";
                            sat.TextAlign = ContentAlignment.MiddleRight;
                            sat.UseCompatibleTextRendering = true;
                            sat.Margin = new Padding(0, 0, 3, 1);
                            sat.Size = new Size(155, 25);
                            sat.Padding = new Padding(0, 0, 5, 0);
                            sat.Font = new Font("Arial", 10, FontStyle.Bold);
                            sat.ForeColor = ColorTranslator.FromHtml("#220000");
                            sat.BackColor = Color.LightSalmon;
                            decimal vrijeme = Convert.ToDecimal(reader2["Sat"], CultureInfo.InvariantCulture);
                            string vrijeme2 = vrijeme.ToString();
                            string[] vrijeme3 = vrijeme2.Split(',');
                            if (vrijeme3.Count() > 1)
                                sat.Text += vrijeme3[0] + "." + vrijeme3[1] + " h";
                            else
                                sat.Text += vrijeme3[0] + " h";
                            termini.Controls.Add(sat);

                            try
                            {
                                cn3.Open();
                                SqlCommand cm3 = new SqlCommand("Select DISTINCT DatumPrikazivanja, Id FROM Termini WHERE ImeDvorane=@ime2 AND ImeFilma=@ime3 AND Sat=@vrijeme", cn3);
                                cm3.Parameters.Add("@ime2", SqlDbType.VarChar);
                                cm3.Parameters["@ime2"].Value = imedvorane;
                                cm3.Parameters.Add("@ime3", SqlDbType.VarChar);
                                cm3.Parameters["@ime3"].Value = reader["ImeFilma"].ToString();
                                cm3.Parameters.Add("@vrijeme", SqlDbType.NChar);
                                cm3.Parameters["@vrijeme"].Value = reader2["Sat"].ToString();
                                reader3 = cm3.ExecuteReader();

                                while (reader3.Read())
                                {
                                    string d = reader3["DatumPrikazivanja"].ToString();
                                    string[] s = d.Split('.');


                                    int cnt = 0;
                                    try
                                    {

                                        cn4.Open();
                                        SqlCommand cm4 = new SqlCommand("Select COUNT(IdZauzetosti) FROM Zauzetost INNER JOIN Sjedala ON Zauzetost.IdSjedala=Sjedala.IdSjedala WHERE ImeDvorane=@ImeDvor AND IdTermina=@Id", cn4);
                                        cm4.Parameters.Add("@ImeDvor", SqlDbType.VarChar);
                                        cm4.Parameters["@ImeDvor"].Value = imedvorane.Trim();
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


                                    MyButton1 dan = new MyButton1(ime.Trim(), imedvorane, new DateTime(Convert.ToInt32(s[2]), Convert.ToInt32(s[1]), Convert.ToInt32(s[0])), reader2["Sat"].ToString().Trim());
                                   
                                    if (dan.Sat.CompareTo(DateTime.Now.Hour.ToString()) < 0 && dan.Datum.Date == DateTime.Now.Date)
                                    {
                                        dan.BackColor = Color.Firebrick;
                                        dan.FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                        dan.Enabled = false;
                                    }
                                    else
                                    {
                                        try
                                        {
                                            cn5.Open();
                                            SqlCommand cm5 = new SqlCommand("Select BrojSjedala FROM Dvorane WHERE ImeDvorane=@ImeDvor", cn5);
                                            cm5.Parameters.Add("@ImeDvor", SqlDbType.VarChar);
                                            cm5.Parameters["@ImeDvor"].Value = imedvorane.Trim();

                                            if (cnt == (int)cm5.ExecuteScalar())
                                            {
                                                dan.BackColor = Color.Firebrick;
                                                dan.FlatAppearance.MouseOverBackColor = Color.Firebrick;
                                                dan.Flag = true;

                                            }

                                            else
                                            {
                                                dan.BackColor = Color.Coral;
                                                dan.FlatAppearance.MouseOverBackColor = Color.LightGreen;
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
                                    }

                                    dan.Text = "";
                                    dan.TextAlign = ContentAlignment.MiddleCenter;
                                    dan.FlatStyle = FlatStyle.Flat;
                                    dan.FlatAppearance.BorderSize = 0;
                                    
                                    dan.UseCompatibleTextRendering = true;
                                    
                                    dan.Margin = new Padding(0, 0, 1, 1);
                                    dan.Size = new Size(60, 25);
                                    dan.Font = new Font("Arial", 10, FontStyle.Bold);
                                    dan.ForeColor = ColorTranslator.FromHtml("#220000");
                                    dan.Click += Sat_Click;
                                    dan.Text += s[0] + "." + s[1] + ".";

                                    termini.Controls.Add(dan);

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

                            dvorana.Controls.Add(termini);
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
            if (((MyButton1)sender).Flag) { MessageBox.Show("Nema slobodnih mjesta!"); }

            else
            {
                switch (((MyButton1)sender).Dvorana)
                {
                    case "Real3D":
                        DateTime dt = new DateTime(((MyButton1)sender).Datum.Year, ((MyButton1)sender).Datum.Month, ((MyButton1)sender).Datum.Day);
                        Real3D real3d = new Real3D(((MyButton1)sender).ImeFilma, dt, ((MyButton1)sender).Sat.Trim());
                        real3d.ShowDialog();
                        break;
                    case "GoldClass":
                        DateTime dt1 = new DateTime(((MyButton1)sender).Datum.Year, ((MyButton1)sender).Datum.Month, ((MyButton1)sender).Datum.Day);
                        GoldClass goldClass = new GoldClass(((MyButton1)sender).ImeFilma, dt1, ((MyButton1)sender).Sat.Trim());
                        goldClass.ShowDialog();
                        break;
                    case "Auro4K":
                        DateTime dt2 = new DateTime(((MyButton1)sender).Datum.Year, ((MyButton1)sender).Datum.Month, ((MyButton1)sender).Datum.Day);
                        Auro4K auro4K = new Auro4K(((MyButton1)sender).ImeFilma, dt2, ((MyButton1)sender).Sat.Trim());
                        auro4K.ShowDialog();
                        break;
                    case "Extreme":
                        DateTime dt3 = new DateTime(((MyButton1)sender).Datum.Year, ((MyButton1)sender).Datum.Month, ((MyButton1)sender).Datum.Day);
                        Extreme extreme = new Extreme(((MyButton1)sender).ImeFilma, dt3, ((MyButton1)sender).Sat.Trim());
                        extreme.ShowDialog();
                        break;
                    case "Imax":
                        DateTime dt4 = new DateTime(((MyButton1)sender).Datum.Year, ((MyButton1)sender).Datum.Month, ((MyButton1)sender).Datum.Day);
                        Imax imax = new Imax(((MyButton1)sender).ImeFilma, dt4, ((MyButton1)sender).Sat.Trim());
                        imax.ShowDialog();
                        break;

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dvorane_Load(object sender, EventArgs e)
        {
            dvorana.Select();
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
            opis.Hide();
            dvorana.Select();
            dvorana.Controls.Clear();
            imed = "Auro4K";
            PrikazFilmova(imed);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opis2.Hide();
            dvorana.Select();
            dvorana.Controls.Clear();
            imed = "Extreme";
            PrikazFilmova(imed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opis3.Hide();
            dvorana.Select();
            dvorana.Controls.Clear();
            imed = "GoldClass";
            PrikazFilmova(imed);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opis4.Hide();
            dvorana.Select();
            dvorana.Controls.Clear();
            imed = "Imax";
            PrikazFilmova(imed);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opis5.Hide();
            dvorana.Select();
            dvorana.Controls.Clear();
            imed = "Real3D";
            PrikazFilmova(imed);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            opis.Show();
            dvorana.SendToBack();
            opis.Focus();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            opis.Hide();
            dvorana.Select();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            opis2.Show();
            dvorana.SendToBack();
            opis2.Focus();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            opis2.Hide();
            dvorana.Select();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            opis3.Show();
            dvorana.SendToBack();
            opis3.Focus();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (this.PointToClient(MousePosition).X > opis3.Location.X + opis3.Width || this.PointToClient(MousePosition).X < opis3.Location.X || this.PointToClient(MousePosition).Y < opis3.Location.Y || this.PointToClient(MousePosition).Y > opis3.Location.Y + opis3.Height)
            {
                opis3.Hide();
                dvorana.Select();
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            opis4.Show();
            dvorana.SendToBack();
            opis4.Focus();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            opis4.Hide();
            dvorana.Select();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            opis5.Show();
            dvorana.SendToBack();
            opis5.Focus();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            opis5.Hide();
            dvorana.Select();
        }

        private void opis3_MouseLeave(object sender, EventArgs e)
        {
            var mouseLocation = Cursor.Position;
            if (meni.ClientRectangle.Contains(meni.PointToClient(Cursor.Position)) == false)
            {
                opis3.Hide();
                button3.BackColor = Color.White;
                dvorana.Select();
            }
        }

        private void opis3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightSalmon;
        }

        private void meni_Click(object sender, EventArgs e)
        {
            Meni menu = new Meni();
            menu.ShowDialog();
        }

        private void Dvorane_Activated(object sender, EventArgs e)
        {
            dvorana.Controls.Clear();
            PrikazFilmova(imed);
        }
    }

    public class MyButton1 : Button
    {
        string imeFilma;
        string dvorana;
        DateTime datum;
        string sat;
        bool flag;
        public MyButton1() : base() { }
        public MyButton1(string _imeFilma, string _dvorana, DateTime _datum, string _sat) : base()
        {
            imeFilma = _imeFilma;
            dvorana = _dvorana;
            datum = _datum;
            sat = _sat;
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

        public string Sat
        {
            get { return sat; }
        }
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}
