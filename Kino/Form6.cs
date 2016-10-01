using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kino
{


    public partial class Auro4K : Form
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
        public Auro4K(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
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
            button23.Name = "Auro4K A 1";
            button23.MouseClick += _MouseClick;
            button24.Name = "Auro4K A 2";
            button24.MouseClick += _MouseClick;
            button25.Name = "Auro4K A 5";
            button25.MouseClick += _MouseClick;
            button26.Name = "Auro4K A 6";
            button26.MouseClick += _MouseClick;
            button27.Name = "Auro4K A 7";
            button27.MouseClick += _MouseClick;
            button28.Name = "Auro4K A 8";
            button28.MouseClick += _MouseClick;
            button29.Name = "Auro4K A 11";
            button29.MouseClick += _MouseClick;
            button30.Name = "Auro4K A 12";
            button30.MouseClick += _MouseClick;
            button32.Name = "Auro4K D 2";
            button32.MouseClick += _MouseClick;
            button22.Name = "Auro4K D 12";
            button22.MouseClick += _MouseClick;
            button21.Name = "Auro4K D 11";
            button21.MouseClick += _MouseClick;
            button20.Name = "Auro4K D 8";
            button20.MouseClick += _MouseClick;
            button19.Name = "Auro4K D 7";
            button19.MouseClick += _MouseClick;
            button18.Name = "Auro4K D 6";
            button18.MouseClick += _MouseClick;
            button17.Name = "Auro4K D 5";
            button17.MouseClick += _MouseClick;
            button16.Name = "Auro4K C 12";
            button16.MouseClick += _MouseClick;
            button15.Name = "Auro4K C 11";
            button15.MouseClick += _MouseClick;
            button14.Name = "Auro4K C 8";
            button14.MouseClick += _MouseClick;
            button13.Name = "Auro4K C 7";
            button13.MouseClick += _MouseClick;
            button12.Name = "Auro4K C 6";
            button12.MouseClick += _MouseClick;
            button11.Name = "Auro4K C 5";
            button11.MouseClick += _MouseClick;
            button10.Name = "Auro4K C 2";
            button10.MouseClick += _MouseClick;
            button9.Name = "Auro4K C 1";
            button9.MouseClick += _MouseClick;
            button8.Name = "Auro4K B 12";
            button8.MouseClick += _MouseClick;
            button7.Name = "Auro4K B 11";
            button7.MouseClick += _MouseClick;
            button6.Name = "Auro4K B 8";
            button6.MouseClick += _MouseClick;
            button5.Name = "Auro4K B 7";
            button5.MouseClick += _MouseClick;
            button4.Name = "Auro4K B 6";
            button4.MouseClick += _MouseClick;
            button3.Name = "Auro4K B 5";
            button3.MouseClick += _MouseClick;
            button2.Name = "Auro4K B 2";
            button2.MouseClick += _MouseClick;
            button1.Name = "Auro4K B 1";
            button1.MouseClick += _MouseClick;
            button31.Name = "Auro4K D 1";
            button31.MouseClick += _MouseClick;
            button33.Name = "Auro4K D 3";
            button33.MouseClick += _MouseClick;
            button34.Name = "Auro4K C 3";
            button34.MouseClick += _MouseClick;
            button35.Name = "Auro4K B 3";
            button35.MouseClick += _MouseClick;
            button36.Name = "Auro4K A 3";
            button36.MouseClick += _MouseClick;
            button37.Name = "Auro4K D 4";
            button37.MouseClick += _MouseClick;
            button38.Name = "Auro4K C 4";
            button38.MouseClick += _MouseClick;
            button39.Name = "Auro4K B 4";
            button39.MouseClick += _MouseClick;
            button40.Name = "Auro4K A 4";
            button40.MouseClick += _MouseClick;
            button41.Name = "Auro4K D 10";
            button41.MouseClick += _MouseClick;
            button42.Name = "Auro4K C 10";
            button42.MouseClick += _MouseClick;
            button43.Name = "Auro4K B 10";
            button43.MouseClick += _MouseClick;
            button44.Name = "Auro4K A 10";
            button44.MouseClick += _MouseClick;
            button45.Name = "Auro4K D 9";
            button45.MouseClick += _MouseClick;
            button46.Name = "Auro4K C 9";
            button46.MouseClick += _MouseClick;
            button47.Name = "Auro4K B 9";
            button47.MouseClick += _MouseClick;
            button48.Name = "Auro4K A 9";
            button48.MouseClick += _MouseClick;







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



