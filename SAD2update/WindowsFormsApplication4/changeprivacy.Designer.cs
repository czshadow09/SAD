namespace WindowsFormsApplication4
{
    partial class changeprivacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeprivacy));
            this.retype = new System.Windows.Forms.TextBox();
            this.newp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.old = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usern = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // retype
            // 
            this.retype.BackColor = System.Drawing.SystemColors.Window;
            this.retype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.retype.Font = new System.Drawing.Font("Verdana", 15.8F);
            this.retype.ForeColor = System.Drawing.Color.Black;
            this.retype.Location = new System.Drawing.Point(242, 219);
            this.retype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.retype.Name = "retype";
            this.retype.PasswordChar = '*';
            this.retype.Size = new System.Drawing.Size(232, 26);
            this.retype.TabIndex = 27;
            // 
            // newp
            // 
            this.newp.BackColor = System.Drawing.SystemColors.Window;
            this.newp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newp.Font = new System.Drawing.Font("Verdana", 15.8F);
            this.newp.ForeColor = System.Drawing.Color.Black;
            this.newp.Location = new System.Drawing.Point(242, 166);
            this.newp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newp.Name = "newp";
            this.newp.PasswordChar = '*';
            this.newp.Size = new System.Drawing.Size(232, 26);
            this.newp.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Retype password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Old password:";
            // 
            // old
            // 
            this.old.BackColor = System.Drawing.SystemColors.Window;
            this.old.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.old.Font = new System.Drawing.Font("Verdana", 15.8F);
            this.old.ForeColor = System.Drawing.Color.Black;
            this.old.Location = new System.Drawing.Point(242, 112);
            this.old.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.old.Name = "old";
            this.old.PasswordChar = '*';
            this.old.Size = new System.Drawing.Size(232, 26);
            this.old.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.usern);
            this.panel1.Controls.Add(this.retype);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.newp);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.old);
            this.panel1.Location = new System.Drawing.Point(110, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 390);
            this.panel1.TabIndex = 28;
            // 
            // update
            // 
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Teal;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(278, 277);
            this.update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(134, 56);
            this.update.TabIndex = 48;
            this.update.Text = "Update";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(164, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change Privacy";
            // 
            // usern
            // 
            this.usern.Location = new System.Drawing.Point(84, 78);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(81, 20);
            this.usern.TabIndex = 49;
            this.usern.Visible = false;
            // 
            // changeprivacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "changeprivacy";
            this.Size = new System.Drawing.Size(766, 554);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox retype;
        private System.Windows.Forms.TextBox newp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox old;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        public System.Windows.Forms.TextBox usern;
    }
}
