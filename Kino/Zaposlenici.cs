using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kino
{
    public partial class Zaposlenici : Form
    {
        SqlConnection cn = null;
        SqlConnection cn1 = null;
        SqlDataReader reader = null;
        
        Zaduzenja zaduzenja;

        bool flag;
      
        public Zaposlenici()
        {
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn1 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            InitializeComponent();
            radioButton2.Click += RadioButton2_Click;
            radioButton1.Click += RadioButton1_Click;
            comboBox1.Items.AddRange(new object[] {
            "Voditelj kina",
            "Blagajnik",
            "Kino službenik",
            "Kino i audio operater",
            "Kinooperater",
            "Security",
            "Sanitarni službenik"});
            comboBox1.SelectedIndex = 0;
            comboBox1.Visible = false;
            button1.Click += Button1_Click;
            listBox1.SelectedValueChanged += ListBox1_SelectedValueChanged;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            Load += Zaposlenici_Load;
        }


        private void RadioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { comboBox1.Visible = true; }
        }


        private void RadioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                comboBox1.Visible = false;
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                try
                {
                    
                    cn.Open();
                    SqlCommand cm = new SqlCommand("Select OIB, Ime, Prezime FROM Zaposlenici WHERE Naziv_radnog_mjesta=@radno_mjesto", cn);
                    cm.Parameters.Add("@radno_mjesto", SqlDbType.VarChar);
                    cm.Parameters["@radno_mjesto"].Value = comboBox1.SelectedItem.ToString();
                    listBox1.Items.Clear();
                    reader = cm.ExecuteReader();
                  
                    while (reader.Read())
                    {

                        listBox1.Items.Add(reader["OIB"].ToString().Trim() + "    " + reader["Ime"].ToString().Trim() + "    " + reader["Prezime"].ToString().Trim());
                    }


                }

                catch
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

            else
            {
                if (radioButton1.Checked)
                {

                    try
                    {
                        cn.Open();
                        SqlCommand cm = new SqlCommand("Select OIB, Ime, Prezime from Zaposlenici", cn);
                        listBox1.Items.Clear();
                        reader = cm.ExecuteReader();
                       
                        while (reader.Read())
                        {

                            listBox1.Items.Add(reader["OIB"].ToString().Trim() + "    " + reader["Ime"].ToString().Trim() + "    " + reader["Prezime"].ToString().Trim());
                        }


                    }

                    catch
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
            }
        }



        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                Regex regularniIzraz = new Regex("    ");
                string[] oznake = regularniIzraz.Split((string)((ListBox)sender).SelectedItem);

                try
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("Select OIB, Ime, Prezime, Mjesto_stanovanja, UlicaKB, Naziv_radnog_mjesta, Netto_placa, Početak_radnog_odnosa FROM Zaposlenici WHERE OIB=@OIB", cn);
                    cm.Parameters.Add("@OIB", SqlDbType.VarChar);
                    cm.Parameters["@OIB"].Value = oznake[0];
                    reader = cm.ExecuteReader();

                    while (reader.Read())
                    {
                        textBox1.Text = reader["Ime"].ToString().Trim();
                        textBox1.ReadOnly = true;

                        textBox2.Text = reader["Prezime"].ToString().Trim();
                        textBox2.ReadOnly = true;

                        textBox3.Text = reader["OIB"].ToString().Trim();
                        textBox3.ReadOnly = true;

                        textBox4.Text = reader["Mjesto_stanovanja"].ToString().Trim();
                        textBox4.ReadOnly = true;

                        textBox5.Text = reader["UlicaKB"].ToString().Trim();
                        textBox5.ReadOnly = true;

                        textBox6.Text = reader["Naziv_radnog_mjesta"].ToString().Trim();
                        textBox6.ReadOnly = true;

                        textBox8.Text = reader["Netto_placa"].ToString().Trim();
                        textBox8.ReadOnly = true;

                        textBox7.Text = reader["Početak_radnog_odnosa"].ToString().Trim().Split(' ')[0];
                        textBox7.ReadOnly = true;
                        flag = true;
                    }

                       


                }

                catch
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
        }


        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Select OIB, Ime, Prezime from Zaposlenici", cn);
                reader = cm.ExecuteReader();
                while (reader.Read())
                {

                    listBox1.Items.Add(reader["OIB"].ToString().Trim() + "    " + reader["Ime"].ToString().Trim() + "    " + reader["Prezime"].ToString().Trim());
                }

               
            }

            catch
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

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            

            if (flag)
            {
                try
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("Select Id_zaposlenika from Zaposlenici WHERE OIB=@OIB", cn);
                    cm.Parameters.Add("@OIB", SqlDbType.VarChar);
                    cm.Parameters["@OIB"].Value = textBox3.Text;
                    reader = cm.ExecuteReader();
                    int id = -1;
                    while (reader.Read())
                    {

                        id = Convert.ToInt32(reader["Id_zaposlenika"].ToString().Trim());
                    }
                    
                    zaduzenja = new Zaduzenja(id, textBox1.Text, textBox2.Text);
                    zaduzenja.ShowDialog();

                }

                catch
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
        }

    }
}
