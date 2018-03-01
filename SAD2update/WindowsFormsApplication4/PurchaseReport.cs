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
    public partial class PurchaseReport : Form
    {
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reports.PurchaseOrder' table. You can move, or remove it, as needed.
            this.PurchaseOrderTableAdapter.Fill(this.Reports.PurchaseOrder);

            this.reportViewer1.RefreshReport();
        }
    }
}
