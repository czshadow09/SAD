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
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Se = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unit1 = new System.Windows.Forms.TextBox();
            this.prod = new System.Windows.Forms.TextBox();
            this.addquan = new System.Windows.Forms.Button();
            this.quan2 = new System.Windows.Forms.TextBox();
            this.prod2 = new System.Windows.Forms.TextBox();
            this.unit2 = new System.Windows.Forms.TextBox();
            this.cur_quan = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.purchasetotal = new System.Windows.Forms.TextBox();
            this.purchase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(100, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(57, 20);
            this.id.TabIndex = 106;
            this.id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(266, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 33);
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
            this.Se.Location = new System.Drawing.Point(716, 545);
            this.Se.Margin = new System.Windows.Forms.Padding(2);
            this.Se.Name = "Se";
            this.Se.Size = new System.Drawing.Size(41, 42);
            this.Se.TabIndex = 113;
            this.Se.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Se.UseVisualStyleBackColor = true;
            this.Se.Click += new System.EventHandler(this.Se_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(480, 555);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(232, 27);
            this.search.TabIndex = 112;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Teal;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(10, 147);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(148, 68);
            this.Add.TabIndex = 111;
            this.Add.Text = " Add New Item";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Teal;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(181, 149);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(136, 68);
            this.update.TabIndex = 116;
            this.update.Text = " Purchase Item";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(89, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 26);
            this.label5.TabIndex = 108;
            this.label5.Text = "Purchase Order List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(326, 239);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(429, 77);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(323, 312);
            this.dataGridView2.TabIndex = 107;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(534, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 110;
            this.label6.Text = "Item Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 122;
            this.label1.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 121;
            this.label3.Text = "Unit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(30, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 119;
            this.label7.Text = "Quantity:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(116, 98);
            this.quan.Margin = new System.Windows.Forms.Padding(2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(69, 28);
            this.quan.TabIndex = 118;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.purchase);
            this.panel1.Controls.Add(this.unit1);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.quan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 329);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 219);
            this.panel1.TabIndex = 125;
            // 
            // unit1
            // 
            this.unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unit1.Location = new System.Drawing.Point(116, 24);
            this.unit1.Name = "unit1";
            this.unit1.ReadOnly = true;
            this.unit1.Size = new System.Drawing.Size(171, 26);
            this.unit1.TabIndex = 132;
            // 
            // prod
            // 
            this.prod.Location = new System.Drawing.Point(480, 586);
            this.prod.Margin = new System.Windows.Forms.Padding(2);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(76, 20);
            this.prod.TabIndex = 126;
            this.prod.Visible = false;
            // 
            // addquan
            // 
            this.addquan.FlatAppearance.BorderSize = 0;
            this.addquan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addquan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addquan.ForeColor = System.Drawing.Color.Teal;
            this.addquan.Image = ((System.Drawing.Image)(resources.GetObject("addquan.Image")));
            this.addquan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addquan.Location = new System.Drawing.Point(628, 399);
            this.addquan.Margin = new System.Windows.Forms.Padding(2);
            this.addquan.Name = "addquan";
            this.addquan.Size = new System.Drawing.Size(124, 68);
            this.addquan.TabIndex = 125;
            this.addquan.Text = "Add to Inventory";
            this.addquan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addquan.UseVisualStyleBackColor = true;
            this.addquan.Click += new System.EventHandler(this.addquan_Click);
            // 
            // quan2
            // 
            this.quan2.Location = new System.Drawing.Point(610, 15);
            this.quan2.Name = "quan2";
            this.quan2.Size = new System.Drawing.Size(45, 20);
            this.quan2.TabIndex = 128;
            this.quan2.Visible = false;
            // 
            // prod2
            // 
            this.prod2.Location = new System.Drawing.Point(682, 15);
            this.prod2.Name = "prod2";
            this.prod2.Size = new System.Drawing.Size(45, 20);
            this.prod2.TabIndex = 129;
            this.prod2.Visible = false;
            // 
            // unit2
            // 
            this.unit2.Location = new System.Drawing.Point(538, 18);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(45, 20);
            this.unit2.TabIndex = 130;
            this.unit2.Visible = false;
            // 
            // cur_quan
            // 
            this.cur_quan.Location = new System.Drawing.Point(193, 15);
            this.cur_quan.Margin = new System.Windows.Forms.Padding(2);
            this.cur_quan.Name = "cur_quan";
            this.cur_quan.Size = new System.Drawing.Size(52, 20);
            this.cur_quan.TabIndex = 131;
            this.cur_quan.Visible = false;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(682, 43);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(45, 20);
            this.price.TabIndex = 132;
            this.price.Visible = false;
            // 
            // refresh
            // 
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Teal;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(480, 405);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 56);
            this.refresh.TabIndex = 133;
            this.refresh.Text = "   Refresh";
            this.refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(425, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 134;
            this.label4.Text = "Total Price";
            // 
            // purchasetotal
            // 
            this.purchasetotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasetotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchasetotal.Location = new System.Drawing.Point(541, 476);
            this.purchasetotal.Name = "purchasetotal";
            this.purchasetotal.ReadOnly = true;
            this.purchasetotal.Size = new System.Drawing.Size(171, 27);
            this.purchasetotal.TabIndex = 133;
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchase.Location = new System.Drawing.Point(116, 62);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(171, 26);
            this.purchase.TabIndex = 133;
            // 
            // Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.purchasetotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refresh);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Purchasing";
            this.Size = new System.Drawing.Size(766, 614);
            this.Load += new System.EventHandler(this.Purchasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Se;
        public System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button refresh;
        public System.Windows.Forms.TextBox purchase;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox purchasetotal;
    }
}
