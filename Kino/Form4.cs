using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kino
{


    public partial class Real3D : Form
    {
        int brojac;
        int IdTermina;
        int cijena_ulaznice;
        List<string> listaSjedala;
        SqlConnection cn = null;
        SqlConnection cn1 = null;
        
        SqlDataReader reader1 = null;
        SqlDataReader reader2 = null;
        string _ImeFilma;
        DateTime _DatumPrikazivanja;
        string _sat;
        public Real3D(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
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
            button103.Name = "Real3D A 1";
            button103.MouseClick += _MouseClick;
            button104.Name = "Real3D A 2";
            button104.MouseClick += _MouseClick;
            button105.Name = "Real3D A 3";
            button105.MouseClick += _MouseClick;
            button106.Name = "Real3D A 4";
            button106.MouseClick += _MouseClick;
            button107.Name = "Real3D A 5";
            button107.MouseClick += _MouseClick;
            button108.Name = "Real3D A 6";
            button108.MouseClick += _MouseClick;
            button109.Name = "Real3D A 7";
            button109.MouseClick += _MouseClick;
            button110.Name = "Real3D A 8";
            button110.MouseClick += _MouseClick;
            button111.Name = "Real3D A 9";
            button111.MouseClick += _MouseClick;
            button112.Name = "Real3D A 10";
            button112.MouseClick += _MouseClick;
            button113.Name = "Real3D A 11";
            button113.MouseClick += _MouseClick;
            button114.Name = "Real3D A 12";
            button114.MouseClick += _MouseClick;
            button115.Name = "Real3D A 13";
            button115.MouseClick += _MouseClick;
            button116.Name = "Real3D A 14";
            button116.MouseClick += _MouseClick;
            button117.Name = "Real3D A 15";
            button117.MouseClick += _MouseClick;
            button118.Name = "Real3D A 16";
            button118.MouseClick += _MouseClick;
            button119.Name = "Real3D A 17";
            button119.MouseClick += _MouseClick;
            button120.Name = "Real3D A 18";
            button120.MouseClick += _MouseClick;
            button121.Name = "Real3D A 19";
            button121.MouseClick += _MouseClick;
            button122.Name = "Real3D A 20";
            button122.MouseClick += _MouseClick;
            button123.Name = "Real3D A 21";
            button123.MouseClick += _MouseClick;
            button124.Name = "Real3D A 22";
            button124.MouseClick += _MouseClick;
            button96.Name = "Real3D B 8";
            button96.MouseClick += _MouseClick;
            button97.Name = "Real3D B 9";
            button97.MouseClick += _MouseClick;
            button98.Name = "Real3D B 10";
            button98.MouseClick += _MouseClick;
            button99.Name = "Real3D B 11";
            button99.MouseClick += _MouseClick;
            button100.Name = "Real3D B 12";
            button100.MouseClick += _MouseClick;
            button101.Name = "Real3D B 13";
            button101.MouseClick += _MouseClick;
            button102.Name = "Real3D B 14";
            button102.MouseClick += _MouseClick;
            button89.Name = "Real3D B 1";
            button89.MouseClick += _MouseClick;
            button90.Name = "Real3D B 2";
            button90.MouseClick += _MouseClick;
            button91.Name = "Real3D B 3";
            button91.MouseClick += _MouseClick;
            button92.Name = "Real3D B 4";
            button92.MouseClick += _MouseClick;
            button93.Name = "Real3D B 5";
            button93.MouseClick += _MouseClick;
            button94.Name = "Real3D B 6";
            button94.MouseClick += _MouseClick;
            button95.Name = "Real3D B 7";
            button95.MouseClick += _MouseClick;
            button67.Name = "Real3D C 1";
            button67.MouseClick += _MouseClick;
            button68.Name = "Real3D C 2";
            button68.MouseClick += _MouseClick;
            button69.Name = "Real3D C 3";
            button69.MouseClick += _MouseClick;
            button70.Name = "Real3D C 4";
            button70.MouseClick += _MouseClick;
            button71.Name = "Real3D C 5";
            button71.MouseClick += _MouseClick;
            button72.Name = "Real3D C 6";
            button72.MouseClick += _MouseClick;
            button73.Name = "Real3D C 7";
            button73.MouseClick += _MouseClick;
            button74.Name = "Real3D C 8";
            button74.MouseClick += _MouseClick;
            button75.Name = "Real3D C 9";
            button75.MouseClick += _MouseClick;
            button76.Name = "Real3D C 10";
            button76.MouseClick += _MouseClick;
            button77.Name = "Real3D C 11";
            button77.MouseClick += _MouseClick;
            button78.Name = "Real3D C 12";
            button78.MouseClick += _MouseClick;
            button79.Name = "Real3D C 13";
            button79.MouseClick += _MouseClick;
            button80.Name = "Real3D C 14";
            button80.MouseClick += _MouseClick;
            button81.Name = "Real3D C 15";
            button81.MouseClick += _MouseClick;
            button82.Name = "Real3D C 16";
            button82.MouseClick += _MouseClick;
            button83.Name = "Real3D C 17";
            button83.MouseClick += _MouseClick;
            button84.Name = "Real3D C 18";
            button84.MouseClick += _MouseClick;
            button85.Name = "Real3D C 19";
            button85.MouseClick += _MouseClick;
            button86.Name = "Real3D C 20";
            button86.MouseClick += _MouseClick;
            button87.Name = "Real3D C 21";
            button87.MouseClick += _MouseClick;
            button88.Name = "Real3D C 22";
            button88.MouseClick += _MouseClick;
            button45.Name = "Real3D D 1";
            button45.MouseClick += _MouseClick;
            button46.Name = "Real3D D 2";
            button46.MouseClick += _MouseClick;
            button47.Name = "Real3D D 3";
            button47.MouseClick += _MouseClick;
            button48.Name = "Real3D D 4";
            button48.MouseClick += _MouseClick;
            button49.Name = "Real3D D 5";
            button49.MouseClick += _MouseClick;
            button50.Name = "Real3D D 6";
            button50.MouseClick += _MouseClick;
            button51.Name = "Real3D D 7";
            button51.MouseClick += _MouseClick;
            button52.Name = "Real3D D 8";
            button52.MouseClick += _MouseClick;
            button53.Name = "Real3D D 9";
            button53.MouseClick += _MouseClick;
            button54.Name = "Real3D D 10";
            button54.MouseClick += _MouseClick;
            button55.Name = "Real3D D 11";
            button55.MouseClick += _MouseClick;
            button56.Name = "Real3D D 12";
            button56.MouseClick += _MouseClick;
            button57.Name = "Real3D D 13";
            button57.MouseClick += _MouseClick;
            button58.Name = "Real3D D 14";
            button58.MouseClick += _MouseClick;
            button59.Name = "Real3D D 15";
            button59.MouseClick += _MouseClick;
            button60.Name = "Real3D D 16";
            button60.MouseClick += _MouseClick;
            button61.Name = "Real3D D 17";
            button61.MouseClick += _MouseClick;
            button62.Name = "Real3D D 18";
            button62.MouseClick += _MouseClick;
            button63.Name = "Real3D D 19";
            button63.MouseClick += _MouseClick;
            button64.Name = "Real3D D 20";
            button64.MouseClick += _MouseClick;
            button65.Name = "Real3D D 21";
            button65.MouseClick += _MouseClick;
            button66.Name = "Real3D D 22";
            button66.MouseClick += _MouseClick;
            button23.Name = "Real3D E 1";
            button23.MouseClick += _MouseClick;
            button24.Name = "Real3D E 2";
            button24.MouseClick += _MouseClick;
            button25.Name = "Real3D E 3";
            button25.MouseClick += _MouseClick;
            button26.Name = "Real3D E 4";
            button26.MouseClick += _MouseClick;
            button27.Name = "Real3D E 5";
            button27.MouseClick += _MouseClick;
            button28.Name = "Real3D E 6";
            button28.MouseClick += _MouseClick;
            button29.Name = "Real3D E 7";
            button29.MouseClick += _MouseClick;
            button30.Name = "Real3D E 8";
            button30.MouseClick += _MouseClick;
            button31.Name = "Real3D E 9";
            button31.MouseClick += _MouseClick;
            button32.Name = "Real3D E 10";
            button32.MouseClick += _MouseClick;
            button33.Name = "Real3D E 11";
            button33.MouseClick += _MouseClick;
            button34.Name = "Real3D E 12";
            button34.MouseClick += _MouseClick;
            button35.Name = "Real3D E 13";
            button35.MouseClick += _MouseClick;
            button36.Name = "Real3D E 14";
            button36.MouseClick += _MouseClick;
            button37.Name = "Real3D E 15";
            button37.MouseClick += _MouseClick;
            button38.Name = "Real3D E 16";
            button38.MouseClick += _MouseClick;
            button39.Name = "Real3D E 17";
            button39.MouseClick += _MouseClick;
            button40.Name = "Real3D E 18";
            button40.MouseClick += _MouseClick;
            button41.Name = "Real3D E 19";
            button41.MouseClick += _MouseClick;
            button42.Name = "Real3D E 20";
            button42.MouseClick += _MouseClick;
            button43.Name = "Real3D E 21";
            button43.MouseClick += _MouseClick;
            button44.Name = "Real3D E 22";
            button44.MouseClick += _MouseClick;
            button22.Name = "Real3D F 22";
            button22.MouseClick += _MouseClick;
            button21.Name = "Real3D F 21";
            button21.MouseClick += _MouseClick;
            button20.Name = "Real3D F 20";
            button20.MouseClick += _MouseClick;
            button19.Name = "Real3D F 19";
            button19.MouseClick += _MouseClick;
            button18.Name = "Real3D F 18";
            button18.MouseClick += _MouseClick;
            button17.Name = "Real3D F 17";
            button17.MouseClick += _MouseClick;
            button16.Name = "Real3D F 16";
            button16.MouseClick += _MouseClick;
            button15.Name = "Real3D F 15";
            button15.MouseClick += _MouseClick;
            button14.Name = "Real3D F 14";
            button14.MouseClick += _MouseClick;
            button13.Name = "Real3D F 13";
            button13.MouseClick += _MouseClick;
            button12.Name = "Real3D F 12";
            button12.MouseClick += _MouseClick;
            button11.Name = "Real3D F 11";
            button11.MouseClick += _MouseClick;
            button10.Name = "Real3D F 10";
            button10.MouseClick += _MouseClick;
            button9.Name = "Real3D F 9";
            button9.MouseClick += _MouseClick;
            button8.Name = "Real3D F 8";
            button8.MouseClick += _MouseClick;
            button7.Name = "Real3D F 7";
            button7.MouseClick += _MouseClick;
            button6.Name = "Real3D F 6";
            button6.MouseClick += _MouseClick;
            button5.Name = "Real3D F 5";
            button5.MouseClick += _MouseClick;
            button4.Name = "Real3D F 4";
            button4.MouseClick += _MouseClick;
            button3.Name = "Real3D F 3";
            button3.MouseClick += _MouseClick;
            button2.Name = "Real3D F 2";
            button2.MouseClick += _MouseClick;
            button1.Name = "Real3D F 1";
            button1.MouseClick += _MouseClick;


            PrikazStanjaDvorane(ImeFilma, DatumPrikazivanja, Sat);
        }

        
        void PrikazStanjaDvorane(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
        {
            
            try
            {
                label13.Text = ImeFilma + " " + DatumPrikazivanja.Day.ToString() +"."+DatumPrikazivanja.Month.ToString()+"."+DatumPrikazivanja.Year.ToString() + ". u " + Sat + " h";
                cn.Open();
                SqlCommand cm = new SqlCommand("Select Id, Cijena from Termini where ImeFilma=@imefilma and ImeDvorane=@dvorana and Sat=@sat and DatumPrikazivanja=cast(@datum as date)", cn);
                cm.Parameters.Add("@dvorana", SqlDbType.VarChar);
                cm.Parameters["@dvorana"].Value = Text;

                cm.Parameters.Add("@imefilma", SqlDbType.VarChar);
                cm.Parameters["@imefilma"].Value = ImeFilma;

                cm.Parameters.Add("@datum",SqlDbType.Date);
                cm.Parameters["@datum"].Value = DatumPrikazivanja;

                cm.Parameters.Add("@sat", SqlDbType.NChar);
                cm.Parameters["@sat"].Value = Sat;

                reader2 = cm.ExecuteReader();
                while (reader2.Read())
                {
                    IdTermina = (int)reader2["Id"];
                    cijena_ulaznice = (int)reader2["Cijena"];
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
                        foreach(Control kontrola in Controls)
                        {
                            if (kontrola.GetType() == typeof(Button))
                            {
                                
                                Regex regularniIzraz = new Regex(" ");
                                string[] oznake = regularniIzraz.Split(((Button)kontrola).Name);
                                if (oznake[0] == Name)
                                {

                                    if (oznake[1]== reader1["Red"].ToString().Trim() && oznake[2] == reader1["Broj"].ToString().Trim())
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

            cijena.Text = "Cijena: " + cijena_ulaznice + " kn";
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
                            cm.Parameters["@dvorana"].Value = Text;

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

