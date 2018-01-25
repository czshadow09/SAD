namespace WindowsFormsApplication4
{
    partial class inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            this.view = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.entry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.Se = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.Silver;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.Black;
            this.view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view.Location = new System.Drawing.Point(363, 480);
            this.view.Margin = new System.Windows.Forms.Padding(2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(110, 36);
            this.view.TabIndex = 63;
            this.view.Text = "View All";
            this.view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.Color.Silver;
            this.Out.FlatAppearance.BorderSize = 0;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.ForeColor = System.Drawing.Color.Black;
            this.Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Out.Location = new System.Drawing.Point(671, 43);
            this.Out.Margin = new System.Windows.Forms.Padding(2);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(62, 36);
            this.Out.TabIndex = 68;
            this.Out.Text = "Out";
            this.Out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // In
            // 
            this.In.BackColor = System.Drawing.Color.Silver;
            this.In.FlatAppearance.BorderSize = 0;
            this.In.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.In.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.In.ForeColor = System.Drawing.Color.Black;
            this.In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.In.Location = new System.Drawing.Point(594, 43);
            this.In.Margin = new System.Windows.Forms.Padding(2);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(60, 36);
            this.In.TabIndex = 67;
            this.In.Text = "In";
            this.In.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.In.UseVisualStyleBackColor = false;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // entry
            // 
            this.entry.BackColor = System.Drawing.Color.Silver;
            this.entry.FlatAppearance.BorderSize = 0;
            this.entry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry.ForeColor = System.Drawing.Color.Black;
            this.entry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entry.Location = new System.Drawing.Point(310, 43);
            this.entry.Margin = new System.Windows.Forms.Padding(2);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(122, 36);
            this.entry.TabIndex = 66;
            this.entry.Text = "New Entry";
            this.entry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.entry.UseVisualStyleBackColor = false;
            this.entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 22);
            this.label3.TabIndex = 65;
            this.label3.Text = "Stock In and Out Record";
            // 
            // categ
            // 
            this.categ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(143, 486);
            this.categ.Margin = new System.Windows.Forms.Padding(2);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(192, 28);
            this.categ.TabIndex = 62;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Category:";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(501, 486);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(186, 27);
            this.search.TabIndex = 59;
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
            this.Se.Location = new System.Drawing.Point(692, 476);
            this.Se.Margin = new System.Windows.Forms.Padding(2);
            this.Se.Name = "Se";
            this.Se.Size = new System.Drawing.Size(41, 42);
            this.Se.TabIndex = 60;
            this.Se.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Se.UseVisualStyleBackColor = true;
            this.Se.Click += new System.EventHandler(this.Se_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(232, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 33);
            this.label2.TabIndex = 53;
            this.label2.Text = "Inventory Management System";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 98);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(711, 349);
            this.dataGridView2.TabIndex = 71;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(594, 13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(57, 20);
            this.id.TabIndex = 72;
            this.id.Visible = false;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.In);
            this.Controls.Add(this.entry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Se);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inventory";
            this.Size = new System.Drawing.Size(766, 554);
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button entry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button Se;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox id;
    }
}
