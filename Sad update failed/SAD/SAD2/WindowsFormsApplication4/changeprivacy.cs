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
    public partial class changeprivacy : UserControl
    {
        MySqlConnection conn;
        public changeprivacy()
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

        private void update_Click(object sender, EventArgs e)
        {
            string npass = newp.Text;
            string rpass = retype.Text;
            string query = "";
            string query1 = "SELECT * FROM login";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query1, conn);
            MySqlDataAdapter member = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            member.Fill(dt);
            if (String.IsNullOrEmpty(old.Text) &&
                String.IsNullOrEmpty(newp.Text) &&
                String.IsNullOrEmpty(retype.Text))
            {
                MessageBox.Show("Please fill all what is required.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (old.Text != dt.Rows[0][2].ToString())
            {
                MessageBox.Show("Password is incorrect.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rpass == npass)
                {
                    query += "UPDATE login SET password='" + rpass + "' WHERE password='" + old.Text + "'; ";
                    MessageBox.Show("Password successfuly changed.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    executeQuery(query);
                }
                else
                {
                    MessageBox.Show("Password does not match!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
