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
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }
        public void loadAll()
        {
            string query = "select u.firstname, u.lastname, u.type, ur.attend_date, ur.present, ur.absent from user u inner join user_report ur on u.user_id = ur.user_user_id";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["lastname"].HeaderText = "Last Name";
            dataGridView1.Columns["firstname"].HeaderText = "First Name";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["attend_date"].HeaderText = "Date";
            dataGridView1.Columns["present"].HeaderText = "Status";
            dataGridView1.Columns["absent"].HeaderText = "Status";
        }
        private void UserReport_Load(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
