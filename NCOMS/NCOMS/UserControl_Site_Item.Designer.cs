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
            this.label_title = new System.Windows.Forms.Label();
            this.pb_time_line = new System.Windows.Forms.ProgressBar();
            this.label_start_date = new System.Windows.Forms.Label();
            this.label_end_date = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_estimated_cost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(21, 17);
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
            this.label_address.Location = new System.Drawing.Point(25, 41);
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
            this.label_estimated_cost.AutoSize = true;
            this.label_estimated_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estimated_cost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_estimated_cost.Location = new System.Drawing.Point(397, 41);
            this.label_estimated_cost.Name = "label_estimated_cost";
            this.label_estimated_cost.Size = new System.Drawing.Size(99, 18);
            this.label_estimated_cost.TabIndex = 6;
            this.label_estimated_cost.Text = "Rs.425800.00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(400, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "More";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UserControl_Site_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}
