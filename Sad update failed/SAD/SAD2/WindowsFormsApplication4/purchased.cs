using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class purchased : Form
    {
        MySqlConnection conn;
        public purchased()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }
        public void loadAll()
        {
            string query = "select order_id, DATE_FORMAT(order_date, '%M %d, %Y') as order_date from ordering";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["order_id"].Visible = false;
            dataGridView1.Columns["order_date"].HeaderText = "Date";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
