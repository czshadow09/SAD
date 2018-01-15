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
        
        public Form2()
        {
            InitializeComponent();
            Form1 f2 = new Form1();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            userControl11.BringToFront();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            userControl11.BringToFront();
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
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            userControl21.BringToFront();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            inventory1.BringToFront();
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

    }
}
