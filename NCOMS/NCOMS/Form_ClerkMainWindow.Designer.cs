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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ClerkMainWindow));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_header_title = new System.Windows.Forms.Label();
            this.label_header_name = new System.Windows.Forms.Label();
            this.btn_header_user = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_signout = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_container = new System.Windows.Forms.Panel();
            this.form_curve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_navigation_container = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_menu_dashboard = new System.Windows.Forms.Button();
            this.form_drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_header_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_signout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel_navigation_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_header.Controls.Add(this.label_header_title);
            this.panel_header.Controls.Add(this.label_header_name);
            this.panel_header.Controls.Add(this.btn_header_user);
            this.panel_header.Controls.Add(this.btn_signout);
            this.panel_header.Controls.Add(this.btn_minimize);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1350, 30);
            this.panel_header.TabIndex = 12;
            // 
            // label_header_title
            // 
            this.label_header_title.AutoSize = true;
            this.label_header_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_title.ForeColor = System.Drawing.Color.White;
            this.label_header_title.Location = new System.Drawing.Point(640, 6);
            this.label_header_title.Name = "label_header_title";
            this.label_header_title.Size = new System.Drawing.Size(177, 18);
            this.label_header_title.TabIndex = 23;
            this.label_header_title.Text = "This is clerk main window";
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
            // btn_header_user
            // 
            this.btn_header_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_header_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_header_user.Image")));
            this.btn_header_user.ImageActive = null;
            this.btn_header_user.Location = new System.Drawing.Point(6, 3);
            this.btn_header_user.Name = "btn_header_user";
            this.btn_header_user.Size = new System.Drawing.Size(24, 24);
            this.btn_header_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_header_user.TabIndex = 21;
            this.btn_header_user.TabStop = false;
            this.btn_header_user.Zoom = 10;
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.Color.Transparent;
            this.btn_signout.Image = ((System.Drawing.Image)(resources.GetObject("btn_signout.Image")));
            this.btn_signout.ImageActive = null;
            this.btn_signout.Location = new System.Drawing.Point(1240, 4);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(24, 24);
            this.btn_signout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_signout.TabIndex = 16;
            this.btn_signout.TabStop = false;
            this.btn_signout.Zoom = 10;
            this.btn_signout.Click += new System.EventHandler(this.Btn_signout_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(1277, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(24, 24);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 12;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Zoom = 10;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(1313, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 11;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel_container
            // 
            this.panel_container.AutoScroll = true;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_container.Location = new System.Drawing.Point(220, 30);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1130, 690);
            this.panel_container.TabIndex = 13;
            // 
            // form_curve
            // 
            this.form_curve.ElipseRadius = 5;
            this.form_curve.TargetControl = this;
            // 
            // panel_navigation_container
            // 
            this.panel_navigation_container.AutoScroll = true;
            this.panel_navigation_container.BackColor = System.Drawing.Color.White;
            this.panel_navigation_container.Controls.Add(this.button1);
            this.panel_navigation_container.Controls.Add(this.btn_menu_dashboard);
            this.panel_navigation_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation_container.Location = new System.Drawing.Point(0, 30);
            this.panel_navigation_container.Name = "panel_navigation_container";
            this.panel_navigation_container.Size = new System.Drawing.Size(220, 690);
            this.panel_navigation_container.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "   Material Cost";
            this.button1.UseVisualStyleBackColor = true;
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
            this.btn_menu_dashboard.Location = new System.Drawing.Point(0, 104);
            this.btn_menu_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu_dashboard.Name = "btn_menu_dashboard";
            this.btn_menu_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_menu_dashboard.Size = new System.Drawing.Size(220, 50);
            this.btn_menu_dashboard.TabIndex = 0;
            this.btn_menu_dashboard.Text = "Dashboard";
            this.btn_menu_dashboard.UseVisualStyleBackColor = true;
            this.btn_menu_dashboard.Click += new System.EventHandler(this.Btn_menu_dashboard_Click);
            // 
            // form_drag
            // 
            this.form_drag.Fixed = true;
            this.form_drag.Horizontal = true;
            this.form_drag.TargetControl = this.panel_header;
            this.form_drag.Vertical = true;
            // 
            // Form_ClerkMainWindow
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
            this.Name = "Form_ClerkMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ClerkMainWindow";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_header_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_signout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel_navigation_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Panel panel_container;
        private Bunifu.Framework.UI.BunifuImageButton btn_signout;
        private Bunifu.Framework.UI.BunifuElipse form_curve;
        private Bunifu.Framework.UI.BunifuImageButton btn_header_user;
        private System.Windows.Forms.Label label_header_name;
        private System.Windows.Forms.Label label_header_title;
        private System.Windows.Forms.Panel panel_navigation_container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_menu_dashboard;
        private Bunifu.Framework.UI.BunifuDragControl form_drag;
    }
}