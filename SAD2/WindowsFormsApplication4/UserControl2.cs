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
    public partial class UserControl2 : UserControl
    {
        MySqlConnection conn;

        public Form prevform { get; set; }

        public UserControl2()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");

        }
        public void getText(string text)
        {
            username.Text = text;
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            loadAll();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstname.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastname.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            contact.ForeColor = Color.Black;
        }

        private void gender_TextChanged(object sender, EventArgs e)
        {
            gender.ForeColor = Color.Black;
        }

        private void contact_Click(object sender, EventArgs e)
        {


           
        }

        private void gender_Click(object sender, EventArgs e)
        {

           
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            email.ForeColor = Color.Black;
        }
        
        private void loadAll()
        {
            string query = "SELECT * FROM user u inner join login l on l.login_id = u.login_login_id;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["user_id"].Visible = false;
            dataGridView1.Columns["login_login_id"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["login_id"].Visible = false;
            dataGridView1.Columns["firstname"].HeaderText = "First Name";
            dataGridView1.Columns["lastname"].HeaderText = "Last Name";
            dataGridView1.Columns["gender"].HeaderText = "Gender";
            dataGridView1.Columns["contact"].HeaderText = "Contact #";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["username"].HeaderText = "User Name";
            dataGridView1.Columns["type"].HeaderText = "User Type";
        }
        
        private void Add_Click(object sender, EventArgs e)
        {
            string query = "SELECT email From user WHERE email='" + email.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter member = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            member.Fill(dt);
            if (String.IsNullOrEmpty(firstname.Text) &&
                String.IsNullOrEmpty(lastname.Text) &&
                String.IsNullOrEmpty(gender.Text) &&
                String.IsNullOrEmpty(contact.Text) &&
                String.IsNullOrEmpty(email.Text) &&
                String.IsNullOrEmpty(usertype.Text))
                MessageBox.Show("Please fill all the fields.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.Rows.Count >= 1) MessageBox.Show("Email already exist. Please choose a different email", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    
                   
                    string query1 = "INSERT INTO user(firstname, lastname, gender, contact, email, type, login_login_id) values('" + firstname.Text + "', '" + lastname.Text + "' , '" + gender.Text + "' , '" + contact.Text + "' , '" + email.Text + "' , '" + usertype.Text + "' , (select login_id from login where username= '" + username.Text + "'))";
                    executeQuery(query1);
                }
            }

        }
       
        private int select_user_id;
        private int select_login_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                firstname.Text = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                lastname.Text = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                gender.Text = dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                contact.Text = dataGridView1.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                email.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                usertype.Text = dataGridView1.Rows[e.RowIndex].Cells["type"].Value.ToString();
                select_login_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["login_login_id"].Value.ToString());
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
