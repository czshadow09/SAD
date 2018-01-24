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
            this.Save = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.entry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.view.Location = new System.Drawing.Point(484, 591);
            this.view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(147, 44);
            this.view.TabIndex = 63;
            this.view.Text = "View All";
            this.view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.view.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Silver;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(881, 53);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 44);
            this.Save.TabIndex = 69;
            this.Save.Text = "Save";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.Color.Silver;
            this.Out.FlatAppearance.BorderSize = 0;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.ForeColor = System.Drawing.Color.Black;
            this.Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Out.Location = new System.Drawing.Point(749, 53);
            this.Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(83, 44);
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
            this.In.Location = new System.Drawing.Point(625, 53);
            this.In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(80, 44);
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
            this.entry.Location = new System.Drawing.Point(413, 53);
            this.entry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(163, 44);
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
            this.label3.Location = new System.Drawing.Point(31, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 30);
            this.label3.TabIndex = 65;
            this.label3.Text = "Stock In and Out Record";
            // 
            // categ
            // 
            this.categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(191, 598);
            this.categ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(255, 33);
            this.categ.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 61;
            this.label1.Text = "Category:";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(668, 598);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(247, 32);
            this.search.TabIndex = 59;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(922, 587);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 52);
            this.button3.TabIndex = 60;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(309, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 40);
            this.label2.TabIndex = 53;
            this.label2.Text = "Inventory Management System";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 120);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(948, 430);
            this.dataGridView2.TabIndex = 71;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.In);
            this.Controls.Add(this.entry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "inventory";
            this.Size = new System.Drawing.Size(1021, 682);
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button entry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
