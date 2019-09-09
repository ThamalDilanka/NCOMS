namespace NCOMS
{
    partial class Form_ClerkMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ClerkMainWindow));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_navigation_container = new System.Windows.Forms.Panel();
            this.pb_prifilePicture = new NCOMS.CircularPictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_nav_vehicle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.btn_nav_dashboard = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_navigation_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prifilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(88, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Clerk";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 1);
            this.label2.TabIndex = 21;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.ForeColor = System.Drawing.Color.White;
            this.label_userName.Location = new System.Drawing.Point(47, 97);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(113, 16);
            this.label_userName.TabIndex = 18;
            this.label_userName.Text = "Pawani Nawodya";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(-3, 7);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(76, 16);
            this.label_title.TabIndex = 22;
            this.label_title.Text = "Dashboard";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Controls.Add(this.btn_minimize);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.ForeColor = System.Drawing.Color.Transparent;
            this.panel_header.Location = new System.Drawing.Point(200, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1150, 30);
            this.panel_header.TabIndex = 17;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_header_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::NCOMS.Properties.Resources.minimize_16_ash;
            this.btn_minimize.Location = new System.Drawing.Point(1093, 1);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(28, 28);
            this.btn_minimize.TabIndex = 15;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.MouseLeave += new System.EventHandler(this.Btn_minimize_MouseLeave);
            this.btn_minimize.MouseHover += new System.EventHandler(this.Btn_minimize_MouseHover);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::NCOMS.Properties.Resources.close_16_ash;
            this.btn_close.Location = new System.Drawing.Point(1122, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 14;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.MouseLeave += new System.EventHandler(this.Btn_close_MouseLeave);
            this.btn_close.MouseHover += new System.EventHandler(this.Btn_close_MouseHover);
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_container.Location = new System.Drawing.Point(200, 30);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1150, 690);
            this.panel_container.TabIndex = 18;
            // 
            // panel_navigation_container
            // 
            this.panel_navigation_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_navigation_container.Controls.Add(this.label4);
            this.panel_navigation_container.Controls.Add(this.pb_prifilePicture);
            this.panel_navigation_container.Controls.Add(this.button5);
            this.panel_navigation_container.Controls.Add(this.button6);
            this.panel_navigation_container.Controls.Add(this.btn_nav_vehicle);
            this.panel_navigation_container.Controls.Add(this.button4);
            this.panel_navigation_container.Controls.Add(this.label2);
            this.panel_navigation_container.Controls.Add(this.button3);
            this.panel_navigation_container.Controls.Add(this.label_userName);
            this.panel_navigation_container.Controls.Add(this.btn_signout);
            this.panel_navigation_container.Controls.Add(this.btn_nav_dashboard);
            this.panel_navigation_container.Controls.Add(this.btn);
            this.panel_navigation_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation_container.ForeColor = System.Drawing.Color.Black;
            this.panel_navigation_container.Location = new System.Drawing.Point(0, 0);
            this.panel_navigation_container.Name = "panel_navigation_container";
            this.panel_navigation_container.Size = new System.Drawing.Size(200, 720);
            this.panel_navigation_container.TabIndex = 19;
            // 
            // pb_prifilePicture
            // 
            this.pb_prifilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pb_prifilePicture.Image")));
            this.pb_prifilePicture.Location = new System.Drawing.Point(66, 19);
            this.pb_prifilePicture.Name = "pb_prifilePicture";
            this.pb_prifilePicture.Size = new System.Drawing.Size(75, 75);
            this.pb_prifilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_prifilePicture.TabIndex = 26;
            this.pb_prifilePicture.TabStop = false;
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
            this.button5.Location = new System.Drawing.Point(0, 385);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 33);
            this.button5.TabIndex = 25;
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
            this.button6.Location = new System.Drawing.Point(0, 352);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 33);
            this.button6.TabIndex = 24;
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
            this.btn_nav_vehicle.Location = new System.Drawing.Point(0, 286);
            this.btn_nav_vehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nav_vehicle.Name = "btn_nav_vehicle";
            this.btn_nav_vehicle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_nav_vehicle.Size = new System.Drawing.Size(200, 33);
            this.btn_nav_vehicle.TabIndex = 23;
            this.btn_nav_vehicle.Text = "       Vehicle";
            this.btn_nav_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_vehicle.UseVisualStyleBackColor = false;
            this.btn_nav_vehicle.Click += new System.EventHandler(this.Btn_nav_vehicle_Click);
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
            this.button4.Location = new System.Drawing.Point(0, 451);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 33);
            this.button4.TabIndex = 22;
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
            this.button3.Location = new System.Drawing.Point(0, 418);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 33);
            this.button3.TabIndex = 20;
            this.button3.Text = "       Salary Management";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.Color.Transparent;
            this.btn_signout.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_nav_dashboard.Location = new System.Drawing.Point(0, 253);
            this.btn_nav_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nav_dashboard.Name = "btn_nav_dashboard";
            this.btn_nav_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_nav_dashboard.Size = new System.Drawing.Size(200, 33);
            this.btn_nav_dashboard.TabIndex = 2;
            this.btn_nav_dashboard.Text = "       Dashboard";
            this.btn_nav_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_dashboard.UseVisualStyleBackColor = false;
            this.btn_nav_dashboard.Click += new System.EventHandler(this.Btn_nav_dashboard_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Image = global::NCOMS.Properties.Resources.icons8_group_1;
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Location = new System.Drawing.Point(0, 319);
            this.btn.Margin = new System.Windows.Forms.Padding(0);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn.Size = new System.Drawing.Size(200, 33);
            this.btn.TabIndex = 1;
            this.btn.Text = "       Staff Members         ";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.UseVisualStyleBackColor = false;
            // 
            // Form_ClerkMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_navigation_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ClerkMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ClerkMainWindow";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_navigation_container.ResumeLayout(false);
            this.panel_navigation_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prifilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private CircularPictureBox pb_prifilePicture;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_nav_vehicle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Button btn_nav_dashboard;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_navigation_container;
    }
}