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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reports.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.Fill(this.Reports.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
