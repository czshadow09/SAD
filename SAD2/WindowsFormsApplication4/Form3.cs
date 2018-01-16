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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        public Form previousform;
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string query = "SELECT * From login WHERE username='" + user.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter member = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            member.Fill(dt);
            if (String.IsNullOrEmpty(user.Text) &&
                String.IsNullOrEmpty(newp.Text) &&
                String.IsNullOrEmpty(retype.Text))
                MessageBox.Show("Please fill all the fields.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Username already exist. Please choose a different username.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(newp.Text != retype.Text)
                {
                    MessageBox.Show("Password does not match!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string u = dt.Rows[0][0].ToString();
                    UserControl2 ui2 = new UserControl2();
                    ui2.getText(u);
                    string query1 = "INSERT INTO login(username, password) values('" + user.Text + "', '" + retype.Text + "')";
                    executeQuery(query1);
                    ui2.prevform = this;
                    this.Hide();
                    previousform.Show();
                }
            }
        }
    }
}
