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
    
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        public Form previousform;
        public static string pass;
        
        public Form2()
        {
            InitializeComponent();
            Form1 f2 = new Form1();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
            sidepanel.Height = home.Height;
            sidepanel.Top = home.Top;
            hhh1.BringToFront();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String query = "SELECT u.type FROM user u inner join login l ON u.login_login_id = l.login_id WHERE l.username='" + usern.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            type.Text = dt.Rows[0][0].ToString();
            loginIn.Text = "Login as:" + type.Text;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?",
          "Log Out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Form1 a = new Form1();
                a.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            purchasing1.BringToFront();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;

            changeprivacy1.BringToFront();
        }

        private void changeprivacy1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "SELECT type FROM user WHERE type='" + type.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (type.Text == "Admin")
            {
                sidepanel.Height = button4.Height;
                sidepanel.Top = button4.Top;
                userControl21.BringToFront();
            }
            else
            {
                userControl21.Enabled = false;
            }
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            transaction1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "SELECT type FROM user WHERE type='" + type.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if(type.Text == "Admin")
            {
                sidepanel.Height = button2.Height;
                sidepanel.Top = button2.Top;
                inventory1.BringToFront();
            }
            else
            {
                inventory1.Enabled = false;
            }
            pass = usern.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeprivacy1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void purchasing1_Load(object sender, EventArgs e)
        {

        }
    }
}
