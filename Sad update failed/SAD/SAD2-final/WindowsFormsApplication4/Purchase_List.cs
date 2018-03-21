using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Purchase_List : Form
    {
        public Purchase_List()
        {
            InitializeComponent();
        }

        private void Purchase_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Purchase1' table. You can move, or remove it, as needed.
            this.Purchase1TableAdapter.Fill(this.DataSet1.Purchase1);

            this.reportViewer1.RefreshReport();
        }
    }
}
