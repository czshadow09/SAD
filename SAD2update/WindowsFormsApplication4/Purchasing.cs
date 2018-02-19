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

        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void CreateDataTableColumns()
        {
            dt.Columns.Add("Product");
            dt.Columns.Add("Unit");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price", typeof(decimal));
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
            loadAll();
        }

        private void loadAll()
        {
            string query = "select p.product_id, p.description, p.unit, c.name, p.stock_in from product p inner join category c on p.category_cat_id = c.cat_id where p.stock_in <= 30;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["product_id"].Visible = false;
            dataGridView1.Columns["stock_in"].Visible = false;
            dataGridView1.Columns["description"].HeaderText = "Product Name";
            dataGridView1.Columns["unit"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Category";
            unit1.Enabled = false;
            purchase.Enabled = false;
            quan.Enabled = false;
            addquan.Enabled = false;
        }

        private void refr()
        {
            loadAll();
            unit1.Clear();
            purchase.Clear();
            quan.Clear();
            purchasetotal.Clear();
            dt.Rows.Clear();
        }

        private void remv()
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(row);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            prod a = new prod();
            a.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            decimal purc = Convert.ToDecimal(purchase.Text);
            decimal qua = Convert.ToDecimal(quan.Text);
            decimal amount = purc * qua;
            DataRow dr = dt.NewRow();
            dr["Product"] = prod.Text;
            dr["Unit"] = unit1.Text;
            dr["Quantity"] = quan.Text;
            dr["Price"] = amount;
            dt.Rows.Add(dr);
            dataGridView2.DataSource = dt;
            decimal sum = Convert.ToDecimal(dt.Compute("SUM(Price)", string.Empty));
            purchasetotal.Text = sum.ToString();
        }

        private int select_id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            prod.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
            unit1.Text = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();
            cur_quan.Text = dataGridView1.Rows[e.RowIndex].Cells["stock_in"].Value.ToString();
            unit1.Enabled = true;
            purchase.Enabled = true;
            quan.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prod2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            unit2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            quan2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            price.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            addquan.Enabled = true;
        }

        private void addquan_Click(object sender, EventArgs e)
        {
            string query = "select description, stock_in from product where product_id='" + id.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int quant = Int32.Parse(quan2.Text);
            int curq = Int32.Parse(cur_quan.Text);
            int sum = quant + curq;
            if(quant == 0)
            {
                MessageBox.Show("Nothing added!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string query1 = "UPDATE product SET purchase_price='" + purchase.Text + "', stock_in='" + sum + "' where product_id= '" + id.Text + "' and unit='" + unit1.Text + "';";
                executeQuery(query1);
                MessageBox.Show("Adding '" + quan2.Text + "' items to inventory!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                remv();
                loadAll();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refr();
        }
    }
}
