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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManagerMainWindow));
            this.FormCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_navigation_container = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // FormCurve
            // 
            this.FormCurve.ElipseRadius = 15;
            this.FormCurve.TargetControl = this;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_header.Controls.Add(this.btn_minimize);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1350, 30);
            this.panel_header.TabIndex = 11;
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
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_container.Location = new System.Drawing.Point(260, 30);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1090, 690);
            this.panel_container.TabIndex = 12;
            // 
            // panel_navigation_container
            // 
            this.panel_navigation_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation_container.Location = new System.Drawing.Point(0, 30);
            this.panel_navigation_container.Name = "panel_navigation_container";
            this.panel_navigation_container.Size = new System.Drawing.Size(260, 690);
            this.panel_navigation_container.TabIndex = 13;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form_ManagerMainWindow
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
            this.Name = "Form_ManagerMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindowForm";
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormCurve;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_navigation_container;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
    }
}