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
    public partial class BazaZaposlenika : Form
    {
        public BazaZaposlenika()
        {
            InitializeComponent();
        }

        private void zaposleniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposleniciBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void BazaZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter1.Fill(this.database1DataSet1.Zaposlenici);
            // TODO: This line of code loads data into the 'database1DataSet.Zaposlenici' table. You can move, or remove it, as needed.
            

        }


    }
}
