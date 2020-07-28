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
    public partial class Inventory_Report : Form
    {
        public Inventory_Report()
        {
            InitializeComponent();
        }

        private void Inventory_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Inventory_Report' table. You can move, or remove it, as needed.
            this.Inventory_ReportTableAdapter.Fill(this.DataSet1.Inventory_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
