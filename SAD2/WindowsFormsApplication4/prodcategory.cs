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
    public partial class prodcategory : UserControl
    {
        MySqlConnection conn;
        public prodcategory()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prodcategory_Load(object sender, EventArgs e)
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
        }
        private int select_user_id;

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "SELECT product_id From product WHERE description='" + desc.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter user = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            user.Fill(dt);
            if (!String.IsNullOrEmpty(desc.Text) && !String.IsNullOrEmpty(categ.Text))
            {
                if (dt.Rows.Count >= 1) MessageBox.Show("Product already exist. Please choose a different product", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string query1 = "INSERT INTO product(description, category, purchase_price, store_price, tot_quantity) VALUES('" + desc.Text + "', '" + categ.Text + "', '" + Pprice.Text + "', '" + Sprice.Text + "', '" + quan.Text + "');";
                    MessageBox.Show("Product added!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    executeQuery(query1);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string query = "";
            string query2 = "SELECT description FROM product WHERE description='" + desc.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query2, conn);
            MySqlDataAdapter user = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            user.Fill(dt);
            if (String.IsNullOrEmpty(desc.Text) && String.IsNullOrEmpty(categ.Text) && String.IsNullOrEmpty(Pprice.Text) && String.IsNullOrEmpty(Sprice.Text))
                MessageBox.Show("Please choose a product by clicking one.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                query += " UPDATE product SET description='" + desc.Text + "', category='" + categ.Text + "', purchase_price='" + Pprice.Text + "', store_price='" + Sprice.Text + "', tot_quantity='" + quan.Text + "' WHERE product_id='" + id.Text + "'; ";
                MessageBox.Show("Product updated!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            executeQuery(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
                desc.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
                categ.Text = dataGridView1.Rows[e.RowIndex].Cells["category"].Value.ToString();
                Pprice.Text = dataGridView1.Rows[e.RowIndex].Cells["purchase_price"].Value.ToString();
                Sprice.Text = dataGridView1.Rows[e.RowIndex].Cells["store_price"].Value.ToString();
                quan.Text = dataGridView1.Rows[e.RowIndex].Cells["tot_quantity"].Value.ToString();
                id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addcategoryp a = new addcategoryp();
            a.Show();
        }
    }
}
