namespace NCOMS
{
    partial class Form_ManagerMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManagerMainWindow));
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_navigation_container = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_nav_vehicle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_nav_dashboard = new System.Windows.Forms.Button();
            this.btn_staff_members = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new NCOMS.CircularPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signout = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_navigation_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1095, 1);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(21, 28);
            this.btn_minimize.TabIndex = 15;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1122, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(18, 28);
            this.btn_close.TabIndex = 14;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_container.Location = new System.Drawing.Point(200, 30);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1150, 690);
            this.panel_container.TabIndex = 12;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Controls.Add(this.btn_minimize);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Location = new System.Drawing.Point(200, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1150, 30);
            this.panel_header.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dashboard";
            // 
            // panel_navigation_container
            // 
            this.panel_navigation_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_navigation_container.Controls.Add(this.button5);
            this.panel_navigation_container.Controls.Add(this.button6);
            this.panel_navigation_container.Controls.Add(this.btn_nav_vehicle);
            this.panel_navigation_container.Controls.Add(this.button4);
            this.panel_navigation_container.Controls.Add(this.button3);
            this.panel_navigation_container.Controls.Add(this.btn_nav_dashboard);
            this.panel_navigation_container.Controls.Add(this.btn_staff_members);
            this.panel_navigation_container.Controls.Add(this.label4);
            this.panel_navigation_container.Controls.Add(this.circularPictureBox1);
            this.panel_navigation_container.Controls.Add(this.label2);
            this.panel_navigation_container.Controls.Add(this.label1);
            this.panel_navigation_container.Controls.Add(this.btn_signout);
            this.panel_navigation_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation_container.ForeColor = System.Drawing.Color.Black;
            this.panel_navigation_container.Location = new System.Drawing.Point(0, 0);
            this.panel_navigation_container.Name = "panel_navigation_container";
            this.panel_navigation_container.Size = new System.Drawing.Size(200, 720);
            this.panel_navigation_container.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::NCOMS.Properties.Resources.icons8_garage_open;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 377);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 33);
            this.button5.TabIndex = 34;
            this.button5.Text = "       Store ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::NCOMS.Properties.Resources.icons8_initiate_money_transfer;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 344);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 33);
            this.button6.TabIndex = 33;
            this.button6.Text = "       Money Requests";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btn_nav_vehicle
            // 
            this.btn_nav_vehicle.BackColor = System.Drawing.Color.Transparent;
            this.btn_nav_vehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nav_vehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nav_vehicle.FlatAppearance.BorderSize = 0;
            this.btn_nav_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nav_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nav_vehicle.ForeColor = System.Drawing.Color.White;
            this.btn_nav_vehicle.Image = global::NCOMS.Properties.Resources.icons8_trailer_unloading_1;
            this.btn_nav_vehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_vehicle.Location = new System.Drawing.Point(0, 278);
            this.btn_nav_vehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nav_vehicle.Name = "btn_nav_vehicle";
            this.btn_nav_vehicle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_nav_vehicle.Size = new System.Drawing.Size(200, 33);
            this.btn_nav_vehicle.TabIndex = 32;
            this.btn_nav_vehicle.Text = "       Vehicle";
            this.btn_nav_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_vehicle.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::NCOMS.Properties.Resources.icons8_user;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 443);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 33);
            this.button4.TabIndex = 31;
            this.button4.Text = "       Profile";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::NCOMS.Properties.Resources.icons8_cash_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 33);
            this.button3.TabIndex = 30;
            this.button3.Text = "       Salary Management";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_nav_dashboard
            // 
            this.btn_nav_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_nav_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nav_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nav_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_nav_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nav_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nav_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_nav_dashboard.Image = global::NCOMS.Properties.Resources.icons8_doughnut_chart;
            this.btn_nav_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_dashboard.Location = new System.Drawing.Point(0, 245);
            this.btn_nav_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nav_dashboard.Name = "btn_nav_dashboard";
            this.btn_nav_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_nav_dashboard.Size = new System.Drawing.Size(200, 33);
            this.btn_nav_dashboard.TabIndex = 29;
            this.btn_nav_dashboard.Text = "       Dashboard";
            this.btn_nav_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_dashboard.UseVisualStyleBackColor = false;
            // 
            // btn_staff_members
            // 
            this.btn_staff_members.BackColor = System.Drawing.Color.Transparent;
            this.btn_staff_members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staff_members.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_staff_members.FlatAppearance.BorderSize = 0;
            this.btn_staff_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_members.ForeColor = System.Drawing.Color.White;
            this.btn_staff_members.Image = global::NCOMS.Properties.Resources.icons8_group_1;
            this.btn_staff_members.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff_members.Location = new System.Drawing.Point(0, 311);
            this.btn_staff_members.Margin = new System.Windows.Forms.Padding(0);
            this.btn_staff_members.Name = "btn_staff_members";
            this.btn_staff_members.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_staff_members.Size = new System.Drawing.Size(200, 33);
            this.btn_staff_members.TabIndex = 28;
            this.btn_staff_members.Text = "       Staff Members         ";
            this.btn_staff_members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff_members.UseVisualStyleBackColor = false;
            this.btn_staff_members.Click += new System.EventHandler(this.Btn_staff_members_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(79, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Manager";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(66, 19);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(75, 75);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 26;
            this.circularPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 1);
            this.label2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pawani Nawodya";
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.Color.Transparent;
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.ForeColor = System.Drawing.Color.White;
            this.btn_signout.Image = ((System.Drawing.Image)(resources.GetObject("btn_signout.Image")));
            this.btn_signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signout.Location = new System.Drawing.Point(65, 138);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(77, 26);
            this.btn_signout.TabIndex = 16;
            this.btn_signout.Text = "SignOut";
            this.btn_signout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_signout.UseVisualStyleBackColor = false;
            this.btn_signout.Click += new System.EventHandler(this.Btn_signout_Click);
            // 
            // Form_ManagerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_navigation_container);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ManagerMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindowForm";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_navigation_container.ResumeLayout(false);
            this.panel_navigation_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_navigation_container;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_nav_vehicle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_nav_dashboard;
        private System.Windows.Forms.Button btn_staff_members;
    }
}