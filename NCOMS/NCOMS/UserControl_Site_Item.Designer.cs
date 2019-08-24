namespace NCOMS
{
    partial class UserControl_Site_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Site_Item));
            this.label_title = new System.Windows.Forms.Label();
            this.pb_time_line = new System.Windows.Forms.ProgressBar();
            this.label_start_date = new System.Windows.Forms.Label();
            this.label_end_date = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_estimated_cost = new System.Windows.Forms.Label();
            this.btn_more = new System.Windows.Forms.Button();
            this.label_site_id = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label_supervisor_name = new System.Windows.Forms.Label();
            this.label_staff_allocated_site_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(24, 17);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(50, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title";
            // 
            // pb_time_line
            // 
            this.pb_time_line.Location = new System.Drawing.Point(25, 175);
            this.pb_time_line.Name = "pb_time_line";
            this.pb_time_line.Size = new System.Drawing.Size(471, 10);
            this.pb_time_line.TabIndex = 1;
            this.pb_time_line.Value = 50;
            // 
            // label_start_date
            // 
            this.label_start_date.AutoSize = true;
            this.label_start_date.Location = new System.Drawing.Point(25, 156);
            this.label_start_date.Name = "label_start_date";
            this.label_start_date.Size = new System.Drawing.Size(61, 13);
            this.label_start_date.TabIndex = 2;
            this.label_start_date.Text = "2019.08.25";
            // 
            // label_end_date
            // 
            this.label_end_date.AutoSize = true;
            this.label_end_date.Location = new System.Drawing.Point(435, 156);
            this.label_end_date.Name = "label_end_date";
            this.label_end_date.Size = new System.Drawing.Size(61, 13);
            this.label_end_date.TabIndex = 3;
            this.label_end_date.Text = "2020.08.25";
            // 
            // label_address
            // 
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_address.Location = new System.Drawing.Point(26, 43);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(327, 44);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "No 32, Bendiwewa, Polonnaruwa";
            // 
            // label_description
            // 
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(25, 95);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(471, 50);
            this.label_description.TabIndex = 5;
            this.label_description.Text = "Description";
            // 
            // label_estimated_cost
            // 
            this.label_estimated_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estimated_cost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_estimated_cost.Location = new System.Drawing.Point(410, 41);
            this.label_estimated_cost.Name = "label_estimated_cost";
            this.label_estimated_cost.Size = new System.Drawing.Size(86, 18);
            this.label_estimated_cost.TabIndex = 6;
            this.label_estimated_cost.Text = "1000000";
            this.label_estimated_cost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_more
            // 
            this.btn_more.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_more.ForeColor = System.Drawing.Color.White;
            this.btn_more.Location = new System.Drawing.Point(400, 199);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(96, 37);
            this.btn_more.TabIndex = 7;
            this.btn_more.Text = "More";
            this.btn_more.UseVisualStyleBackColor = false;
            this.btn_more.Click += new System.EventHandler(this.Btn_more_Click);
            // 
            // label_site_id
            // 
            this.label_site_id.AutoSize = true;
            this.label_site_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_site_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_site_id.Location = new System.Drawing.Point(252, 218);
            this.label_site_id.Name = "label_site_id";
            this.label_site_id.Size = new System.Drawing.Size(40, 18);
            this.label_site_id.TabIndex = 8;
            this.label_site_id.Text = "1000";
            this.label_site_id.Visible = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(298, 199);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 37);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(403, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rs.";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(25, 199);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(36, 37);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // label_supervisor_name
            // 
            this.label_supervisor_name.BackColor = System.Drawing.Color.Transparent;
            this.label_supervisor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supervisor_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_supervisor_name.Location = new System.Drawing.Point(362, 17);
            this.label_supervisor_name.Name = "label_supervisor_name";
            this.label_supervisor_name.Size = new System.Drawing.Size(134, 18);
            this.label_supervisor_name.TabIndex = 12;
            this.label_supervisor_name.Text = "Nimal Perera";
            this.label_supervisor_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_staff_allocated_site_id
            // 
            this.label_staff_allocated_site_id.AutoSize = true;
            this.label_staff_allocated_site_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff_allocated_site_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_staff_allocated_site_id.Location = new System.Drawing.Point(206, 218);
            this.label_staff_allocated_site_id.Name = "label_staff_allocated_site_id";
            this.label_staff_allocated_site_id.Size = new System.Drawing.Size(40, 18);
            this.label_staff_allocated_site_id.TabIndex = 13;
            this.label_staff_allocated_site_id.Text = "1000";
            this.label_staff_allocated_site_id.Visible = false;
            // 
            // UserControl_Site_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_staff_allocated_site_id);
            this.Controls.Add(this.label_supervisor_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label_site_id);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.label_estimated_cost);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_end_date);
            this.Controls.Add(this.label_start_date);
            this.Controls.Add(this.pb_time_line);
            this.Controls.Add(this.label_title);
            this.Name = "UserControl_Site_Item";
            this.Size = new System.Drawing.Size(528, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ProgressBar pb_time_line;
        private System.Windows.Forms.Label label_start_date;
        private System.Windows.Forms.Label label_end_date;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_estimated_cost;
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Label label_site_id;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label_supervisor_name;
        private System.Windows.Forms.Label label_staff_allocated_site_id;
    }
}
