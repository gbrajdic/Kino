using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class BazaZaduženja : Form
    {
        public BazaZaduženja()
        {
            InitializeComponent();
        }

        private void zaduzenjaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaduzenjaBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void BazaZaduženja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Zaduzenja' table. You can move, or remove it, as needed.
            this.zaduzenjaTableAdapter1.Fill(this.database1DataSet1.Zaduzenja);
          

        }


    }
}
