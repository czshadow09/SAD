namespace WindowsFormsApplication4
{
    partial class prod
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prod));
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.AddC = new System.Windows.Forms.Button();
            this.categ = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(227, 448);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(179, 69);
            this.Update.TabIndex = 106;
            this.Update.Text = "Update";
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(40, 448);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(165, 76);
            this.Add.TabIndex = 105;
            this.Add.Text = " Add";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddC
            // 
            this.AddC.FlatAppearance.BorderSize = 0;
            this.AddC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddC.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddC.Image = ((System.Drawing.Image)(resources.GetObject("AddC.Image")));
            this.AddC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddC.Location = new System.Drawing.Point(40, 528);
            this.AddC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddC.Name = "AddC";
            this.AddC.Size = new System.Drawing.Size(165, 71);
            this.AddC.TabIndex = 104;
            this.AddC.Text = "Add Category";
            this.AddC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddC.UseVisualStyleBackColor = true;
            this.AddC.Click += new System.EventHandler(this.AddC_Click);
            // 
            // categ
            // 
            this.categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.categ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(24, 169);
            this.categ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(373, 37);
            this.categ.TabIndex = 103;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 102;
            this.label7.Text = "Quantity:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(24, 411);
            this.quan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(375, 34);
            this.quan.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 100;
            this.label6.Text = "Store Price:";
            // 
            // Sprice
            // 
            this.Sprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sprice.Location = new System.Drawing.Point(24, 327);
            this.Sprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sprice.Name = "Sprice";
            this.Sprice.Size = new System.Drawing.Size(375, 34);
            this.Sprice.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 28);
            this.label5.TabIndex = 98;
            this.label5.Text = "Purchase Price:";
            // 
            // Pprice
            // 
            this.Pprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pprice.Location = new System.Drawing.Point(24, 247);
            this.Pprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(375, 34);
            this.Pprice.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 96;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 95;
            this.label3.Text = "Description:";
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desc.Location = new System.Drawing.Point(24, 87);
            this.desc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(375, 34);
            this.desc.TabIndex = 94;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(322, 11);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(56, 34);
            this.id.TabIndex = 93;
            this.id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 33);
            this.label2.TabIndex = 92;
            this.label2.Text = "Create New Product";
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(227, 527);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(171, 75);
            this.cancel.TabIndex = 107;
            this.cancel.Text = "Cancel";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(417, 623);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddC);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prod";
            this.Load += new System.EventHandler(this.prod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button AddC;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
    }
}