namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateonly = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnpass = new System.Windows.Forms.TextBox();
            this.btnuser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.dateonly);
            this.panel2.Controls.Add(this.sign);
            this.panel2.Controls.Add(this.date);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 53);
            this.panel2.TabIndex = 1;
            // 
            // dateonly
            // 
            this.dateonly.Location = new System.Drawing.Point(141, 16);
            this.dateonly.Name = "dateonly";
            this.dateonly.Size = new System.Drawing.Size(53, 20);
            this.dateonly.TabIndex = 21;
            this.dateonly.Visible = false;
            // 
            // sign
            // 
            this.sign.FlatAppearance.BorderSize = 0;
            this.sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.ForeColor = System.Drawing.Color.White;
            this.sign.Location = new System.Drawing.Point(235, 14);
            this.sign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(86, 29);
            this.sign.TabIndex = 4;
            this.sign.Text = "Sign up";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click_1);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(20, 14);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 20);
            this.date.TabIndex = 20;
            this.date.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(0, -3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 115);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(300, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(16, -13);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(304, 151);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 197);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(98, 242);
            this.btnok.Margin = new System.Windows.Forms.Padding(0);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(150, 40);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "Log In";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnpass
            // 
            this.btnpass.BackColor = System.Drawing.SystemColors.Window;
            this.btnpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnpass.Font = new System.Drawing.Font("Verdana", 15.8F);
            this.btnpass.ForeColor = System.Drawing.Color.DarkGray;
            this.btnpass.Location = new System.Drawing.Point(50, 197);
            this.btnpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpass.Name = "btnpass";
            this.btnpass.PasswordChar = '*';
            this.btnpass.Size = new System.Drawing.Size(258, 26);
            this.btnpass.TabIndex = 2;
            this.btnpass.Text = "****";
            this.btnpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnpass.Click += new System.EventHandler(this.btnpass_Click);
            this.btnpass.TextChanged += new System.EventHandler(this.btnpass_TextChanged);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.SystemColors.Window;
            this.btnuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnuser.Font = new System.Drawing.Font("Verdana", 15.8F);
            this.btnuser.ForeColor = System.Drawing.Color.DarkGray;
            this.btnuser.Location = new System.Drawing.Point(50, 138);
            this.btnuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(258, 26);
            this.btnuser.TabIndex = 1;
            this.btnuser.Text = "username";
            this.btnuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            this.btnuser.TextChanged += new System.EventHandler(this.btnuser_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pictureBox5;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(335, 352);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnpass);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox btnpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox date;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.TextBox dateonly;
        public System.Windows.Forms.TextBox btnuser;
    }
}

