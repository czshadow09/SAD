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
            
        }

        private void prodcategory_Load(object sender, EventArgs e)
        {
            
            loadAll2();
        }


        private void loadAll2()
        {
            string query = "select name from category;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                categ.Items.Add(dt.Rows[x][0].ToString());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "SELECT product_id From product WHERE description='" + desc.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter user = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            user.Fill(dt);
            if (String.IsNullOrEmpty(desc.Text) || String.IsNullOrEmpty(categ.Text) || String.IsNullOrEmpty(Pprice.Text) || String.IsNullOrEmpty(Sprice.Text) || String.IsNullOrEmpty(quan.Text))
            {
                MessageBox.Show("Please fill up all the fields.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dt.Rows.Count >= 1) MessageBox.Show("Product already exist. Please choose a different product", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string query1 = "INSERT INTO product(description, purchase_price, store_price, stock_in, stock_out, tot_quantity, category_cat_id) VALUES('" + desc.Text + "', '" + Pprice.Text + "', '" + Sprice.Text + "', 0 , 0 , '" + quan.Text + "', (SELECT cat_id FROM category WHERE name='" + categ.Text + "'));";
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
            if (String.IsNullOrEmpty(id.Text) || String.IsNullOrEmpty(desc.Text) || String.IsNullOrEmpty(categ.Text) || String.IsNullOrEmpty(Pprice.Text) || String.IsNullOrEmpty(Sprice.Text))
                MessageBox.Show("Please choose a product by clicking one.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Product already exist. Please choose a different product", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query += " UPDATE product SET description='" + desc.Text +  "', purchase_price='" + Pprice.Text + "', store_price='" + Sprice.Text + "', tot_quantity='" + quan.Text + "', category_cat_id = (SELECT cat_id FROM category WHERE name='" + categ.Text + "') WHERE product_id='" + id.Text + "'; ";
                    MessageBox.Show("Product updated!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    executeQuery(query);
                }
            }
        }



        private void AddC_Cick(object sender, EventArgs e)
        {
            addcategoryp a = new addcategoryp();
            a.Show();
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
