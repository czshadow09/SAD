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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Print_Receipt' table. You can move, or remove it, as needed.
            this.Print_ReceiptTableAdapter.Fill(this.DataSet1.Print_Receipt);

            this.reportViewer1.RefreshReport();
        }
    }
}
