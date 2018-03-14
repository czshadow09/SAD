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
            Update.Enabled = false;
          
            loadAll2();
        }

        public void loadAll2()
        {
            string query = "select p.product_id, p.description, p.unit, c.name, p.purchase_price, p.store_price, p.inc, p.cur_price, stock_in, stock_out, p.tot_quantity, p.cost_quantity from product p inner join category c on p.category_cat_id = c.cat_id;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["product_id"].Visible = false;
            dataGridView2.Columns["cost_quantity"].Visible = false;
            dataGridView2.Columns["inc"].Visible = false;
            dataGridView2.Columns["purchase_price"].Visible = false;
            dataGridView2.Columns["store_price"].Visible = false;
            dataGridView2.Columns["cur_price"].Visible = false;
            dataGridView2.Columns["description"].HeaderText = "Product Name";
            dataGridView2.Columns["name"].HeaderText = "Category";
            dataGridView2.Columns["unit"].HeaderText = "Measurement";
            dataGridView2.Columns["purchase_price"].Visible = false;
            dataGridView2.Columns["store_price"].Visible = false;
            dataGridView2.Columns["stock_in"].HeaderText = "In";
            dataGridView2.Columns["stock_out"].HeaderText = "Out";
            dataGridView2.Columns["tot_quantity"].Visible = false;
        }

        private void In_Click(object sender, EventArgs e)
        {
            In a = new In();
            a.id.Text = dataGridView2.CurrentRow.Cells["product_id"].Value.ToString();
            a.Show();
        }
        private void Out_Click(object sender, EventArgs e)
        {
            Out a = new Out();
            a.id.Text = dataGridView2.CurrentRow.Cells["product_id"].Value.ToString();
            a.Show();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            prod a = new prod();
            a.Show();
        }

        private void Se_Click(object sender, EventArgs e)
        {
            string query = "select p.description, p.unit, c.name, concat('₱', format(p.purchase_price,2)) as purchase_price, concat('₱', format(p.store_price,2)) as store_price, p.stock_in, p.stock_out, p.tot_quantity from product p inner join category c on p.category_cat_id = c.cat_id where p.description like'" + search.Text + "%';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void view_Click(object sender, EventArgs e)
        {
            loadAll2();
            search.Clear();
            categ.SelectedIndex = -1;
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select p.product_id, p.description, p.unit, c.name, concat('₱', format(p.purchase_price,2)) as purchase_price, concat('₱', format(p.store_price,2)) as store_price, p.inc, p.cur_price, p.stock_in, p.stock_out, p.tot_quantity from product p inner join category c on p.category_cat_id = c.cat_id where c.name='" + categ.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private int select_user_id;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            In i = new In();
            select_user_id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView2.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            prodname.Text = dataGridView2.Rows[e.RowIndex].Cells["description"].Value.ToString();
            quantity.Text = dataGridView2.Rows[e.RowIndex].Cells["tot_quantity"].Value.ToString();
            currentp.Text = dataGridView2.Rows[e.RowIndex].Cells["cur_price"].Value.ToString();
            price.Text = dataGridView2.Rows[e.RowIndex].Cells["store_price"].Value.ToString();
            increase.Text = dataGridView2.Rows[e.RowIndex].Cells["inc"].Value.ToString();
            unit.Text = dataGridView2.Rows[e.RowIndex].Cells["unit"].Value.ToString();
            cons_quan.Text = dataGridView2.Rows[e.RowIndex].Cells["cost_quantity"].Value.ToString();
            double constant = Double.Parse(cons_quan.Text);
            constant = constant * 0.3;
            cons_quan.Text = constant.ToString();
            Update.Enabled = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            decimal curp = Convert.ToDecimal(increase.Text);
            decimal orgp = Convert.ToDecimal(price.Text);
            decimal sum = curp + orgp;
            string query = "";
            string query2 = "SELECT description FROM product WHERE description='" + prodname.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query2, conn);
            MySqlDataAdapter user = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            user.Fill(dt);
            if (String.IsNullOrEmpty(id.Text) || String.IsNullOrEmpty(prodname.Text) || String.IsNullOrEmpty(price.Text) || String.IsNullOrEmpty(increase.Text) || String.IsNullOrEmpty(unit.Text))
                MessageBox.Show("Please select a product by clicking one.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.Rows.Count > 1)
                {
                    MessageBox.Show("Product already exist. Please choose a different product", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query += " UPDATE product SET description='" + prodname.Text + "', store_price='" + price.Text + "', inc='" + increase.Text + "', unit='" + unit.Text + "', cur_price='" + sum + "' where product_id='" + id.Text + "';";
                    MessageBox.Show("Product updated!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    executeQuery(query);
                }
                loadAll2();
            }
        }
    }
}
