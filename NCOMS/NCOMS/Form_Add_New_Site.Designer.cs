namespace NCOMS
{
    partial class Form_Add_New_Site
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_header_title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_estimated_cost = new System.Windows.Forms.TextBox();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Controls.Add(this.label_header_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(510, 30);
            this.panel_header.TabIndex = 13;
            // 
            // label_header_title
            // 
            this.label_header_title.AutoSize = true;
            this.label_header_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_title.ForeColor = System.Drawing.Color.White;
            this.label_header_title.Location = new System.Drawing.Point(219, 7);
            this.label_header_title.Name = "label_header_title";
            this.label_header_title.Size = new System.Drawing.Size(62, 18);
            this.label_header_title.TabIndex = 21;
            this.label_header_title.Text = "Add Site";
            this.label_header_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(359, 560);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 36);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // tb_title
            // 
            this.tb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.Location = new System.Drawing.Point(28, 75);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(449, 24);
            this.tb_title.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Project Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(28, 133);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(449, 122);
            this.tb_description.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(28, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Construction Site Address";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(28, 292);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_address.Size = new System.Drawing.Size(449, 80);
            this.tb_address.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(25, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estimated Cost";
            // 
            // tb_estimated_cost
            // 
            this.tb_estimated_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estimated_cost.Location = new System.Drawing.Point(28, 415);
            this.tb_estimated_cost.Name = "tb_estimated_cost";
            this.tb_estimated_cost.Size = new System.Drawing.Size(449, 24);
            this.tb_estimated_cost.TabIndex = 21;
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.Location = new System.Drawing.Point(28, 502);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_start_date.TabIndex = 23;
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.Location = new System.Drawing.Point(277, 502);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_end_date.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(25, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(274, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Date to Be Completed";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gold;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(222, 560);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 36);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::NCOMS.Properties.Resources.icons8_close_window_2;
            this.btn_close.Location = new System.Drawing.Point(479, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 24;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Form_Add_New_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(510, 628);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_end_date);
            this.Controls.Add(this.dtp_start_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_estimated_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add_New_Site";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_New_Site";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_header_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end_date;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_estimated_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
    }
}