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
        public UserControl a3;
        public Purchasing()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
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
            loadAll2();
        }

        public void loadAll()
        {
            string query = "select p.product_id, p.description, u.name, p.stock_in from product p inner join unit u on p.unit_unit_id = u.unit_id where p.stock_in <= 30;";
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
            dataGridView1.Columns["name"].HeaderText = "Unit";
            unit1.Enabled = false;
            purchase.Enabled = false;
            quan.Enabled = false;
            addquan.Enabled = false;
        }
        public void loadAll2()
        {
            string query = "select * from purchase_order";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns["plist_id"].Visible = false;
            dataGridView3.Columns["purchase_date"].HeaderText = "Date";
            dataGridView3.Columns["tot_consume"].HeaderText = "Total Amount";
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
            a.a3 = this;
            DialogResult res = a.ShowDialog();
            if (res == DialogResult.Yes)
            {
                a.Show();
                loadAll();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(purchase.Text) || String.IsNullOrEmpty(quan.Text))
            {
                MessageBox.Show("Both price and quantity required!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal purc = Convert.ToDecimal(purchase.Text);
                decimal qua = Convert.ToDecimal(quan.Text);
                decimal amount = purc * qua;
                int quant = Int32.Parse(quan.Text);
                int curq = Int32.Parse(cur_quan.Text);
                int sum = quant + curq;
                DataRow dr = dt.NewRow();
                dr["Product"] = prod.Text;
                dr["Unit"] = unit1.Text;
                dr["Quantity"] = quan.Text;
                dr["Price"] = amount;
                dt.Rows.Add(dr);
                dataGridView2.DataSource = dt;
                decimal sum1 = Convert.ToDecimal(dt.Compute("SUM(Price)", string.Empty));
                purchasetotal.Text = sum1.ToString();
                string query2 = "INSERT INTO purchasing(purchase_price, quantity_sold, product_product_id) VALUES( '" + purchase.Text + "', '" + sum + "', '" + id.Text + "');";
                string query1 = "UPDATE product SET store_price='" + purchase.Text + "', cur_price='" + purchase.Text + "', stock_in='" + sum + "' where product_id= '" + id.Text + "';";
                executeQuery(query2);
                executeQuery(query1);
                addquan.Enabled = true;
            }
            
        }

        private int select_id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            prod.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
            unit1.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
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
            string query1 = "Insert Into purchase_order(purchase_date, tot_consume, purchasing_purchased_id) values(now(), '" + purchasetotal.Text + "')";
            executeQuery(query1);

            MessageBox.Show("Total payments: '" + purchasetotal.Text + "' ", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refr();
            loadAll();
            loadAll2();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refr();
        }

       

        private void Close_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void usereport_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            refr();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        Bitmap bmp;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void print_Click(object sender, EventArgs e)
        {
            PurchaseReport print = new PurchaseReport();
            print.Show();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
