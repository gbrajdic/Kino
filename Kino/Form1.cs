using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmovi_Click(object sender, EventArgs e)
        {
            Form2 filmovi = new Form2();
            filmovi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 trenutno = new Form3();
            trenutno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvorane_Click(object sender, EventArgs e)
        {
            Dvorane dvorana = new Dvorane();
            dvorana.ShowDialog();
        }
    }
}
