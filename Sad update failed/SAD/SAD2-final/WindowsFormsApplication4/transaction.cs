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
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
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
            string query = "select p.product_id, p.description, c.name, format(cur_price,2) as store_price, stock_in from product p inner join category c on p.category_cat_id = c.cat_id where p.stock_in > 0;";
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
            dataGridView1.Columns["stock_in"].HeaderText = "Available";
            quan.Enabled = false;
            add.Enabled = false;
            remove.Enabled = false;
            checkout.Enabled = false;
            date.Enabled = false;
        }

        public void loadAll2()
        {
            string query = "select o.order_date, o.order_id, o.tot_consume, u.lastname from sales_order o inner join user u on o.user_user_id = u.user_id;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns["order_date"].HeaderText = "Date";
            dataGridView3.Columns["order_id"].HeaderText = "Customer #";
            dataGridView3.Columns["tot_consume"].HeaderText = "Total Amount";
            dataGridView3.Columns["lastname"].HeaderText = "Encoder";
            if (dt.Rows.Count > 0) {
                decimal sum = Convert.ToDecimal(dt.Compute("SUM(tot_consume)", string.Empty));
                purchasetotal.Text = sum.ToString();
            }
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
            loadAll2();
            subtot.Text = "0.00";
            date.Text = DateTime.Now.ToString("dd/MM/yyy, HH:mm");
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
            string query = "select p.product_id, p.description, c.name, format(cur_price,2) as store_price, stock_in from product p inner join category c on p.category_cat_id = c.cat_id where p.stock_in > 0 and p.description like '" + search.Text + "%';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private int select_user_id;

        private void refr()
        {
            loadAll();
            loadAll2();
            name.Clear();
            sprice.Clear();
            avquan.Clear();
            quan.Clear();
            amount.Clear();
            subtot.Text = "0.00";
            payment.Clear();
            change.Clear();
            dt.Rows.Clear();
        }

        private void addrefr()
        {
            string query = "select p.product_id, p.description, c.name, format(cur_price,2) as store_price, stock_in from product p inner join category c on p.category_cat_id = c.cat_id where p.stock_in > 0;";
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
            dataGridView1.Columns["stock_in"].HeaderText = "Available";
            quan.Enabled = false;
            add.Enabled = false;
            date.Enabled = false;
            quan.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            name.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
            sprice.Text = dataGridView1.Rows[e.RowIndex].Cells["store_price"].Value.ToString();
            avquan.Text = dataGridView1.Rows[e.RowIndex].Cells["stock_in"].Value.ToString();
            quan.Enabled = true;
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
            if(amount.Text == "0.00")
            {
                add.Enabled = false;
            }
            else if(Int32.Parse(quan.Text) > Int32.Parse(avquan.Text))
            {
                add.Enabled = false;
            }

            else
            {
                add.Enabled = true;
            }
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
            int avq = Int32.Parse(avquan.Text);
            int q = Int32.Parse(quan.Text);
            int sale = avq - q;
            DataRow dr = dt.NewRow();
            dr["Product"] = name.Text;
            dr["Quantity"] = quan.Text;
            dr["Amount"] = amount.Text;
            dt.Rows.Add(dr);
            dataGridView2.DataSource = dt;
            decimal sum = Convert.ToDecimal(dt.Compute("SUM(Amount)", string.Empty));
            subtot.Text = sum.ToString();
            remove.Enabled = true;
            string query2 = "INSERT INTO sales(quantity_hand, product_product_id) VALUES('" + quan.Text + "', (SELECT product_id FROM product WHERE description='" + name.Text + "'));";
            string query1 = "Update product SET stock_in='" + sale + "' WHERE product_id='" + id.Text + "';";
            executeQuery(query1);
            executeQuery(query2);
            addrefr();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int avq = Int32.Parse(avquan.Text);
            int q = Int32.Parse(quan.Text);
            int sale = avq + q;
            string query1 = "Update product SET stock_in='" + sale + "' WHERE product_id='" + id2.Text + "';";
            executeQuery(query1);
            int row = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(row);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel your order?",
          "Log Out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                
            }
            else
            {

            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void payment_KeyUp(object sender, KeyEventArgs e)
        {
            decimal grandtot = Convert.ToDecimal(subtot.Text);
            decimal pay = Convert.ToDecimal(payment.Text);
            decimal cha = 0 - grandtot;
            decimal chan = cha + pay;
            change.Text = chan.ToString();
            if (chan < 0)
            {
                order.Enabled = false;
            }

            else
            {
                order.Enabled = true;
            }
        }
        private void payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string query = "select u.user_id from user u inner join login l on u.login_login_id = l.login_id where login_login_id = (select login_id from login where username='rjr');";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string id = dt.Rows[0][0].ToString();
            if (String.IsNullOrEmpty(payment.Text) || String.IsNullOrEmpty(change.Text))
            {
                MessageBox.Show("Please fill up the field.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string query1 = "Insert Into sales_order(order_date, tot_consume, user_user_id) values(now(), '" + subtot.Text + "', '" + id + "')";
                executeQuery(query1);
                MessageBox.Show("Order added." + "\n" + "Payment: " + payment.Text + " \n" + "Change: " + change.Text + "", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel3.Hide();
                
                refr();
                loadAll();
                loadAll2();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            panel3.Show();
            
        }

        private void subtot_TextChanged(object sender, EventArgs e)
        {
            decimal sub = Convert.ToDecimal(subtot.Text);
            if(sub > 0)
            {
                checkout.Enabled = true;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Item"] = name.Text;
            dr["Quantity_On_Hand"] = quan.Text;
            dr["SubTotal"] = amount.Text;
            dt.Rows.Add(dr);
            dataGridView4.DataSource = dt;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id2.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select o.order_date, o.order_id, o.tot_consume, u.lastname from sales_order o inner join user u on o.user_user_id = u.user_id where month(o.order_date)='" + month.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            if (month.Text == "January")
            {
                monthnum.Text = "1";
            }
            else if (month.Text == "February")
            {
                monthnum.Text = "2";
            }
            else if (month.Text == "March")
            {
                monthnum.Text = "3";
            }
            else if (month.Text == "April")
            {
                monthnum.Text = "4";
            }
            else if (month.Text == "May")
            {
                monthnum.Text = "5";
            }
            else if (month.Text == "June")
            {
                monthnum.Text = "6";
            }
            else if (month.Text == "July")
            {
                monthnum.Text = "7";
            }
            else if (month.Text == "August")
            {
                monthnum.Text = "8";
            }
            else if (month.Text == "September")
            {
                monthnum.Text = "9";
            }
            else if (month.Text == "October")
            {
                monthnum.Text = "10";
            }
            else if (month.Text == "November")
            {
                monthnum.Text = "11";
            }
            else if (month.Text == "December")
            {
                monthnum.Text = "12";
            }
        }

        private void refre_Click(object sender, EventArgs e)
        {
            refr();
        }
    }
}
