﻿namespace WindowsFormsApplication4
{
    partial class Purchasing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchasing));
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Se = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.packqty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.purchase = new System.Windows.Forms.TextBox();
            this.unit1 = new System.Windows.Forms.TextBox();
            this.usereport = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.morder = new System.Windows.Forms.Button();
            this.prod = new System.Windows.Forms.TextBox();
            this.quan2 = new System.Windows.Forms.TextBox();
            this.prod2 = new System.Windows.Forms.TextBox();
            this.unit2 = new System.Windows.Forms.TextBox();
            this.cur_quan = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.month = new System.Windows.Forms.ComboBox();
            this.ordid1 = new System.Windows.Forms.TextBox();
            this.ordid = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addquan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.purchasetotal = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(133, 4);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(75, 22);
            this.id.TabIndex = 106;
            this.id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(355, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 40);
            this.label2.TabIndex = 103;
            this.label2.Text = "Purchasing Management";
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
            this.Se.Location = new System.Drawing.Point(332, 308);
            this.Se.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Se.Name = "Se";
            this.Se.Size = new System.Drawing.Size(55, 52);
            this.Se.TabIndex = 113;
            this.Se.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Se.UseVisualStyleBackColor = true;
            this.Se.Click += new System.EventHandler(this.Se_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(71, 742);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(308, 32);
            this.search.TabIndex = 112;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(28, 111);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(238, 77);
            this.Add.TabIndex = 111;
            this.Add.Text = " Add New Item";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(114, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 33);
            this.label5.TabIndex = 108;
            this.label5.Text = "Purchase Order List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(196, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 33);
            this.label6.TabIndex = 110;
            this.label6.Text = "Item Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 122;
            this.label1.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 121;
            this.label3.Text = "Unit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(276, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 119;
            this.label7.Text = "Quantity:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(389, 14);
            this.quan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(121, 34);
            this.quan.TabIndex = 118;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.packqty);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.purchase);
            this.panel1.Controls.Add(this.unit1);
            this.panel1.Controls.Add(this.usereport);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.quan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.morder);
            this.panel1.Location = new System.Drawing.Point(705, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 325);
            this.panel1.TabIndex = 125;
            // 
            // packqty
            // 
            this.packqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packqty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.packqty.Location = new System.Drawing.Point(389, 57);
            this.packqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.packqty.Name = "packqty";
            this.packqty.Size = new System.Drawing.Size(121, 34);
            this.packqty.TabIndex = 137;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(276, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 138;
            this.label11.Text = "Pack Qty:";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Orange;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print.Location = new System.Drawing.Point(269, 192);
            this.print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(231, 54);
            this.print.TabIndex = 136;
            this.print.Text = "Print";
            this.print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchase.Location = new System.Drawing.Point(139, 59);
            this.purchase.Margin = new System.Windows.Forms.Padding(4);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(127, 30);
            this.purchase.TabIndex = 133;
            // 
            // unit1
            // 
            this.unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unit1.Location = new System.Drawing.Point(139, 17);
            this.unit1.Margin = new System.Windows.Forms.Padding(4);
            this.unit1.Name = "unit1";
            this.unit1.ReadOnly = true;
            this.unit1.Size = new System.Drawing.Size(127, 30);
            this.unit1.TabIndex = 132;
            // 
            // usereport
            // 
            this.usereport.BackColor = System.Drawing.Color.Silver;
            this.usereport.FlatAppearance.BorderSize = 0;
            this.usereport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usereport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usereport.ForeColor = System.Drawing.Color.White;
            this.usereport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usereport.Location = new System.Drawing.Point(28, 192);
            this.usereport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usereport.Name = "usereport";
            this.usereport.Size = new System.Drawing.Size(238, 54);
            this.usereport.TabIndex = 135;
            this.usereport.Text = "Purchase Report";
            this.usereport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usereport.UseVisualStyleBackColor = false;
            this.usereport.Click += new System.EventHandler(this.usereport_Click_1);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(269, 111);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(231, 77);
            this.update.TabIndex = 116;
            this.update.Text = " Purchase Item";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // morder
            // 
            this.morder.BackColor = System.Drawing.Color.IndianRed;
            this.morder.FlatAppearance.BorderSize = 0;
            this.morder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.morder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morder.ForeColor = System.Drawing.Color.White;
            this.morder.Image = ((System.Drawing.Image)(resources.GetObject("morder.Image")));
            this.morder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.morder.Location = new System.Drawing.Point(109, 250);
            this.morder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.morder.Name = "morder";
            this.morder.Size = new System.Drawing.Size(319, 54);
            this.morder.TabIndex = 139;
            this.morder.Text = "Create Order";
            this.morder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.morder.UseVisualStyleBackColor = false;
            this.morder.Click += new System.EventHandler(this.morder_Click);
            // 
            // prod
            // 
            this.prod.Location = new System.Drawing.Point(175, 4);
            this.prod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(100, 22);
            this.prod.TabIndex = 126;
            this.prod.Visible = false;
            // 
            // quan2
            // 
            this.quan2.Location = new System.Drawing.Point(125, 4);
            this.quan2.Margin = new System.Windows.Forms.Padding(4);
            this.quan2.Name = "quan2";
            this.quan2.Size = new System.Drawing.Size(59, 22);
            this.quan2.TabIndex = 128;
            this.quan2.Visible = false;
            // 
            // prod2
            // 
            this.prod2.Location = new System.Drawing.Point(191, 4);
            this.prod2.Margin = new System.Windows.Forms.Padding(4);
            this.prod2.Name = "prod2";
            this.prod2.Size = new System.Drawing.Size(59, 22);
            this.prod2.TabIndex = 129;
            this.prod2.Visible = false;
            // 
            // unit2
            // 
            this.unit2.Location = new System.Drawing.Point(149, 4);
            this.unit2.Margin = new System.Windows.Forms.Padding(4);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(59, 22);
            this.unit2.TabIndex = 130;
            this.unit2.Visible = false;
            // 
            // cur_quan
            // 
            this.cur_quan.Location = new System.Drawing.Point(175, 4);
            this.cur_quan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cur_quan.Name = "cur_quan";
            this.cur_quan.Size = new System.Drawing.Size(68, 22);
            this.cur_quan.TabIndex = 131;
            this.cur_quan.Visible = false;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(125, 4);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(59, 22);
            this.price.TabIndex = 132;
            this.price.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 378);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1387, 43);
            this.bunifuSeparator2.TabIndex = 145;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(457, 245);
            this.dataGridView1.TabIndex = 155;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(71, 490);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(556, 219);
            this.dataGridView2.TabIndex = 156;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.month);
            this.panel2.Controls.Add(this.ordid1);
            this.panel2.Controls.Add(this.ordid);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 805);
            this.panel2.TabIndex = 159;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(159, 120);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(441, 463);
            this.dataGridView3.TabIndex = 162;
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.SystemColors.ControlLight;
            this.month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.month.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "January",
            "February",
            "March ",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month.Location = new System.Drawing.Point(246, 648);
            this.month.Margin = new System.Windows.Forms.Padding(4);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(311, 35);
            this.month.TabIndex = 138;
            // 
            // ordid1
            // 
            this.ordid1.Location = new System.Drawing.Point(780, 19);
            this.ordid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordid1.Name = "ordid1";
            this.ordid1.Size = new System.Drawing.Size(68, 22);
            this.ordid1.TabIndex = 161;
            this.ordid1.Visible = false;
            // 
            // ordid
            // 
            this.ordid.Location = new System.Drawing.Point(786, 19);
            this.ordid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordid.Name = "ordid";
            this.ordid.Size = new System.Drawing.Size(68, 22);
            this.ordid.TabIndex = 160;
            this.ordid.Visible = false;
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(19, 11);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(67, 70);
            this.Close.TabIndex = 132;
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.dataGridView4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(92, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 667);
            this.panel3.TabIndex = 164;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(678, 62);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(445, 463);
            this.dataGridView4.TabIndex = 163;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(803, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 35);
            this.label12.TabIndex = 136;
            this.label12.Text = "Item Purchased";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.comboBox1.Location = new System.Drawing.Point(751, 590);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 35);
            this.comboBox1.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(57, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 140;
            this.label9.Text = "Month:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(145, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 35);
            this.label8.TabIndex = 137;
            this.label8.Text = "Purchased Transaction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(667, 596);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 141;
            this.label10.Text = "Year:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(71, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 324);
            this.panel4.TabIndex = 160;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Se);
            this.panel5.Location = new System.Drawing.Point(53, 422);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(587, 361);
            this.panel5.TabIndex = 161;
            // 
            // addquan
            // 
            this.addquan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addquan.FlatAppearance.BorderSize = 0;
            this.addquan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addquan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addquan.ForeColor = System.Drawing.Color.White;
            this.addquan.Image = ((System.Drawing.Image)(resources.GetObject("addquan.Image")));
            this.addquan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addquan.Location = new System.Drawing.Point(244, 190);
            this.addquan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addquan.Name = "addquan";
            this.addquan.Size = new System.Drawing.Size(256, 65);
            this.addquan.TabIndex = 125;
            this.addquan.Text = "Add to Inventory";
            this.addquan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addquan.UseVisualStyleBackColor = false;
            this.addquan.Click += new System.EventHandler(this.addquan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(86, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 134;
            this.label4.Text = "Total Price:";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(75, 189);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(163, 65);
            this.refresh.TabIndex = 144;
            this.refresh.Text = "Refresh";
            this.refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // purchasetotal
            // 
            this.purchasetotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasetotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchasetotal.Location = new System.Drawing.Point(273, 102);
            this.purchasetotal.Margin = new System.Windows.Forms.Padding(4);
            this.purchasetotal.Name = "purchasetotal";
            this.purchasetotal.ReadOnly = true;
            this.purchasetotal.Size = new System.Drawing.Size(227, 32);
            this.purchasetotal.TabIndex = 133;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel6.Controls.Add(this.purchasetotal);
            this.panel6.Controls.Add(this.refresh);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.addquan);
            this.panel6.Location = new System.Drawing.Point(705, 422);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(544, 360);
            this.panel6.TabIndex = 162;
            // 
            // Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.cur_quan);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.prod2);
            this.Controls.Add(this.quan2);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.search);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchasing";
            this.Size = new System.Drawing.Size(1302, 805);
            this.Load += new System.EventHandler(this.Purchasing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Se;
        public System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox prod;
        public System.Windows.Forms.TextBox quan2;
        public System.Windows.Forms.TextBox prod2;
        public System.Windows.Forms.TextBox unit2;
        private System.Windows.Forms.TextBox cur_quan;
        public System.Windows.Forms.TextBox unit1;
        public System.Windows.Forms.TextBox price;
        public System.Windows.Forms.TextBox purchase;
        private System.Windows.Forms.Button usereport;
        private System.Windows.Forms.Button update;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Close;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.TextBox packqty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button morder;
        private System.Windows.Forms.TextBox ordid;
        private System.Windows.Forms.TextBox ordid1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button addquan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refresh;
        public System.Windows.Forms.TextBox purchasetotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
    }
}