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
            loadAll();
        }

        private void loadAll()
        {
            string query = "select p.product_id, p.description, p.unit, c.name, p.tot_quantity from product p inner join category c on p.category_cat_id = c.cat_id where p.tot_quantity <= cost_quantity * 0.3;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["product_id"].Visible = false;
            dataGridView1.Columns["tot_quantity"].Visible = false;
            dataGridView1.Columns["description"].HeaderText = "Product Name";
            dataGridView1.Columns["unit"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Category";
            unit1.Enabled = false;
            status.Enabled = false;
            quan.Enabled = false;
            addquan.Enabled = false;
        }

        private void refr()
        {
            dataGridView2.DataSource = null;
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
            DataRow dr = dt.NewRow();
            dr["Product"] = prod.Text;
            dr["Unit"] = unit1.Text;
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
            unit1.Text = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();
            cur_quan.Text = dataGridView1.Rows[e.RowIndex].Cells["tot_quantity"].Value.ToString();
            unit1.Enabled = true;
            status.Enabled = true;
            quan.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prod2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            unit2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            quan2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            status2.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            addquan.Enabled = true;
        }

        private void addquan_Click(object sender, EventArgs e)
        {
            string query = "select description, tot_quantity from product where product_id='" + id.Text + "';";
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
            else if(status2.Text == "Damaged")
            {
                MessageBox.Show("Damaged items can't be added!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query1 = "UPDATE product SET tot_quantity='" + sum + "' where product_id= '" + id.Text + "' and unit='" + unit1.Text + "';";
                executeQuery(query1);
                MessageBox.Show("Adding '" + quan2.Text + "' items to inventory!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                remv();
                loadAll();
            }
        }
    }
}
