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
            
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM category;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                categ.Items.Add(dt.Rows[x][1].ToString());
            }
          
            loadAll2();
        }

        public void loadAll2()
        {
            string query = "select p.description, c.name, concat('₱', format(p.purchase_price,2)) as purchase_price, concat('₱', format(p.store_price,2)) as store_price, p.stock_in, p.stock_out, p.tot_quantity from product p inner join category c on p.category_cat_id = c.cat_id;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["description"].HeaderText = "Product Name";
            dataGridView2.Columns["name"].HeaderText = "Category";
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
        private void Out_Click(object sender, EventArgs e)
        {
            Out a = new Out();
            a.Show();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            prod a = new prod();
            a.Show();
        }
    }
}
