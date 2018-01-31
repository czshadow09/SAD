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
    public partial class Purchasing : UserControl
    {
        MySqlConnection conn;
        public Purchasing()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }

        private void Se_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            string query = "select p.product_id, p.description, c.name from product p inner join category c on p.category_cat_id = c.cat_id where p.tot_quantity <= cost_quantity * 0.3;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["product_id"].Visible = false;
            dataGridView1.Columns["description"].HeaderText = "Product Name";
            dataGridView1.Columns["name"].HeaderText = "Category";
        }
    }
}
