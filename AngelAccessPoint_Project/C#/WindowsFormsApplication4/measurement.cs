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
    public partial class Measurement : Form
    {
        MySqlConnection conn;
        public Form a3;
        public Measurement()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");
        }

        private void Measurement_Load(object sender, EventArgs e)
        {

        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM unit WHERE name='" + unit.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (String.IsNullOrEmpty(unit.Text))
            {
                MessageBox.Show("Nothing has been added.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Unit already exist. Please type in a different unit", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Add Unit?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query1 = "INSERT INTO unit(name) VALUES('" + unit.Text + "');";
                        MessageBox.Show("Unit added!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        executeQuery(query1);
                        this.Close();
                    }
                }
            }
        }
    }
}
