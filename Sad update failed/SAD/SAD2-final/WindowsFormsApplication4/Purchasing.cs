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
            dt.Columns.Add("PackQty");
            dt.Columns.Add("TotalPrice", typeof(decimal));
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dt.Columns["Product"];
            dt.PrimaryKey = keyColumns;
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
            string query = "select p.product_id, p.description, u.name, p.store_price, p.quan, p.stock_in, p.packquan, p.tot_quantity from product p inner join unit u on p.unit_unit_id = u.unit_id where p.stock_in <= 30;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["product_id"].Visible = false;
            dataGridView1.Columns["stock_in"].Visible = false;
            dataGridView1.Columns["packquan"].Visible = false;
            dataGridView1.Columns["store_price"].Visible = false;
            dataGridView1.Columns["quan"].Visible = false;
            dataGridView1.Columns["description"].HeaderText = "Product Name";
            dataGridView1.Columns["name"].HeaderText = "Unit";
            dataGridView1.Columns["tot_quantity"].HeaderText = "Quantity Needed";
            unit1.Enabled = false;
            purchase.Enabled = false;
            quan.Enabled = false;
            packqty.Enabled = false;
            addquan.Enabled = false;
            dataGridView1.Enabled = false;
        }
        public void loadAll2()
        {
            string query = "select p.purchase_date, p.plist_id, p.tot_consume, u.lastname from purchase_order p inner join user u on p.user_user_id = u.user_id";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns["plist_id"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Unit";
            dataGridView3.Columns["purchase_date"].HeaderText = "Date";
            dataGridView3.Columns["tot_consume"].HeaderText = "Total Amount";
            dataGridView3.Columns["lastname"].HeaderText = "Encoder";
        }
        public void loadAll3()
        {
            string query = "select po.plist_id, p.description, pr.purchase_price, pr.quantity_sold, pr.purchase_price * pr.quantity_sold as SubTotal from purchasing pr inner join product p on pr.product_product_id = p.product_id inner join purchase_order po on pr.purchase_order_plist_id = po.plist_id where po.plist_id = '" + ordid1.Text + ";'";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            ordid1.Text = dt.Rows[0][0].ToString();
            dataGridView4.DataSource = dt;
            dataGridView4.Columns["plist_id"].Visible = false;
            dataGridView4.Columns["description"].HeaderText = "Product";
            dataGridView4.Columns["purchase_price"].HeaderText = "Price";
            dataGridView4.Columns["quantity_sold"].HeaderText = "Quantity Hand";
            dataGridView4.Columns["Subtotal"].HeaderText = "Subtotal";
        }

        private void refr()
        {
            loadAll();
            unit1.Clear();
            purchase.Clear();
            quan.Clear();
            packqty.Clear();
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
            if (String.IsNullOrEmpty(purchase.Text) || String.IsNullOrEmpty(quan.Text))
            {
                MessageBox.Show("Both price and quantity required!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal purc = Convert.ToDecimal(purchase.Text);
                int quant = Int32.Parse(packqty.Text);
                int qua1 = Int32.Parse(quan.Text);
                int prod1 = quant * qua1;
                decimal qua = Convert.ToDecimal(packqty.Text);
                decimal amount = purc * prod1;
                int curq = Int32.Parse(cur_quan.Text);
                int sum = prod1 + curq;
                DataRow dr = dt.NewRow();
                dr["Product"] = prod.Text;
                dr["Unit"] = unit1.Text;
                dr["PackQty"] = prod1;
                dr["TotalPrice"] = amount;
                var rowExists = dt.Rows.Find(dr);
                if(rowExists == null)
                {
                    dt.Rows.Add(dr);
                }
                dataGridView2.DataSource = dt;
                decimal sum1 = Convert.ToDecimal(dt.Compute("SUM(TotalPrice)", string.Empty));
                purchasetotal.Text = sum1.ToString();
                if(dt.Rows.Count > 1)
                {
                    string query2 = "INSERT INTO purchasing(purchase_price, quantity_sold, product_product_id, purchase_order_plist_id) VALUES( '" + purchase.Text + "', '" + sum + "', '" + id.Text + "', '" + ordid.Text + "');";
                    executeQuery(query2);
                }
                else if(dt.Rows.Count == 1)
                {
                    string query4 = "UPDATE product SET quan='" + quan.Text + "', packquan='" + packqty.Text + "', tot_quantity='" + prod1 + "' where product_id='" + id.Text + "';";
                    executeQuery(query4);
                    string query2 = "INSERT INTO purchasing(purchase_price, quantity_sold, product_product_id, purchase_order_plist_id) VALUES( '" + purchase.Text + "', '" + sum + "', '" + id.Text + "', '" + ordid.Text + "');";
                    executeQuery(query2);
                }
                string query1 = "UPDATE product SET store_price='" + purchase.Text + "', cur_price='" + purchase.Text + "', stock_in='" + sum + "' where product_id= '" + id.Text + "';";
                executeQuery(query1);
                addquan.Enabled = true;
            }

        }

        private int select_id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select plist_id from purchase_order where tot_consume = 0;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            ordid.Text = dt.Rows[0][0].ToString();
            select_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            prod.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
            unit1.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            cur_quan.Text = dataGridView1.Rows[e.RowIndex].Cells["stock_in"].Value.ToString();
            purchase.Text = dataGridView1.Rows[e.RowIndex].Cells["store_price"].Value.ToString();
            quan.Text = dataGridView1.Rows[e.RowIndex].Cells["quan"].Value.ToString();
            packqty.Text = dataGridView1.Rows[e.RowIndex].Cells["packquan"].Value.ToString();
            unit1.Enabled = true;
            purchase.Enabled = true;
            quan.Enabled = true;
            packqty.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prod2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            unit2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            quan2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            price.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void insQuery()
        {
            string query = "select u.user_id from user u inner join login l on u.login_login_id = l.login_id where login_login_id = (select login_id from login where username='rjr');";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int id1 = Int32.Parse(dt.Rows[0][0].ToString());

            string query1 = "UPDATE purchase_order SET tot_consume='" + purchasetotal.Text + "' where plist_id='" + ordid.Text + "';";
            executeQuery(query1);
        }

        private void addquan_Click(object sender, EventArgs e)
        {
            string query = "select product_id, description, stock_in from product where product_id='" + id.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            insQuery();

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

        private int select_user_id;

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_user_id = int.Parse(dataGridView3.Rows[e.RowIndex].Cells["plist_id"].Value.ToString());
            ordid1.Text = dataGridView3.Rows[e.RowIndex].Cells["plist_id"].Value.ToString();
            loadAll3();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void morder_Click(object sender, EventArgs e)
        {
            string query = "select u.user_id from user u inner join login l on u.login_login_id = l.login_id where login_login_id = (select login_id from login where username='rjr');";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string id = dt.Rows[0][0].ToString();
            string query1 = "insert into purchase_order(purchase_date, tot_consume, user_user_id) values(now(), 0, '" + id + "');";
            executeQuery(query1);
            dataGridView1.Enabled = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            string query = "select po.purchase_date, po.plist_id, po.tot_consume, u.lastname from purchase_order po inner join user u on po.user_user_id = u.user_id where month(po.purchase_date)='" + monthnum.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select po.purchase_date, po.plist_id, po.tot_consume, u.lastname from purchase_order po inner join user u on po.user_user_id = u.user_id where year(po.purchase_date)='" + Year.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
        }
    }
}
