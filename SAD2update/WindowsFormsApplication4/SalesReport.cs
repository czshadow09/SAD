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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reports.Ordering' table. You can move, or remove it, as needed.
            this.OrderingTableAdapter.Fill(this.Reports.Ordering);

            this.reportViewer1.RefreshReport();
        }
    }
}
