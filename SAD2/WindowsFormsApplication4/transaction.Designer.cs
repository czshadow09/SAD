﻿namespace WindowsFormsApplication4
{
    partial class transaction
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaction));
            this.Se = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.avquan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sprice = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gratot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.subtot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Se
            // 
            this.Se.AccessibleDescription = "";
            this.Se.FlatAppearance.BorderSize = 0;
            this.Se.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Se.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Se.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Se.Image = ((System.Drawing.Image)(resources.GetObject("Se.Image")));
            this.Se.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Se.Location = new System.Drawing.Point(16, 281);
            this.Se.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Se.Name = "Se";
            this.Se.Size = new System.Drawing.Size(55, 52);
            this.Se.TabIndex = 62;
            this.Se.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Se.UseVisualStyleBackColor = true;
            this.Se.Click += new System.EventHandler(this.Se_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(77, 292);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(255, 32);
            this.search.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(491, 175);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 40);
            this.label2.TabIndex = 64;
            this.label2.Text = "Sales Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(164, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 96;
            this.label5.Text = "Product List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(663, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 33);
            this.label6.TabIndex = 98;
            this.label6.Text = "Order Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(523, 98);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(489, 175);
            this.dataGridView2.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.quan);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.avquan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.sprice);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 345);
            this.panel1.TabIndex = 99;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(471, 9);
            this.id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(48, 22);
            this.id.TabIndex = 115;
            // 
            // remove
            // 
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.Teal;
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove.Location = new System.Drawing.Point(216, 229);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(172, 69);
            this.remove.TabIndex = 114;
            this.remove.Text = "  Remove";
            this.remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Teal;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(395, 229);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(139, 69);
            this.add.TabIndex = 113;
            this.add.Text = "  Add";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.LightGray;
            this.amount.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(451, 151);
            this.amount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Size = new System.Drawing.Size(69, 35);
            this.amount.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(283, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 27);
            this.label9.TabIndex = 111;
            this.label9.Text = "Amount:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(155, 151);
            this.quan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(113, 34);
            this.quan.TabIndex = 110;
            this.quan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.quan_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 27);
            this.label8.TabIndex = 109;
            this.label8.Text = "Sale Qty:";
            // 
            // avquan
            // 
            this.avquan.BackColor = System.Drawing.Color.LightGray;
            this.avquan.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avquan.Location = new System.Drawing.Point(451, 111);
            this.avquan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.avquan.Name = "avquan";
            this.avquan.ReadOnly = true;
            this.avquan.Size = new System.Drawing.Size(69, 35);
            this.avquan.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(283, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 107;
            this.label7.Text = "Available Qty:";
            // 
            // sprice
            // 
            this.sprice.BackColor = System.Drawing.Color.LightGray;
            this.sprice.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprice.Location = new System.Drawing.Point(155, 106);
            this.sprice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sprice.Name = "sprice";
            this.sprice.ReadOnly = true;
            this.sprice.Size = new System.Drawing.Size(113, 35);
            this.sprice.TabIndex = 106;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.LightGray;
            this.name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(155, 64);
            this.name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(364, 35);
            this.name.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 104;
            this.label4.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 38);
            this.label1.TabIndex = 102;
            this.label1.Text = "Product Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 101;
            this.label3.Text = "Description:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.gratot);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.res);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tax);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.subtot);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(560, 336);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 345);
            this.panel2.TabIndex = 100;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightGray;
            this.textBox9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(179, 203);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(69, 35);
            this.textBox9.TabIndex = 121;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 27);
            this.label16.TabIndex = 120;
            this.label16.Text = "Payment Due:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox8.Location = new System.Drawing.Point(179, 161);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(69, 34);
            this.textBox8.TabIndex = 119;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 27);
            this.label15.TabIndex = 118;
            this.label15.Text = "Total Payment:";
            // 
            // gratot
            // 
            this.gratot.BackColor = System.Drawing.Color.LightGray;
            this.gratot.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gratot.Location = new System.Drawing.Point(179, 116);
            this.gratot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gratot.Name = "gratot";
            this.gratot.ReadOnly = true;
            this.gratot.Size = new System.Drawing.Size(239, 35);
            this.gratot.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 27);
            this.label13.TabIndex = 115;
            this.label13.Text = "Grand Total:";
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.Color.LightGray;
            this.res.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(317, 75);
            this.res.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(71, 35);
            this.res.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(264, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 27);
            this.label12.TabIndex = 117;
            this.label12.Text = "%";
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tax.Location = new System.Drawing.Point(179, 74);
            this.tax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(69, 34);
            this.tax.TabIndex = 116;
            this.tax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tax_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 27);
            this.label11.TabIndex = 115;
            this.label11.Text = "VAT-ST:";
            // 
            // subtot
            // 
            this.subtot.BackColor = System.Drawing.Color.LightGray;
            this.subtot.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtot.Location = new System.Drawing.Point(179, 28);
            this.subtot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.subtot.Name = "subtot";
            this.subtot.ReadOnly = true;
            this.subtot.Size = new System.Drawing.Size(239, 35);
            this.subtot.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 27);
            this.label10.TabIndex = 115;
            this.label10.Text = "Sub Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 38);
            this.label14.TabIndex = 102;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(822, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 46);
            this.button2.TabIndex = 115;
            this.button2.Text = "  Checkout";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // refresh
            // 
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Teal;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(43, 229);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(167, 69);
            this.refresh.TabIndex = 117;
            this.refresh.Text = "   Refresh";
            this.refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 345);
            this.panel3.TabIndex = 123;
            this.panel3.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(3, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 38);
            this.label23.TabIndex = 102;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.cancel);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(25, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 260);
            this.panel4.TabIndex = 122;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(142, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 75);
            this.button1.TabIndex = 123;
            this.button1.Text = " Add";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(319, 156);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(189, 74);
            this.cancel.TabIndex = 122;
            this.cancel.Text = "  Cancel";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(227, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 35);
            this.textBox1.TabIndex = 121;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(227, 38);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 34);
            this.textBox2.TabIndex = 119;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(24, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 27);
            this.label17.TabIndex = 120;
            this.label17.Text = "Change Due:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(24, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 27);
            this.label18.TabIndex = 118;
            this.label18.Text = "Total Payment:";
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Se);
            this.Controls.Add(this.search);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "transaction";
            this.Size = new System.Drawing.Size(1021, 682);
            this.Load += new System.EventHandler(this.transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Se;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quan;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox gratot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox subtot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox sprice;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox avquan;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button refresh;
    }
}
