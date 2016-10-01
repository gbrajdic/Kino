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
    public partial class BazaTermina : Form
    {
        public BazaTermina()
        {
            InitializeComponent();
        }

        private void terminiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terminiBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void BazaTermina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Termini' table. You can move, or remove it, as needed.
            this.terminiTableAdapter1.Fill(this.database1DataSet1.Termini);
            // TODO: This line of code loads data into the 'database1DataSet.Termini' table. You can move, or remove it, as needed.
           

        }


    }
}
