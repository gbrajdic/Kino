using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kino
{
    public partial class Zaduzenja : Form
    {
        int id;
        string ime;
        string prezime;

        SqlConnection cn = null;
        SqlConnection cn1 = null;
        SqlDataReader reader = null;
        

        
        public Zaduzenja()
        {
     
            InitializeComponent();
    
        }



        public Zaduzenja(int _id, string _ime, string _prezime)
        {
            cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            cn1 = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            id = _id;
            ime = _ime;
            prezime = _prezime;

            InitializeComponent();

            Load += Zaduzenja_Load;
            button1.Click += Button1_Click;
        }

        private void Zaduzenja_Load(object sender, System.EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("Select Vrijeme_datum_zaduzenja, Opis_zaduzenja, Nadzorna_osoba from Zaduzenja WHERE Id_zaposlenika=@Id_zaposlenika", cn);
                cm.Parameters.Add("@Id_zaposlenika", SqlDbType.Int);
                cm.Parameters["@Id_zaposlenika"].Value = id;
                reader = cm.ExecuteReader();
                int brojac = 1;
                while (reader.Read())
                {

                    GroupBox groupBox1 = new GroupBox();
                    TextBox textBox3 = new TextBox();
                    Label label3 = new Label();
                    TextBox textBox2 = new TextBox();
                    Label label2 = new Label();
                    TextBox textBox1 = new TextBox();
                    Label label1 = new Label();
                    Label label5 = new Label();
                    Label label4 = new Label();
                    TextBox textBox4 = new TextBox();
                    TextBox textBox5 = new TextBox();

                    groupBox1.Controls.Add(textBox5);
                    groupBox1.Controls.Add(label5);
                    groupBox1.Controls.Add(label4);
                    groupBox1.Controls.Add(textBox4);
                    groupBox1.Controls.Add(textBox3);
                    groupBox1.Controls.Add(label3);
                    groupBox1.Controls.Add(textBox2);
                    groupBox1.Controls.Add(label2);
                    groupBox1.Controls.Add(textBox1);
                    groupBox1.Controls.Add(label1);
                   
                    groupBox1.FlatStyle = FlatStyle.Popup;
                    groupBox1.Location = new Point(3, 3);
                    
                    groupBox1.Name = "groupBox1";
                    groupBox1.Size = new Size(570, 452);
                    groupBox1.TabIndex = 0;
                    groupBox1.TabStop = false;
                    groupBox1.Text = "Zaduženje br. "+brojac.ToString();
                    groupBox1.Margin = new Padding(5, 10, 5, 5);
                    groupBox1.BackColor = Color.LightSalmon;

                    //groupBox1.ForeColor = System.Drawing.Color.White;
                    groupBox1.Font= new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    brojac++;


                    textBox5.Location = new Point(159, 392);
                    textBox5.Name = "textBox5";
                    textBox5.Size = new Size(212, 22);
                    textBox5.TabIndex = 9;
                    textBox5.Text = reader["Nadzorna_osoba"].ToString();
                    textBox5.ReadOnly = true;
                    // 
                    // label5
                    // 
                    label5.AutoSize = true;
                    label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    label5.Location = new Point(34, 393);
                    label5.Name = "label5";
                    label5.Size = new Size(119, 18);
                    label5.TabIndex = 8;
                    label5.Text = "Nadzorna osoba";
                    // 
                    // label4
                    // 
                    label4.AutoSize = true;
                    label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    label4.Location = new Point(26, 192);
                    label4.Name = "label4";
                    label4.Size = new Size(110, 18);
                    label4.TabIndex = 7;
                    label4.Text = "Opis zaduženja";
                    // 
                    // textBox4
                    // 
                    textBox4.Location = new Point(150, 192);
                    textBox4.Multiline = true;
                    textBox4.Name = "textBox4";
                    textBox4.Size = new Size(400, 154);
                    textBox4.TabIndex = 6;
                    textBox4.Text += reader["Opis_zaduzenja"].ToString() + System.Environment.NewLine;
                    textBox4.SelectionStart = textBox4.Text.Length;
                    textBox4.ReadOnly = true;
                    textBox4.ScrollToCaret();

                    // 
                    // textBox3
                    // 
                    textBox3.Location = new Point(155, 109);
                    textBox3.Name = "textBox3";
                    textBox3.Size = new Size(193, 22);
                    textBox3.TabIndex = 5;
                    textBox3.Text = reader["Vrijeme_datum_zaduzenja"].ToString();
                    textBox3.ReadOnly = true;
                    // 
                    // label3
                    // 
                    label3.AutoSize = true;
                    label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    label3.Location = new Point(26, 110);
                    label3.Name = "label3";
                    label3.Size = new Size(123, 18);
                    label3.TabIndex = 4;
                    label3.Text = "Datum zaduženja";

                    // 
                    // textBox2
                    // 
                    textBox2.Location = new Point(377, 48);
                    textBox2.Name = "textBox2";
                    textBox2.Size = new Size(173, 22);
                    textBox2.TabIndex = 3;
                    textBox2.Text = prezime;
                    textBox2.ReadOnly = true;
                    // 
                    // label2
                    // 
                    label2.AutoSize = true;
                    label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    label2.Location = new Point(308, 49);
                    label2.Name = "label2";
                    label2.Size = new Size(63, 18);
                    label2.TabIndex = 2;
                    label2.Text = "Prezime";
                    // 
                    // textBox1
                    // 
                    textBox1.Location = new Point(64, 46);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new Size(156, 22);
                    textBox1.TabIndex = 1;
                    textBox1.Text = ime;
                    textBox1.ReadOnly = true;
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    label1.Location = new Point(26, 49);
                    label1.Name = "label1";
                    label1.Size = new Size(32, 18);
                    label1.TabIndex = 0;
                    label1.Text = "Ime";


                    flowLayoutPanel1.Controls.Add(groupBox1);
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

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }


    }
}
