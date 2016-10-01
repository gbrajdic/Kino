using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class BazaFilmova : Form
    {
        public BazaFilmova()
        {
            InitializeComponent();
        }

        private void filmoviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmoviBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void BazaFilmova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Filmovi' table. You can move, or remove it, as needed.
            this.filmoviTableAdapter1.Fill(this.database1DataSet1.Filmovi);
            // TODO: This line of code loads data into the 'database1DataSet.Filmovi' table. You can move, or remove it, as needed.
            //this.filmoviTableAdapter1.Fill(this.database1DataSet1.Filmovi);

        }

       

        private void filmoviDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridViewImageCell cell = filmoviDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                if (cell != null)
                {
                    openFileDialog1.ShowDialog();
                    cell.Value = imageToByteArray(new Bitmap(openFileDialog1.FileName));
                }
            }
        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
