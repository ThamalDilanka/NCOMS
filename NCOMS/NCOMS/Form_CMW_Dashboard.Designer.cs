namespace NCOMS
{
    partial class Form_CMW_Dashboard
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
            this.flp_site_item_container = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_site_item_container
            // 
            this.flp_site_item_container.AutoScroll = true;
            this.flp_site_item_container.Location = new System.Drawing.Point(22, 64);
            this.flp_site_item_container.Name = "flp_site_item_container";
            this.flp_site_item_container.Size = new System.Drawing.Size(1096, 614);
            this.flp_site_item_container.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(761, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1024, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Construction Sites";
            // 
            // btn_add_new
            // 
            this.btn_add_new.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new.ForeColor = System.Drawing.Color.DimGray;
            this.btn_add_new.Location = new System.Drawing.Point(194, 17);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(75, 26);
            this.btn_add_new.TabIndex = 4;
            this.btn_add_new.Text = "Add New";
            this.btn_add_new.UseVisualStyleBackColor = false;
            this.btn_add_new.Click += new System.EventHandler(this.Btn_add_new_Click);
            // 
            // Form_CMW_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1130, 690);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flp_site_item_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CMW_Dashboard";
            this.Text = "Form_CMW_Dashboard";
            this.Load += new System.EventHandler(this.Form_CMW_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_site_item_container;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_new;
    }
}