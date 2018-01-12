using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            desc.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            price.ForeColor = Color.Black;
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (desc.Text == "Description")
            {
                desc.Text = "";
            }
            if (price.Text == "")
            {
                price.Text = "Price";
            }
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (desc.Text == "")
            {
                desc.Text = "Description";
            }
            if (price.Text == "Price")
            {
                price.Text = "";
            }
           
        }

        private void num_Click(object sender, EventArgs e)
        {
            
            
        }

        private void addr_Click(object sender, EventArgs e)
        {
           
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            panel2.Visible = false; panel1.Visible = true;
        }
    }
}
