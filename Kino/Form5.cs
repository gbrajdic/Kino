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
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System;

namespace Kino
{


    public partial class GoldClass : Form
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
        public GoldClass(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
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
            this.button23.Name = "GoldClass A 1";
            this.button23.MouseClick += _MouseClick;
            this.button24.Name = "GoldClass A 2";
            this.button24.MouseClick += _MouseClick;
            this.button25.Name = "GoldClass A 3";
            this.button25.MouseClick += _MouseClick;
            this.button26.Name = "GoldClass A 4";
            this.button26.MouseClick += _MouseClick;
            this.button27.Name = "GoldClass A 5";
            this.button27.MouseClick += _MouseClick;
            this.button28.Name = "GoldClass A 6";
            this.button28.MouseClick += _MouseClick;
            this.button29.Name = "GoldClass A 7";
            this.button29.MouseClick += _MouseClick;
            this.button30.Name = "GoldClass A 8";
            this.button30.MouseClick += _MouseClick;
            this.button31.Name = "GoldClass D 1";
            this.button31.MouseClick += _MouseClick;
            this.button32.Name = "GoldClass D 2";
            this.button32.MouseClick += _MouseClick;
            this.button22.Name = "GoldClass D 8";
            this.button22.MouseClick += _MouseClick;
            this.button21.Name = "GoldClass D 7";
            this.button21.MouseClick += _MouseClick;
            this.button20.Name = "GoldClass D 6";
            this.button20.MouseClick += _MouseClick;
            this.button19.Name = "GoldClass D 5";
            this.button19.MouseClick += _MouseClick;
            this.button18.Name = "GoldClass D 4";
            this.button18.MouseClick += _MouseClick;
            this.button17.Name = "GoldClass D 3";
            this.button17.MouseClick += _MouseClick;
            this.button16.Name = "GoldClass C 8";
            this.button16.MouseClick += _MouseClick;
            this.button15.Name = "GoldClass C 7";
            this.button15.MouseClick += _MouseClick;
            this.button14.Name = "GoldClass C 6";
            this.button14.MouseClick += _MouseClick;
            this.button13.Name = "GoldClass C 5";
            this.button13.MouseClick += _MouseClick;
            this.button12.Name = "GoldClass C 4";
            this.button12.MouseClick += _MouseClick;
            this.button11.Name = "GoldClass C 3";
            this.button11.MouseClick += _MouseClick;
            this.button10.Name = "GoldClass C 2";
            this.button10.MouseClick += _MouseClick;
            this.button9.Name = "GoldClass C 1";
            this.button9.MouseClick += _MouseClick;
            this.button8.Name = "GoldClass B 8";
            this.button8.MouseClick += _MouseClick;
            this.button7.Name = "GoldClass B 7";
            this.button7.MouseClick += _MouseClick;
            this.button6.Name = "GoldClass B 6";
            this.button6.MouseClick += _MouseClick;
            this.button5.Name = "GoldClass B 5";
            this.button5.MouseClick += _MouseClick;
            this.button4.Name = "GoldClass B 4";
            this.button4.MouseClick += _MouseClick;
            this.button3.Name = "GoldClass B 3";
            this.button3.MouseClick += _MouseClick;
            this.button2.Name = "GoldClass B 2";
            this.button2.MouseClick += _MouseClick;
            this.button1.Name = "GoldClass B 1";
            this.button1.MouseClick += _MouseClick;


            PrikazStanjaDvorane(ImeFilma, DatumPrikazivanja, Sat);
        }


        void PrikazStanjaDvorane(string ImeFilma, DateTime DatumPrikazivanja, string Sat)
        {

            try
            {
                this.label13.Text = ImeFilma + " " + DatumPrikazivanja.Day.ToString() + "." + DatumPrikazivanja.Month.ToString() + "." + DatumPrikazivanja.Year.ToString() + ". u " + Sat + " h";
                cn.Open();
                SqlCommand cm = new SqlCommand("Select Id, Cijena from Termini where ImeFilma=@imefilma and ImeDvorane=@dvorana and Sat=@sat and DatumPrikazivanja=cast(@datum as date)", cn);
                cm.Parameters.Add("@dvorana", SqlDbType.VarChar);
                cm.Parameters["@dvorana"].Value = this.Text;

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
                    cm1.Parameters["@dvorana"].Value = this.Text;
                    cm1.Parameters.Add("@IdTermina", SqlDbType.Int);
                    cm1.Parameters["@IdTermina"].Value = IdTermina;

                    reader1 = cm1.ExecuteReader();
                    while (reader1.Read())
                    {
                        foreach (Control kontrola in this.Controls)
                        {
                            if (kontrola.GetType() == typeof(Button))
                            {

                                Regex regularniIzraz = new Regex(" ");
                                string[] oznake = regularniIzraz.Split(((Button)kontrola).Name);
                                if (oznake[0] == this.Name)
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
                    if (this.label12.Text == "")
                    {
                        ((Button)sender).BackgroundImage = Properties.Resources.zeleno_sjedalo;
                        ((Button)sender).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.label12.Text += oznake[1] + oznake[2]; listaSjedala.Add(oznake[1] + oznake[2]); brojac++; label10.Text = brojac.ToString();
                    }
                    else
                    {
                        ((Button)sender).BackgroundImage = Properties.Resources.zeleno_sjedalo;
                        ((Button)sender).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.label12.Text += ", " + oznake[1] + oznake[2]; listaSjedala.Add(oznake[1] + oznake[2]); brojac++; label10.Text = brojac.ToString();
                    }
                }
                else
                {
                    ((Button)sender).BackgroundImage = Properties.Resources.žuto_sjedalo;
                    ((Button)sender).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    listaSjedala.Remove(oznake[1] + oznake[2]);
                    this.label12.Text = "";
                    foreach (string s in listaSjedala) { this.label12.Text += s + ", "; }
                    if (listaSjedala.Count == 0) { this.label12.Text = ""; brojac--; label10.Text = ""; }
                    else { this.label12.Text = this.label12.Text.Substring(0, this.label12.Text.Length - 2); brojac--; label10.Text = brojac.ToString(); }



                }
            }
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PotvrdiKupnju_Click(object sender, EventArgs e)
        {
            int IdSjedala = -1;
            //this.label13.Text = Properties.Settings.Default.Database1ConnectionString;
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
                            cm.Parameters["@dvorana"].Value = this.Name;

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
                        
                        PrintForma printForma = new PrintForma(_ImeFilma, _DatumPrikazivanja, _sat, this.Name, sjedala, (listaSjedala.Count * cijena_ulaznice).ToString(), cijena_ulaznice);
                        printForma.Closed += (s, args) => this.Close();

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


