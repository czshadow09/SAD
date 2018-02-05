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
    public partial class transaction : UserControl
    {
        MySqlConnection conn;
        DataTable dt = new DataTable(); //at class level
        public transaction()
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
        public void loadAll()
        {
            string query = "select p.product_id, p.description, c.name, format(store_price,2) as store_price, stock_out from product p inner join category c on p.category_cat_id = c.cat_id where p.stock_out > 0;";
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
            dataGridView1.Columns["store_price"].HeaderText = "Price";
            dataGridView1.Columns["stock_out"].HeaderText = "Available";
        }
        private void CreateDataTableColumns()
        {
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Amount", typeof(decimal));
        }

        private void transaction_Load(object sender, EventArgs e)
        {
            CreateDataTableColumns();
            loadAll();
            subtot.Text = "0.00";
            res.Text = "0.00";
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Se_Click(object sender, EventArgs e)
        {

        }
        private int select_user_id;

        private void refr()
        {
            loadAll();
            name.Clear();
            sprice.Clear();
            avquan.Clear();
            quan.Clear();
            amount.Clear();
            subtot.Clear();
            tax.Clear();
            res.Clear();
            gratot.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            name.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
            sprice.Text = dataGridView1.Rows[e.RowIndex].Cells["store_price"].Value.ToString();
            avquan.Text = dataGridView1.Rows[e.RowIndex].Cells["stock_out"].Value.ToString();
        }

        private void quan_KeyUp(object sender, KeyEventArgs e)
        {
            string query = "select format(store_price * '" + quan.Text + "',2) from product where product_id='" + id.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            amount.Text = dt.Rows[0][0].ToString();
        }
        private void quan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Product"] = name.Text;
            dr["Quantity"] = quan.Text;
            dr["Amount"] = amount.Text;
            dt.Rows.Add(dr);
            dataGridView2.DataSource = dt;
            decimal sum = Convert.ToDecimal(dt.Compute("SUM(Amount)", string.Empty));
            subtot.Text = sum.ToString();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(row);
        }

        private void tax_KeyUp(object sender, KeyEventArgs e)
        {
            decimal amo = Convert.ToDecimal(subtot.Text);
            decimal ta = Convert.ToDecimal(tax.Text);
            decimal per = (ta / 100) * amo;
            decimal grandto = amo + per;
            res.Text = per.ToString();
            gratot.Text = grandto.ToString();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refr();
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void payment_KeyUp(object sender, KeyEventArgs e)
        {
            decimal grandtot = Convert.ToDecimal(gratot.Text);
            decimal pay = Convert.ToDecimal(payment.Text);
            decimal chan = grandtot - pay;
            change.Text = chan.ToString();
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(payment.Text) || String.IsNullOrEmpty(change.Text))
            {
                MessageBox.Show("Please fill up the field.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string query = "Insert Into ordering(order_date) values(now())";
                executeQuery(query);
                MessageBox.Show("Order added." + "\n" + "Payment: " + payment.Text + " \n" + "Change: " + change.Text + "", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel3.Visible = false;
                panel4.Visible = false;
                refr();
            }
        }

        private void tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchased a = new purchased();
            a.Show();
        }
    }
}
