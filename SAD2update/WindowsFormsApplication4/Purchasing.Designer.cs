namespace WindowsFormsApplication4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.purchase = new System.Windows.Forms.TextBox();
            this.unit1 = new System.Windows.Forms.TextBox();
            this.usereport = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.prod = new System.Windows.Forms.TextBox();
            this.addquan = new System.Windows.Forms.Button();
            this.quan2 = new System.Windows.Forms.TextBox();
            this.prod2 = new System.Windows.Forms.TextBox();
            this.unit2 = new System.Windows.Forms.TextBox();
            this.cur_quan = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.purchasetotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Close = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridView2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.Se.Location = new System.Drawing.Point(922, 594);
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
            this.search.Location = new System.Drawing.Point(614, 606);
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
            this.Add.Location = new System.Drawing.Point(82, 102);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(197, 74);
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
            this.label5.Location = new System.Drawing.Point(119, 53);
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
            this.label6.Location = new System.Drawing.Point(204, 391);
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
            this.label3.Location = new System.Drawing.Point(23, 19);
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
            this.label7.Location = new System.Drawing.Point(291, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 119;
            this.label7.Text = "Quantity:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(406, 15);
            this.quan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(91, 34);
            this.quan.TabIndex = 118;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.purchase);
            this.panel1.Controls.Add(this.unit1);
            this.panel1.Controls.Add(this.usereport);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.quan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(460, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 249);
            this.panel1.TabIndex = 125;
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchase.Location = new System.Drawing.Point(138, 59);
            this.purchase.Margin = new System.Windows.Forms.Padding(4);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(142, 30);
            this.purchase.TabIndex = 133;
            // 
            // unit1
            // 
            this.unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unit1.Location = new System.Drawing.Point(138, 17);
            this.unit1.Margin = new System.Windows.Forms.Padding(4);
            this.unit1.Name = "unit1";
            this.unit1.ReadOnly = true;
            this.unit1.Size = new System.Drawing.Size(142, 30);
            this.unit1.TabIndex = 132;
            // 
            // usereport
            // 
            this.usereport.FlatAppearance.BorderSize = 0;
            this.usereport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usereport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usereport.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.usereport.Image = ((System.Drawing.Image)(resources.GetObject("usereport.Image")));
            this.usereport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usereport.Location = new System.Drawing.Point(154, 185);
            this.usereport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usereport.Name = "usereport";
            this.usereport.Size = new System.Drawing.Size(237, 45);
            this.usereport.TabIndex = 135;
            this.usereport.Text = "Purchase Report";
            this.usereport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usereport.UseVisualStyleBackColor = true;
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
            this.update.Location = new System.Drawing.Point(285, 102);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(163, 74);
            this.update.TabIndex = 116;
            this.update.Text = " Purchase Item";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(166, 213);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(225, 43);
            this.bunifuSeparator1.TabIndex = 136;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // prod
            // 
            this.prod.Location = new System.Drawing.Point(640, 721);
            this.prod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(100, 22);
            this.prod.TabIndex = 126;
            this.prod.Visible = false;
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
            this.addquan.Location = new System.Drawing.Point(776, 525);
            this.addquan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addquan.Name = "addquan";
            this.addquan.Size = new System.Drawing.Size(170, 65);
            this.addquan.TabIndex = 125;
            this.addquan.Text = "Add to Inventory";
            this.addquan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addquan.UseVisualStyleBackColor = false;
            this.addquan.Click += new System.EventHandler(this.addquan_Click);
            // 
            // quan2
            // 
            this.quan2.Location = new System.Drawing.Point(43, 32);
            this.quan2.Margin = new System.Windows.Forms.Padding(4);
            this.quan2.Name = "quan2";
            this.quan2.Size = new System.Drawing.Size(59, 22);
            this.quan2.TabIndex = 128;
            this.quan2.Visible = false;
            // 
            // prod2
            // 
            this.prod2.Location = new System.Drawing.Point(216, 32);
            this.prod2.Margin = new System.Windows.Forms.Padding(4);
            this.prod2.Name = "prod2";
            this.prod2.Size = new System.Drawing.Size(59, 22);
            this.prod2.TabIndex = 129;
            this.prod2.Visible = false;
            // 
            // unit2
            // 
            this.unit2.Location = new System.Drawing.Point(149, 27);
            this.unit2.Margin = new System.Windows.Forms.Padding(4);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(59, 22);
            this.unit2.TabIndex = 130;
            this.unit2.Visible = false;
            // 
            // cur_quan
            // 
            this.cur_quan.Location = new System.Drawing.Point(257, 18);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 134;
            this.label4.Text = "Total Price:";
            // 
            // purchasetotal
            // 
            this.purchasetotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasetotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchasetotal.Location = new System.Drawing.Point(750, 435);
            this.purchasetotal.Margin = new System.Windows.Forms.Padding(4);
            this.purchasetotal.Name = "purchasetotal";
            this.purchasetotal.ReadOnly = true;
            this.purchasetotal.Size = new System.Drawing.Size(227, 32);
            this.purchasetotal.TabIndex = 133;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(542, 594);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 752);
            this.panel2.TabIndex = 134;
            this.panel2.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.DoubleBuffered = true;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView3.HeaderForeColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView3.Location = new System.Drawing.Point(158, 194);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(697, 410);
            this.dataGridView3.TabIndex = 152;
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(15, 11);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(54, 62);
            this.Close.TabIndex = 132;
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(390, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 37);
            this.label8.TabIndex = 53;
            this.label8.Text = "Purchase History";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(607, 525);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(163, 65);
            this.refresh.TabIndex = 144;
            this.refresh.Text = "Refresh";
            this.refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 358);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1064, 43);
            this.bunifuSeparator2.TabIndex = 145;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(80, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 249);
            this.dataGridView1.TabIndex = 153;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DoubleBuffered = true;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView2.HeaderForeColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView2.Location = new System.Drawing.Point(33, 437);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(556, 218);
            this.dataGridView2.TabIndex = 154;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.purchasetotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.cur_quan);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.prod2);
            this.Controls.Add(this.quan2);
            this.Controls.Add(this.addquan);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.Se);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchasing";
            this.Size = new System.Drawing.Size(1021, 731);
            this.Load += new System.EventHandler(this.Purchasing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button addquan;
        public System.Windows.Forms.TextBox quan2;
        public System.Windows.Forms.TextBox prod2;
        public System.Windows.Forms.TextBox unit2;
        private System.Windows.Forms.TextBox cur_quan;
        public System.Windows.Forms.TextBox unit1;
        public System.Windows.Forms.TextBox price;
        public System.Windows.Forms.TextBox purchase;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox purchasetotal;
        private System.Windows.Forms.Button usereport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button refresh;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView2;
    }
}
