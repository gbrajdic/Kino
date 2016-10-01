using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class NultaForma : Form
    {
        SqlConnection cn = null;
        SqlConnection cn2 = null;
        SqlDataReader reader = null;
        
        public NultaForma()
        {
           
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn2 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
           
            InitializeComponent();
            this.Load += NultaForma_Load;
        }


        private void NultaForma_Load(object sender, System.EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Select Id FROM Termini  WHERE Termini.DatumPrikazivanja < cast(getdate() as date)", cn);
                reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        cn2.Open();
                        SqlCommand cm1 = new SqlCommand("Delete FROM Zauzetost WHERE IdTermina=@Id", cn2);
                        cm1.Parameters.Add("@Id", SqlDbType.Int);
                        cm1.Parameters["@Id"].Value = Convert.ToInt32(reader["Id"].ToString().Trim());
                        cm1.ExecuteNonQuery();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.ToString());
                    }
                    finally
                    {


                        if (cn2 != null)
                            cn2.Close();

                    }

                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
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
                cn.Open();
                SqlCommand cm = new SqlCommand("Delete FROM Termini  WHERE Termini.DatumPrikazivanja < cast(getdate() as date)", cn);
                cm.ExecuteNonQuery();
            }

            catch (Exception h)
            {
                MessageBox.Show(h.ToString());
            }
            finally
            {
                

                if (cn != null)
                    cn.Close();

            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dvorane_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenici = new Zaposlenici();
            zaposlenici.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administracija admin = new Administracija();
            admin.ShowDialog();
        }
    }
}