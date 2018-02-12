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
        DataTable dt = new DataTable();
        public Purchasing()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }

        private void CreateDataTableColumns()
        {
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Status");
        }

        private void Se_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            CreateDataTableColumns();
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

        private void Add_Click(object sender, EventArgs e)
        {
            prod a = new prod();
            a.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Product"] = prod.Text;
            dr["Quantity"] = quan.Text;
            dr["Status"] = status.Text;
            dt.Rows.Add(dr);
            dataGridView2.DataSource = dt;
        }

        private int select_id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            prod.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
        }
    }
}
