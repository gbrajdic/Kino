using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kino
{


    public partial class Extreme : Form
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
        public Extreme(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
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
            button103.Name = "Extreme A 1";
            button103.MouseClick += _MouseClick;
            button104.Name = "Extreme A 2";
            button104.MouseClick += _MouseClick;
            button105.Name = "Extreme A 3";
            button105.MouseClick += _MouseClick;
            button106.Name = "Extreme A 4";
            button106.MouseClick += _MouseClick;
            button107.Name = "Extreme A 5";
            button107.MouseClick += _MouseClick;
            button108.Name = "Extreme A 6";
            button108.MouseClick += _MouseClick;
            button109.Name = "Extreme A 7";
            button109.MouseClick += _MouseClick;
            button110.Name = "Extreme A 8";
            button110.MouseClick += _MouseClick;
            button111.Name = "Extreme A 9";
            button111.MouseClick += _MouseClick;
            button112.Name = "Extreme A 10";
            button112.MouseClick += _MouseClick;
            button113.Name = "Extreme A 11";
            button113.MouseClick += _MouseClick;
            button114.Name = "Extreme A 12";
            button114.MouseClick += _MouseClick;
            button115.Name = "Extreme A 13";
            button115.MouseClick += _MouseClick;
            button116.Name = "Extreme A 14";
            button116.MouseClick += _MouseClick;
            button117.Name = "Extreme A 15";
            button117.MouseClick += _MouseClick;
            button118.Name = "Extreme A 16";
            button118.MouseClick += _MouseClick;
            button119.Name = "Extreme A 17";
            button119.MouseClick += _MouseClick;
            button120.Name = "Extreme A 18";
            button120.MouseClick += _MouseClick;
            button121.Name = "Extreme A 19";
            button121.MouseClick += _MouseClick;
            button122.Name = "Extreme A 20";
            button122.MouseClick += _MouseClick;
            button123.Name = "Extreme A 21";
            button123.MouseClick += _MouseClick;
            button124.Name = "Extreme A 22";
            button124.MouseClick += _MouseClick;
            button96.Name = "Extreme B 8";
            button96.MouseClick += _MouseClick;
            button97.Name = "Extreme B 9";
            button97.MouseClick += _MouseClick;
            button98.Name = "Extreme B 10";
            button98.MouseClick += _MouseClick;
            button99.Name = "Extreme B 11";
            button99.MouseClick += _MouseClick;
            button100.Name = "Extreme B 12";
            button100.MouseClick += _MouseClick;
            button101.Name = "Extreme B 13";
            button101.MouseClick += _MouseClick;
            button102.Name = "Extreme B 14";
            button102.MouseClick += _MouseClick;
            button89.Name = "Extreme B 1";
            button89.MouseClick += _MouseClick;
            button90.Name = "Extreme B 2";
            button90.MouseClick += _MouseClick;
            button91.Name = "Extreme B 3";
            button91.MouseClick += _MouseClick;
            button92.Name = "Extreme B 4";
            button92.MouseClick += _MouseClick;
            button93.Name = "Extreme B 5";
            button93.MouseClick += _MouseClick;
            button94.Name = "Extreme B 6";
            button94.MouseClick += _MouseClick;
            button95.Name = "Extreme B 7";
            button95.MouseClick += _MouseClick;
            button67.Name = "Extreme C 1";
            button67.MouseClick += _MouseClick;
            button68.Name = "Extreme C 2";
            button68.MouseClick += _MouseClick;
            button69.Name = "Extreme C 3";
            button69.MouseClick += _MouseClick;
            button70.Name = "Extreme C 4";
            button70.MouseClick += _MouseClick;
            button71.Name = "Extreme C 5";
            button71.MouseClick += _MouseClick;
            button72.Name = "Extreme C 6";
            button72.MouseClick += _MouseClick;
            button73.Name = "Extreme C 7";
            button73.MouseClick += _MouseClick;
            button74.Name = "Extreme C 8";
            button74.MouseClick += _MouseClick;
            button75.Name = "Extreme C 9";
            button75.MouseClick += _MouseClick;
            button76.Name = "Extreme C 10";
            button76.MouseClick += _MouseClick;
            button77.Name = "Extreme C 11";
            button77.MouseClick += _MouseClick;
            button78.Name = "Extreme C 12";
            button78.MouseClick += _MouseClick;
            button79.Name = "Extreme C 13";
            button79.MouseClick += _MouseClick;
            button80.Name = "Extreme C 14";
            button80.MouseClick += _MouseClick;
            button81.Name = "Extreme C 15";
            button81.MouseClick += _MouseClick;
            button82.Name = "Extreme C 16";
            button82.MouseClick += _MouseClick;
            button83.Name = "Extreme C 17";
            button83.MouseClick += _MouseClick;
            button84.Name = "Extreme C 18";
            button84.MouseClick += _MouseClick;
            button85.Name = "Extreme C 19";
            button85.MouseClick += _MouseClick;
            button86.Name = "Extreme C 20";
            button86.MouseClick += _MouseClick;
            button87.Name = "Extreme C 21";
            button87.MouseClick += _MouseClick;
            button88.Name = "Extreme C 22";
            button88.MouseClick += _MouseClick;
            button45.Name = "Extreme D 1";
            button45.MouseClick += _MouseClick;
            button46.Name = "Extreme D 2";
            button46.MouseClick += _MouseClick;
            button47.Name = "Extreme D 3";
            button47.MouseClick += _MouseClick;
            button48.Name = "Extreme D 4";
            button48.MouseClick += _MouseClick;
            button49.Name = "Extreme D 5";
            button49.MouseClick += _MouseClick;
            button50.Name = "Extreme D 6";
            button50.MouseClick += _MouseClick;
            button51.Name = "Extreme D 7";
            button51.MouseClick += _MouseClick;
            button52.Name = "Extreme D 8";
            button52.MouseClick += _MouseClick;
            button53.Name = "Extreme D 9";
            button53.MouseClick += _MouseClick;
            button54.Name = "Extreme D 10";
            button54.MouseClick += _MouseClick;
            button55.Name = "Extreme D 11";
            button55.MouseClick += _MouseClick;
            button56.Name = "Extreme D 12";
            button56.MouseClick += _MouseClick;
            button57.Name = "Extreme D 13";
            button57.MouseClick += _MouseClick;
            button58.Name = "Extreme D 14";
            button58.MouseClick += _MouseClick;
            button59.Name = "Extreme D 15";
            button59.MouseClick += _MouseClick;
            button60.Name = "Extreme D 16";
            button60.MouseClick += _MouseClick;
            button61.Name = "Extreme D 17";
            button61.MouseClick += _MouseClick;
            button62.Name = "Extreme D 18";
            button62.MouseClick += _MouseClick;
            button63.Name = "Extreme D 19";
            button63.MouseClick += _MouseClick;
            button64.Name = "Extreme D 20";
            button64.MouseClick += _MouseClick;
            button65.Name = "Extreme D 21";
            button65.MouseClick += _MouseClick;
            button66.Name = "Extreme D 22";
            button66.MouseClick += _MouseClick;
            button23.Name = "Extreme E 1";
            button23.MouseClick += _MouseClick;
            button24.Name = "Extreme E 2";
            button24.MouseClick += _MouseClick;
            button25.Name = "Extreme E 3";
            button25.MouseClick += _MouseClick;
            button26.Name = "Extreme E 4";
            button26.MouseClick += _MouseClick;
            button27.Name = "Extreme E 5";
            button27.MouseClick += _MouseClick;
            button28.Name = "Extreme E 6";
            button28.MouseClick += _MouseClick;
            button29.Name = "Extreme E 7";
            button29.MouseClick += _MouseClick;
            button30.Name = "Extreme E 8";
            button30.MouseClick += _MouseClick;
            button31.Name = "Extreme E 9";
            button31.MouseClick += _MouseClick;
            button32.Name = "Extreme E 10";
            button32.MouseClick += _MouseClick;
            button33.Name = "Extreme E 11";
            button33.MouseClick += _MouseClick;
            button34.Name = "Extreme E 12";
            button34.MouseClick += _MouseClick;
            button35.Name = "Extreme E 13";
            button35.MouseClick += _MouseClick;
            button36.Name = "Extreme E 14";
            button36.MouseClick += _MouseClick;
            button37.Name = "Extreme E 15";
            button37.MouseClick += _MouseClick;
            button38.Name = "Extreme E 16";
            button38.MouseClick += _MouseClick;
            button39.Name = "Extreme E 17";
            button39.MouseClick += _MouseClick;
            button40.Name = "Extreme E 18";
            button40.MouseClick += _MouseClick;
            button41.Name = "Extreme E 19";
            button41.MouseClick += _MouseClick;
            button42.Name = "Extreme E 20";
            button42.MouseClick += _MouseClick;
            button43.Name = "Extreme E 21";
            button43.MouseClick += _MouseClick;
            button44.Name = "Extreme E 22";
            button44.MouseClick += _MouseClick;
            button22.Name = "Extreme F 22";
            button22.MouseClick += _MouseClick;
            button21.Name = "Extreme F 21";
            button21.MouseClick += _MouseClick;
            button20.Name = "Extreme F 20";
            button20.MouseClick += _MouseClick;
            button19.Name = "Extreme F 19";
            button19.MouseClick += _MouseClick;
            button18.Name = "Extreme F 18";
            button18.MouseClick += _MouseClick;
            button17.Name = "Extreme F 17";
            button17.MouseClick += _MouseClick;
            button16.Name = "Extreme F 16";
            button16.MouseClick += _MouseClick;
            button15.Name = "Extreme F 15";
            button15.MouseClick += _MouseClick;
            button14.Name = "Extreme F 14";
            button14.MouseClick += _MouseClick;
            button13.Name = "Extreme F 13";
            button13.MouseClick += _MouseClick;
            button12.Name = "Extreme F 12";
            button12.MouseClick += _MouseClick;
            button11.Name = "Extreme F 11";
            button11.MouseClick += _MouseClick;
            button10.Name = "Extreme F 10";
            button10.MouseClick += _MouseClick;
            button9.Name = "Extreme F 9";
            button9.MouseClick += _MouseClick;
            button8.Name = "Extreme F 8";
            button8.MouseClick += _MouseClick;
            button7.Name = "Extreme F 7";
            button7.MouseClick += _MouseClick;
            button6.Name = "Extreme F 6";
            button6.MouseClick += _MouseClick;
            button5.Name = "Extreme F 5";
            button5.MouseClick += _MouseClick;
            button4.Name = "Extreme F 4";
            button4.MouseClick += _MouseClick;
            button3.Name = "Extreme F 3";
            button3.MouseClick += _MouseClick;
            button2.Name = "Extreme F 2";
            button2.MouseClick += _MouseClick;
            button1.Name = "Extreme F 1";
            button1.MouseClick += _MouseClick;


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



