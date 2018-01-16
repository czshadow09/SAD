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
    public partial class UserControl1 : UserControl
    {
        MySqlConnection conn;
        public UserControl1()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            desc.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            price.ForeColor = Color.Black;
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (desc.Text == "Description")
            {
                desc.Text = "";
            }
            if (price.Text == "")
            {
                price.Text = "Price";
            }
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (desc.Text == "")
            {
                desc.Text = "Description";
            }
            if (price.Text == "Price")
            {
                price.Text = "";
            }
           
        }

        private void num_Click(object sender, EventArgs e)
        {
            
            
        }

        private void addr_Click(object sender, EventArgs e)
        {
           
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            panel2.Visible = false; panel1.Visible = true;
        }
        private void loadAll()
        {
            string query = "select product_id, description, store_price from product;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["product_id"].Visible = false;
            dataGridView2.Columns["description"].HeaderText = "Product Name";
            dataGridView2.Columns["store_price"].HeaderText = "Price";
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
            if (!String.IsNullOrEmpty(desc.Text) && !String.IsNullOrEmpty(price.Text))
            {
                if (dt.Rows.Count >= 1) MessageBox.Show("Product already exist. Please choose a different product", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string query1 = "INSERT INTO product(description, store_price) VALUES('" + desc.Text + "', '" + price.Text + "');";
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
            if (String.IsNullOrEmpty(desc.Text) && String.IsNullOrEmpty(price.Text))
                MessageBox.Show("Please choose a product by clicking one.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                query += " UPDATE product SET description='" + desc.Text + "', store_price='" + price.Text + "' WHERE product_id='" + id.Text + "'; ";
                MessageBox.Show("Product updated!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            executeQuery(query);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString());
                desc.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
                id.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            }
        }
    }
}
