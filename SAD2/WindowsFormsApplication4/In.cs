using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class In : Form
    {
        MySqlConnection conn;
        public In()
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "select stock_in from product where description='" + name.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int input = Int32.Parse(quan.Text);
            int db = Int32.Parse(dt.Rows[0][0].ToString());
            int sum = input + db;
            if (String.IsNullOrEmpty(quan.Text))
            {
                MessageBox.Show("Please fill up the field.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string query1 = "UPDATE product SET stock_in='" + sum + "' where description= '" + name.Text + "';";
                MessageBox.Show("Stocked in '" + quan.Text + "' items!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                executeQuery(query1);
                this.Close();
            }
        }

        private void In_Load(object sender, EventArgs e)
        {
            string query = "select description from product;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                name.Items.Add(dt.Rows[x][0].ToString());
            }
        }
    }
}
