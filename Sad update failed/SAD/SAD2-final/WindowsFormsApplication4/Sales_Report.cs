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
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Sales_Report' table. You can move, or remove it, as needed.
            this.Sales_ReportTableAdapter.Fill(this.DataSet1.Sales_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
