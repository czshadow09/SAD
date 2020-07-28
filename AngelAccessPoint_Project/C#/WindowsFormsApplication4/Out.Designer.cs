namespace WindowsFormsApplication4
{
    partial class Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Out));
            this.cancel = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.cons_quant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(141, 84);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(128, 54);
            this.cancel.TabIndex = 100;
            this.cancel.Text = "Cancel";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Subtract
            // 
            this.Subtract.FlatAppearance.BorderSize = 0;
            this.Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtract.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Subtract.Image = ((System.Drawing.Image)(resources.GetObject("Subtract.Image")));
            this.Subtract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subtract.Location = new System.Drawing.Point(11, 84);
            this.Subtract.Margin = new System.Windows.Forms.Padding(2);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(134, 54);
            this.Subtract.TabIndex = 99;
            this.Subtract.Text = " Stock Out";
            this.Subtract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 98;
            this.label7.Text = "Quantity:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(141, 23);
            this.quan.Margin = new System.Windows.Forms.Padding(2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(111, 28);
            this.quan.TabIndex = 97;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(178, 59);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(58, 20);
            this.id.TabIndex = 101;
            this.id.Visible = false;
            // 
            // cons_quant
            // 
            this.cons_quant.Location = new System.Drawing.Point(46, 59);
            this.cons_quant.Name = "cons_quant";
            this.cons_quant.Size = new System.Drawing.Size(58, 20);
            this.cons_quant.TabIndex = 102;
            this.cons_quant.Visible = false;
            // 
            // Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(278, 149);
            this.Controls.Add(this.cons_quant);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Out";
            this.Load += new System.EventHandler(this.Out_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quan;
        public System.Windows.Forms.TextBox id;
        public System.Windows.Forms.TextBox cons_quant;
    }
}
