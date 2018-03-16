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
    public partial class UserReport : Form
    {
        MySqlConnection conn;
        public UserReport()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
        }
        public void loadAll()
        {
            string query = "select ur.attend_date, u.firstname, u.lastname, u.type, ur.status from user u INNER JOIN user_report ur ON u.user_id = ur.user_user_id where status = 'Present'";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["attend_date"].HeaderText = "Date";
            dataGridView1.Columns["lastname"].HeaderText = "Last Name";
            dataGridView1.Columns["firstname"].HeaderText = "First Name";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["status"].HeaderText = "Status";
        }
        private void UserReport_Load(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
