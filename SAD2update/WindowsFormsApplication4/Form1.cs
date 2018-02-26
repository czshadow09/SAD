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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1 previousform;
        public static string user = "";
        public static string id = "";
        public Form1()
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnuser_TextChanged(object sender, EventArgs e)
        {
            btnuser.ForeColor = Color.Black;
            this.AcceptButton = btnok;
        }

        private void btnpass_TextChanged(object sender, EventArgs e)
        {
            btnpass.ForeColor = Color.Black;
            this.AcceptButton = btnok;
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            if (btnuser.Text == "username")
            {
                btnuser.Text = "";
            }
            if (btnpass.Text == "")
            {
                btnpass.Text = "****";
            }
        }

        private void btnpass_Click(object sender, EventArgs e)
        {
            if (btnpass.Text == "****")
            {
                btnpass.Text = "";
            }
            if (btnuser.Text == "")
            {
                btnuser.Text = "username";
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            user = btnuser.Text;
            String pass = btnpass.Text;
            String query = "SELECT u.user_id, u.firstname, u.lastname, u.type, u.attend_date, u.status, l.username, l.password FROM login l inner join user u on l.login_id = u.login_login_id" + " WHERE username = '" + user + "' AND password = '" + pass + "'";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            String fn = dt.Rows[0][1].ToString();
            String ln = dt.Rows[0][2].ToString();

            if (dt.Rows.Count == 1)
            {
                Form2 f = new Form2();
                f.usern.Text = user;
                user = dt.Rows[0][2].ToString() + " "  + dt.Rows[0][1].ToString();
                id = dt.Rows[0][0].ToString();
                string dat = dt.Rows[0][4].ToString();
                MessageBox.Show("Welcome " + user);
                this.Hide();
                f.Show();
                f.previousform = this;
                if(date.Text != dat)
                {
                    string att = "UPDATE user SET attend_date='" + date.Text + "', status = 'Present' WHERE firstname = '" + fn + "' and lastname = '" + ln + "';";
                    executeQuery(att);
                }
            }
            else MessageBox.Show("Wrong username or password", "Please type again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MM/yyy, HH:mm");
        }
    }
}
