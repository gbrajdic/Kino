using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kino
{


    public partial class Imax : Form
    {
        int brojac;
        int IdTermina;
        List<string> listaSjedala;
        SqlConnection cn = null;
        SqlConnection cn1 = null;
        SqlDataReader reader = null;
        SqlDataReader reader1 = null;
        int cijena_ulaznice;
        string _ImeFilma;
        DateTime _DatumPrikazivanja;
        string _sat;
        public Imax(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
        {
            _ImeFilma = ImeFilma;
            _DatumPrikazivanja = DatumPrikazivanja;
            _sat = Sat;

            IdTermina = -1;
            brojac = 0;
            listaSjedala = new List<string>();
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn1 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            InitializeComponent();
            cijena.Text = "";
            button103.Name = "Imax A 1";
            button103.MouseClick += _MouseClick;
            button104.Name = "Imax A 2";
            button104.MouseClick += _MouseClick;
            button105.Name = "Imax A 3";
            button105.MouseClick += _MouseClick;
            button106.Name = "Imax A 4";
            button106.MouseClick += _MouseClick;
            button107.Name = "Imax A 5";
            button107.MouseClick += _MouseClick;
            button108.Name = "Imax A 6";
            button108.MouseClick += _MouseClick;
            button109.Name = "Imax A 7";
            button109.MouseClick += _MouseClick;
            button110.Name = "Imax A 8";
            button110.MouseClick += _MouseClick;
            button111.Name = "Imax A 9";
            button111.MouseClick += _MouseClick;
            button112.Name = "Imax A 10";
            button112.MouseClick += _MouseClick;
            button113.Name = "Imax A 11";
            button113.MouseClick += _MouseClick;
            button114.Name = "Imax A 12";
            button114.MouseClick += _MouseClick;
            button115.Name = "Imax A 13";
            button115.MouseClick += _MouseClick;
            button116.Name = "Imax A 14";
            button116.MouseClick += _MouseClick;
            button117.Name = "Imax A 15";
            button117.MouseClick += _MouseClick;
            button118.Name = "Imax A 16";
            button118.MouseClick += _MouseClick;
            button119.Name = "Imax A 17";
            button119.MouseClick += _MouseClick;
            button120.Name = "Imax A 18";
            button120.MouseClick += _MouseClick;
            button121.Name = "Imax A 19";
            button121.MouseClick += _MouseClick;
            button122.Name = "Imax A 20";
            button122.MouseClick += _MouseClick;
            button123.Name = "Imax A 21";
            button123.MouseClick += _MouseClick;
            button124.Name = "Imax A 22";
            button124.MouseClick += _MouseClick;
            button96.Name = "Imax B 8";
            button96.MouseClick += _MouseClick;
            button97.Name = "Imax B 9";
            button97.MouseClick += _MouseClick;
            button98.Name = "Imax B 10";
            button98.MouseClick += _MouseClick;
            button99.Name = "Imax B 11";
            button99.MouseClick += _MouseClick;
            button100.Name = "Imax B 12";
            button100.MouseClick += _MouseClick;
            button101.Name = "Imax B 13";
            button101.MouseClick += _MouseClick;
            button102.Name = "Imax B 14";
            button102.MouseClick += _MouseClick;
            button89.Name = "Imax B 1";
            button89.MouseClick += _MouseClick;
            button90.Name = "Imax B 2";
            button90.MouseClick += _MouseClick;
            button91.Name = "Imax B 3";
            button91.MouseClick += _MouseClick;
            button92.Name = "Imax B 4";
            button92.MouseClick += _MouseClick;
            button93.Name = "Imax B 5";
            button93.MouseClick += _MouseClick;
            button94.Name = "Imax B 6";
            button94.MouseClick += _MouseClick;
            button95.Name = "Imax B 7";
            button95.MouseClick += _MouseClick;
            button67.Name = "Imax C 1";
            button67.MouseClick += _MouseClick;
            button68.Name = "Imax C 2";
            button68.MouseClick += _MouseClick;
            button69.Name = "Imax C 3";
            button69.MouseClick += _MouseClick;
            button70.Name = "Imax C 4";
            button70.MouseClick += _MouseClick;
            button71.Name = "Imax C 5";
            button71.MouseClick += _MouseClick;
            button72.Name = "Imax C 6";
            button72.MouseClick += _MouseClick;
            button73.Name = "Imax C 7";
            button73.MouseClick += _MouseClick;
            button74.Name = "Imax C 8";
            button74.MouseClick += _MouseClick;
            button75.Name = "Imax C 9";
            button75.MouseClick += _MouseClick;
            button76.Name = "Imax C 10";
            button76.MouseClick += _MouseClick;
            button77.Name = "Imax C 11";
            button77.MouseClick += _MouseClick;
            button78.Name = "Imax C 12";
            button78.MouseClick += _MouseClick;
            button79.Name = "Imax C 13";
            button79.MouseClick += _MouseClick;
            button80.Name = "Imax C 14";
            button80.MouseClick += _MouseClick;
            button81.Name = "Imax C 15";
            button81.MouseClick += _MouseClick;
            button82.Name = "Imax C 16";
            button82.MouseClick += _MouseClick;
            button83.Name = "Imax C 17";
            button83.MouseClick += _MouseClick;
            button84.Name = "Imax C 18";
            button84.MouseClick += _MouseClick;
            button85.Name = "Imax C 19";
            button85.MouseClick += _MouseClick;
            button86.Name = "Imax C 20";
            button86.MouseClick += _MouseClick;
            button87.Name = "Imax C 21";
            button87.MouseClick += _MouseClick;
            button45.Name = "Imax D 1";
            button45.MouseClick += _MouseClick;
            button46.Name = "Imax D 2";
            button46.MouseClick += _MouseClick;
            button47.Name = "Imax D 3";
            button47.MouseClick += _MouseClick;
            button48.Name = "Imax D 4";
            button48.MouseClick += _MouseClick;
            button49.Name = "Imax D 5";
            button49.MouseClick += _MouseClick;
            button50.Name = "Imax D 6";
            button50.MouseClick += _MouseClick;
            button51.Name = "Imax D 7";
            button51.MouseClick += _MouseClick;
            button52.Name = "Imax D 8";
            button52.MouseClick += _MouseClick;
            button53.Name = "Imax D 9";
            button53.MouseClick += _MouseClick;
            button54.Name = "Imax D 10";
            button54.MouseClick += _MouseClick;
            button55.Name = "Imax D 11";
            button55.MouseClick += _MouseClick;
            button56.Name = "Imax D 12";
            button56.MouseClick += _MouseClick;
            button57.Name = "Imax D 13";
            button57.MouseClick += _MouseClick;
            button58.Name = "Imax D 14";
            button58.MouseClick += _MouseClick;
            button59.Name = "Imax D 15";
            button59.MouseClick += _MouseClick;
            button60.Name = "Imax E 15";
            button60.MouseClick += _MouseClick;
            button61.Name = "Imax D 16";
            button61.MouseClick += _MouseClick;
            button62.Name = "Imax D 17";
            button62.MouseClick += _MouseClick;
            button63.Name = "Imax D 18";
            button63.MouseClick += _MouseClick;
            button64.Name = "Imax D 19";
            button64.MouseClick += _MouseClick;
            button65.Name = "Imax D 21";
            button65.MouseClick += _MouseClick;
            button23.Name = "Imax E 5";
            button23.MouseClick += _MouseClick;
            button24.Name = "Imax E 2";
            button24.MouseClick += _MouseClick;
            button25.Name = "Imax E 20";
            button25.MouseClick += _MouseClick;
            button26.Name = "Imax E 1";
            button26.MouseClick += _MouseClick;
            button27.Name = "Imax E 4";
            button27.MouseClick += _MouseClick;
            button28.Name = "Imax E 3";
            button28.MouseClick += _MouseClick;
            button29.Name = "Imax E 6";
            button29.MouseClick += _MouseClick;
            button30.Name = "Imax E 7";
            button30.MouseClick += _MouseClick;
            button31.Name = "Imax E 8";
            button31.MouseClick += _MouseClick;
            button32.Name = "Imax E 9";
            button32.MouseClick += _MouseClick;
            button33.Name = "Imax E 10";
            button33.MouseClick += _MouseClick;
            button34.Name = "Imax E 11";
            button34.MouseClick += _MouseClick;
            button35.Name = "Imax E 12";
            button35.MouseClick += _MouseClick;
            button36.Name = "Imax E 13";
            button36.MouseClick += _MouseClick;
            button37.Name = "Imax E 14";
            button37.MouseClick += _MouseClick;
            button38.Name = "Imax E 16";
            button38.MouseClick += _MouseClick;
            button39.Name = "Imax E 17";
            button39.MouseClick += _MouseClick;
            button40.Name = "Imax E 18";
            button40.MouseClick += _MouseClick;
            button41.Name = "Imax E 19";
            button41.MouseClick += _MouseClick;
            button42.Name = "Imax D 20";
            button42.MouseClick += _MouseClick;
            button43.Name = "Imax E 21";
            button43.MouseClick += _MouseClick;


            PrikazStanjaDvorane(ImeFilma, DatumPrikazivanja, Sat);
        }


        void PrikazStanjaDvorane(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
        {

            try
            {
                label13.Text = ImeFilma + " " + DatumPrikazivanja.Day.ToString() + "." + DatumPrikazivanja.Month.ToString() + "." + DatumPrikazivanja.Year.ToString() + ". u " + Sat + " h";
                cn.Open();
                SqlCommand cm = new SqlCommand("Select Id, Cijena from Termini where ImeFilma=@imefilma and ImeDvorane=@dvorana and Sat=@sat and DatumPrikazivanja=cast(@datum as date)", cn);
                cm.Parameters.Add("@dvorana", SqlDbType.VarChar);
                cm.Parameters["@dvorana"].Value = Text;

                cm.Parameters.Add("@imefilma", SqlDbType.VarChar);
                cm.Parameters["@imefilma"].Value = ImeFilma;

                cm.Parameters.Add("@datum", SqlDbType.Date);
                cm.Parameters["@datum"].Value = DatumPrikazivanja;

                cm.Parameters.Add("@sat", SqlDbType.NChar);
                cm.Parameters["@sat"].Value = Sat;


                reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    IdTermina = (int)reader["Id"];
                    cijena_ulaznice = (int)reader["Cijena"];
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


            try
            {
                if (IdTermina != -1)
                {
                    cn1.Open();
                    SqlCommand cm1 = new SqlCommand("Select Sjedala.Red, Sjedala.Broj FROM Sjedala INNER JOIN Zauzetost ON Zauzetost.IdSjedala=Sjedala.IdSjedala WHERE Zauzetost.IdTermina=@IdTermina AND Sjedala.ImeDvorane=@dvorana", cn1);
                    cm1.Parameters.Add("@dvorana", SqlDbType.VarChar);
                    cm1.Parameters["@dvorana"].Value = Text;
                    cm1.Parameters.Add("@IdTermina", SqlDbType.Int);
                    cm1.Parameters["@IdTermina"].Value = IdTermina;

                    reader1 = cm1.ExecuteReader();
                    while (reader1.Read())
                    {
                        foreach (Control kontrola in Controls)
                        {
                            if (kontrola.GetType() == typeof(Button))
                            {

                                Regex regularniIzraz = new Regex(" ");
                                string[] oznake = regularniIzraz.Split(((Button)kontrola).Name);
                                if (oznake[0] == Name)
                                {

                                    if (oznake[1] == reader1["Red"].ToString().Trim() && oznake[2] == reader1["Broj"].ToString().Trim())
                                    {

                                        ((Button)kontrola).BackgroundImage = Properties.Resources.crveno_sjedalo;
                                        ((Button)kontrola).BackgroundImageLayout = ImageLayout.Stretch;
                                        ((Button)kontrola).Enabled = false;

                                    }
                                }

                            }
                        }
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (reader1 != null)
                    reader1.Close();

                if (cn1 != null)
                    cn1.Close();

            }

            cijena.Text = "Cijena: " + cijena_ulaznice.ToString() + " kn";
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void _MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Regex regularniIzraz = new Regex(" |, |,");
                string[] oznake = regularniIzraz.Split(((Button)sender).Name);


                if (!listaSjedala.Contains(oznake[1] + oznake[2]))
                {
                    if (label12.Text == "")
                    {
                        ((Button)sender).BackgroundImage = Properties.Resources.zeleno_sjedalo;
                        ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                        label12.Text += oznake[1] + oznake[2];
                        listaSjedala.Add(oznake[1] + oznake[2]);
                        brojac++;
                        label10.Text = brojac.ToString();
                    }
                    else
                    {
                        ((Button)sender).BackgroundImage = Properties.Resources.zeleno_sjedalo;
                        ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                        label12.Text += ", " + oznake[1] + oznake[2];
                        listaSjedala.Add(oznake[1] + oznake[2]);
                        brojac++;
                        label10.Text = brojac.ToString();
                    }
                }
                else
                {
                    ((Button)sender).BackgroundImage = Properties.Resources.žuto_sjedalo;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                    listaSjedala.Remove(oznake[1] + oznake[2]);
                    label12.Text = "";
                    foreach (string s in listaSjedala) { label12.Text += s + ", "; }
                    if (listaSjedala.Count == 0)
                    {
                        label12.Text = "";
                        brojac--;
                        label10.Text = "";
                    }

                    else
                    {
                        label12.Text = label12.Text.Substring(0, label12.Text.Length - 2);
                        brojac--;
                        label10.Text = brojac.ToString();
                    }



                }
            }
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PotvrdiKupnju_Click(object sender, EventArgs e)
        {
            int IdSjedala = -1;
            
            if (listaSjedala.Count == 0)
            {
                DialogResult dialogResult1 = MessageBox.Show("Nemoguće je izvršiti kupnju, izabrali ste 0 sjedala", "Kupnja karata", MessageBoxButtons.OK);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Za platiti, ukupno " + (listaSjedala.Count * cijena_ulaznice).ToString() + " kn.\n\n" + "Želite li zaključiti kupnju?", "Kupnja karata", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cn.Open();
                    try
                    {
                        foreach (string sjedalo in listaSjedala)
                        {



                            SqlCommand cm = new SqlCommand("Select Sjedala.IdSjedala FROM Sjedala WHERE Sjedala.Red=@Red AND Sjedala.Broj=@Broj AND Sjedala.ImeDvorane=@dvorana", cn);

                            cm.Parameters.Add("@Red", SqlDbType.NChar);
                            cm.Parameters["@Red"].Value = sjedalo[0].ToString();

                            cm.Parameters.Add("@Broj", SqlDbType.SmallInt);
                            cm.Parameters["@Broj"].Value = Convert.ToInt16(sjedalo.Substring(1, sjedalo.Length - 1));

                            cm.Parameters.Add("@dvorana", SqlDbType.VarChar);
                            cm.Parameters["@dvorana"].Value = Name;

                            IdSjedala = (int)cm.ExecuteScalar();
                            cm.Parameters.Clear();


                            try
                            {


                                SqlCommand cm2 = new SqlCommand("insert INTO [dbo].[Zauzetost] ([IdSjedala], [IdTermina]) VALUES (@IdSjedala, @IdTermina)", cn);

                                cm2.Parameters.Add("@IdSjedala", SqlDbType.Int);
                                cm2.Parameters["@IdSjedala"].Value = IdSjedala;

                                cm2.Parameters.Add("@IdTermina", SqlDbType.Int);
                                cm2.Parameters["@IdTermina"].Value = IdTermina;
                                cm2.ExecuteNonQuery();

                                cm2.Parameters.Clear();
                            }



                            catch (Exception f)
                            {
                                MessageBox.Show(f.ToString());
                            }
                            finally
                            {


                            }
                        }

                        string sjedala = "";
                        listaSjedala.Sort();
                        foreach (string s in listaSjedala) { sjedala += s + ", "; }
                        sjedala = sjedala.Substring(0, sjedala.Length - 2);
                        
                        PrintForma printForma = new PrintForma(_ImeFilma, _DatumPrikazivanja, _sat, Name, sjedala, (listaSjedala.Count * cijena_ulaznice).ToString(), cijena_ulaznice);
                        printForma.Closed += (s, args) => Close();

                        printForma.ShowDialog();
                    }
                    catch (Exception g)
                    {
                        MessageBox.Show(g.ToString());
                    }
                    finally
                    {

                        if (cn != null)
                            cn.Close();
                    }




                }
            }
        }


    }


}


