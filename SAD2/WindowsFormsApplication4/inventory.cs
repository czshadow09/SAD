using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class inventory : UserControl
    {
        MySqlConnection conn;
        public inventory()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            loadAll();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Out a = new Out();
            a.Show();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            loadAll();
        }
        private void loadAll()
        {
            string query = "select * from product;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["product_id"].Visible = false;
            dataGridView1.Columns["stock_in"].Visible = false;
            dataGridView1.Columns["stock_out"].Visible = false;
            dataGridView1.Columns["description"].HeaderText = "Product Name";
            dataGridView1.Columns["category"].HeaderText = "Category";
            dataGridView1.Columns["purchase_price"].HeaderText = "Purchase Price";
            dataGridView1.Columns["store_price"].HeaderText = "Store Price";
            dataGridView1.Columns["tot_quantity"].HeaderText = "Quantity";
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["product_id"].Visible = false;
            dataGridView2.Columns["description"].HeaderText = "Product Name";
            dataGridView2.Columns["category"].HeaderText = "Category";
            dataGridView2.Columns["purchase_price"].HeaderText = "Purchase Price";
            dataGridView2.Columns["store_price"].HeaderText = "Store Price";
            dataGridView2.Columns["stock_in"].HeaderText = "In";
            dataGridView2.Columns["stock_out"].HeaderText = "Out";
            dataGridView2.Columns["tot_quantity"].HeaderText = "Quantity";
        }

        private void In_Click(object sender, EventArgs e)
        {
            In a = new In();
            a.Show();
        }
    }
}
