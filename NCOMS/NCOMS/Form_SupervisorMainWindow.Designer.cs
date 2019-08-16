namespace NCOMS
{
    partial class Form_SupervisorMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SupervisorMainWindow));
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.label_header_title = new System.Windows.Forms.Label();
            this.label_header_name = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_navigation_container = new System.Windows.Forms.Panel();
            this.btn_menu_money_request = new System.Windows.Forms.Button();
            this.btn_menu_weather_report = new System.Windows.Forms.Button();
            this.btn_menu_mat_request = new System.Windows.Forms.Button();
            this.btn_menu_lab_advance = new System.Windows.Forms.Button();
            this.btn_menu_lab_timesheet = new System.Windows.Forms.Button();
            this.btn_menu_mat_usage = new System.Windows.Forms.Button();
            this.btn_menu_dashboard = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_navigation_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_header.Controls.Add(this.btn_minimize);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Controls.Add(this.btn_signout);
            this.panel_header.Controls.Add(this.label_header_title);
            this.panel_header.Controls.Add(this.label_header_name);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1350, 30);
            this.panel_header.TabIndex = 12;
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1284, 1);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(28, 28);
            this.btn_minimize.TabIndex = 27;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::NCOMS.Properties.Resources.icons8_close_window_2;
            this.btn_close.Location = new System.Drawing.Point(1319, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 26;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.Image = ((System.Drawing.Image)(resources.GetObject("btn_signout.Image")));
            this.btn_signout.Location = new System.Drawing.Point(3, 1);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(28, 28);
            this.btn_signout.TabIndex = 25;
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.Btn_signout_Click);
            // 
            // label_header_title
            // 
            this.label_header_title.AutoSize = true;
            this.label_header_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_title.ForeColor = System.Drawing.Color.White;
            this.label_header_title.Location = new System.Drawing.Point(640, 6);
            this.label_header_title.Name = "label_header_title";
            this.label_header_title.Size = new System.Drawing.Size(71, 18);
            this.label_header_title.TabIndex = 24;
            this.label_header_title.Text = "Title Here";
            this.label_header_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_header_name
            // 
            this.label_header_name.AutoSize = true;
            this.label_header_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_name.ForeColor = System.Drawing.Color.White;
            this.label_header_name.Location = new System.Drawing.Point(36, 6);
            this.label_header_name.Name = "label_header_name";
            this.label_header_name.Size = new System.Drawing.Size(94, 18);
            this.label_header_name.TabIndex = 22;
            this.label_header_name.Text = "Nimal Perera";
            // 
            // panel_container
            // 
            this.panel_container.AutoScroll = true;
            this.panel_container.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_container.Location = new System.Drawing.Point(220, 30);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1130, 690);
            this.panel_container.TabIndex = 13;
            // 
            // panel_navigation_container
            // 
            this.panel_navigation_container.AutoScroll = true;
            this.panel_navigation_container.BackColor = System.Drawing.Color.White;
            this.panel_navigation_container.Controls.Add(this.btn_menu_money_request);
            this.panel_navigation_container.Controls.Add(this.btn_menu_weather_report);
            this.panel_navigation_container.Controls.Add(this.btn_menu_mat_request);
            this.panel_navigation_container.Controls.Add(this.btn_menu_lab_advance);
            this.panel_navigation_container.Controls.Add(this.btn_menu_lab_timesheet);
            this.panel_navigation_container.Controls.Add(this.btn_menu_mat_usage);
            this.panel_navigation_container.Controls.Add(this.btn_menu_dashboard);
            this.panel_navigation_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation_container.Location = new System.Drawing.Point(0, 30);
            this.panel_navigation_container.Name = "panel_navigation_container";
            this.panel_navigation_container.Size = new System.Drawing.Size(220, 690);
            this.panel_navigation_container.TabIndex = 14;
            // 
            // btn_menu_money_request
            // 
            this.btn_menu_money_request.BackColor = System.Drawing.Color.White;
            this.btn_menu_money_request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_money_request.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_money_request.FlatAppearance.BorderSize = 0;
            this.btn_menu_money_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_money_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_money_request.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_money_request.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_money_request.Image")));
            this.btn_menu_money_request.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_money_request.Location = new System.Drawing.Point(0, 304);
            this.btn_menu_money_request.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_money_request.Name = "btn_menu_money_request";
            this.btn_menu_money_request.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_money_request.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_money_request.TabIndex = 6;
            this.btn_menu_money_request.Text = "        Money Request";
            this.btn_menu_money_request.UseVisualStyleBackColor = true;
            this.btn_menu_money_request.Click += new System.EventHandler(this.Btn_menu_money_request_Click);
            // 
            // btn_menu_weather_report
            // 
            this.btn_menu_weather_report.BackColor = System.Drawing.Color.White;
            this.btn_menu_weather_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_weather_report.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_weather_report.FlatAppearance.BorderSize = 0;
            this.btn_menu_weather_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_weather_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_weather_report.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_weather_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_weather_report.Image")));
            this.btn_menu_weather_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_weather_report.Location = new System.Drawing.Point(0, 460);
            this.btn_menu_weather_report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_weather_report.Name = "btn_menu_weather_report";
            this.btn_menu_weather_report.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_weather_report.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_weather_report.TabIndex = 5;
            this.btn_menu_weather_report.Text = "        Weather Report";
            this.btn_menu_weather_report.UseVisualStyleBackColor = true;
            this.btn_menu_weather_report.Click += new System.EventHandler(this.Btn_menu_weather_report_Click);
            // 
            // btn_menu_mat_request
            // 
            this.btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            this.btn_menu_mat_request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_mat_request.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_mat_request.FlatAppearance.BorderSize = 0;
            this.btn_menu_mat_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_mat_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_mat_request.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_mat_request.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_mat_request.Image")));
            this.btn_menu_mat_request.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_mat_request.Location = new System.Drawing.Point(0, 252);
            this.btn_menu_mat_request.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_mat_request.Name = "btn_menu_mat_request";
            this.btn_menu_mat_request.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_mat_request.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_mat_request.TabIndex = 4;
            this.btn_menu_mat_request.Text = "          Material Request";
            this.btn_menu_mat_request.UseVisualStyleBackColor = true;
            this.btn_menu_mat_request.Click += new System.EventHandler(this.Btn_menu_mat_request_Click);
            // 
            // btn_menu_lab_advance
            // 
            this.btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            this.btn_menu_lab_advance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_lab_advance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_lab_advance.FlatAppearance.BorderSize = 0;
            this.btn_menu_lab_advance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_lab_advance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_lab_advance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_lab_advance.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_lab_advance.Image")));
            this.btn_menu_lab_advance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_lab_advance.Location = new System.Drawing.Point(0, 408);
            this.btn_menu_lab_advance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_lab_advance.Name = "btn_menu_lab_advance";
            this.btn_menu_lab_advance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_lab_advance.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_lab_advance.TabIndex = 3;
            this.btn_menu_lab_advance.Text = "       Labor Advance";
            this.btn_menu_lab_advance.UseVisualStyleBackColor = true;
            this.btn_menu_lab_advance.Click += new System.EventHandler(this.Btn_menu_lab_advance_Click);
            // 
            // btn_menu_lab_timesheet
            // 
            this.btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            this.btn_menu_lab_timesheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_lab_timesheet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_lab_timesheet.FlatAppearance.BorderSize = 0;
            this.btn_menu_lab_timesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_lab_timesheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_lab_timesheet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_lab_timesheet.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_lab_timesheet.Image")));
            this.btn_menu_lab_timesheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_lab_timesheet.Location = new System.Drawing.Point(0, 356);
            this.btn_menu_lab_timesheet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_lab_timesheet.Name = "btn_menu_lab_timesheet";
            this.btn_menu_lab_timesheet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_lab_timesheet.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_lab_timesheet.TabIndex = 2;
            this.btn_menu_lab_timesheet.Text = "            Labor Time Sheet";
            this.btn_menu_lab_timesheet.UseVisualStyleBackColor = true;
            this.btn_menu_lab_timesheet.Click += new System.EventHandler(this.Btn_menu_lab_timesheet_Click);
            // 
            // btn_menu_mat_usage
            // 
            this.btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            this.btn_menu_mat_usage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_mat_usage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_mat_usage.FlatAppearance.BorderSize = 0;
            this.btn_menu_mat_usage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_mat_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_mat_usage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_mat_usage.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_mat_usage.Image")));
            this.btn_menu_mat_usage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_mat_usage.Location = new System.Drawing.Point(0, 200);
            this.btn_menu_mat_usage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_mat_usage.Name = "btn_menu_mat_usage";
            this.btn_menu_mat_usage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_mat_usage.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_mat_usage.TabIndex = 1;
            this.btn_menu_mat_usage.Text = "       Material Usage";
            this.btn_menu_mat_usage.UseVisualStyleBackColor = true;
            this.btn_menu_mat_usage.Click += new System.EventHandler(this.Btn_menu_mat_usage_Click);
            // 
            // btn_menu_dashboard
            // 
            this.btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_menu_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menu_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_menu_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_dashboard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_menu_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_dashboard.Image")));
            this.btn_menu_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_dashboard.Location = new System.Drawing.Point(0, 148);
            this.btn_menu_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_dashboard.Name = "btn_menu_dashboard";
            this.btn_menu_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_dashboard.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_dashboard.TabIndex = 0;
            this.btn_menu_dashboard.Text = "Dashboard";
            this.btn_menu_dashboard.UseVisualStyleBackColor = true;
            this.btn_menu_dashboard.Click += new System.EventHandler(this.Btn_menu_dashboard_Click);
            // 
            // Form_SupervisorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Controls.Add(this.panel_navigation_container);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SupervisorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SupervisorMainWindow";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_navigation_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_navigation_container;
        private System.Windows.Forms.Button btn_menu_dashboard;
        private System.Windows.Forms.Button btn_menu_weather_report;
        private System.Windows.Forms.Button btn_menu_mat_request;
        private System.Windows.Forms.Button btn_menu_lab_advance;
        private System.Windows.Forms.Button btn_menu_lab_timesheet;
        private System.Windows.Forms.Button btn_menu_mat_usage;
        private System.Windows.Forms.Button btn_menu_money_request;
        private System.Windows.Forms.Label label_header_title;
        private System.Windows.Forms.Label label_header_name;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_signout;
    }
}