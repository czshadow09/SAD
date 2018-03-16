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
    public partial class Out : Form
    {
        MySqlConnection conn;
        public UserControl a3;
        public bool b = false;
        public Out()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
        }

        private void Out_Load(object sender, EventArgs e)
        {
            string query = "select description from product;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            string query = "select stock_in from product where product_id='" + id.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int input = Int32.Parse(quan.Text);
            int s_in = Int32.Parse(dt.Rows[0][0].ToString());
            int dif = (s_in - input);
            if (String.IsNullOrEmpty(quan.Text))
            {
                MessageBox.Show("Please fill up the field.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (s_in < 0)
            {
                MessageBox.Show("Insufficient items.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Stock items?", "Confirm", MessageBoxButtons.YesNo); if (dialogResult == DialogResult.Yes)
                {
                    if (dif < 0)
                    {
                        MessageBox.Show("Insufficient stocked in items.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string query1 = "UPDATE product SET stock_in='" + dif + "' where product_id= '" + id.Text + "';";
                        MessageBox.Show("Stocked out '" + input + "' items!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (s_in <= 30)
                        {
                            MessageBox.Show("Item needs to be purchased", "Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        b = true;
                        executeQuery(query1);
                        this.Close();
                        inventory i = new inventory();
                        i.loadAll2();
                        this.DialogResult = DialogResult.Yes;
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
