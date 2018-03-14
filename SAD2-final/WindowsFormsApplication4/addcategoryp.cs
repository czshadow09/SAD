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
    public partial class addcategoryp : Form
    {
        MySqlConnection conn;
        public Form a3;
        public addcategoryp()
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM category WHERE name='" + categ.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (String.IsNullOrEmpty(categ.Text))
            {
                MessageBox.Show("Nothing has been added.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Category already exist. Please type in a different category", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Add product?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query1 = "INSERT INTO category(name) VALUES('" + categ.Text + "');";
                        MessageBox.Show("Category added!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        executeQuery(query1);
                        this.Close();
                    }
                }
            }
        }
    }
}
