using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class signup : Form
    {
        MySqlConnection conn;
        public signup()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(email.Text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[0][9][0-9]{2}[0-9]{3}[0-9]{4}");
            string query = "SELECT username From login WHERE username='" + username.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter member = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            member.Fill(dt);
            if (String.IsNullOrEmpty(firstname.Text) ||
                String.IsNullOrEmpty(lastname.Text) ||
                String.IsNullOrEmpty(gender.Text) ||
                String.IsNullOrEmpty(contact.Text) ||
                String.IsNullOrEmpty(email.Text) ||
                String.IsNullOrEmpty(usertype.Text) ||
                String.IsNullOrEmpty(username.Text) ||
                String.IsNullOrEmpty(newp.Text) ||
                String.IsNullOrEmpty(retype.Text))
                MessageBox.Show("Please fill all the fields.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Username already exist. Please choose a different username", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!phoneNumpattern.IsMatch(contact.Text))
                {
                    MessageBox.Show("Incorrect phone number", "Phone Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!IsValid(email.Text))
                {
                    MessageBox.Show("Incorrect email address", "Email Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (newp.Text != retype.Text)
                {
                    MessageBox.Show("Password does not match", "Not matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query1 = "INSERT INTO login(username, password) values('" + username.Text + "', '" + retype.Text + "')";
                    executeQuery(query1);
                    string query2 = "INSERT INTO user(firstname, lastname, gender, contact, email, type, login_login_id) values('" + firstname.Text + "', '" + lastname.Text + "' , '" + gender.Text + "' , '" + contact.Text + "' , '" + email.Text + "' , '" + usertype.Text + "' , (select login_id from login where username= '" + username.Text + "'))";
                    executeQuery(query2);
                    MessageBox.Show("User added to the database.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void firstname_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void lastname_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void contact_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void newp_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }

        private void retype_OnValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
        }
    }
}
