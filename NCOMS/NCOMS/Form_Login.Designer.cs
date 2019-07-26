namespace NCOMS
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lf_UserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lf_Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuLogin_FormFadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(111, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nipunajith Constructions (Pvt) LTD";
            // 
            // lf_UserName
            // 
            this.lf_UserName.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.lf_UserName.BorderColorIdle = System.Drawing.Color.Gray;
            this.lf_UserName.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.lf_UserName.BorderThickness = 1;
            this.lf_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lf_UserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lf_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lf_UserName.isPassword = false;
            this.lf_UserName.Location = new System.Drawing.Point(67, 289);
            this.lf_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.lf_UserName.Name = "lf_UserName";
            this.lf_UserName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lf_UserName.Size = new System.Drawing.Size(297, 33);
            this.lf_UserName.TabIndex = 3;
            this.lf_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lf_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lf_UserName_KeyDown);
            // 
            // lf_Password
            // 
            this.lf_Password.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.lf_Password.BorderColorIdle = System.Drawing.Color.Gray;
            this.lf_Password.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.lf_Password.BorderThickness = 1;
            this.lf_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lf_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lf_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lf_Password.isPassword = true;
            this.lf_Password.Location = new System.Drawing.Point(67, 358);
            this.lf_Password.Margin = new System.Windows.Forms.Padding(4);
            this.lf_Password.Name = "lf_Password";
            this.lf_Password.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lf_Password.Size = new System.Drawing.Size(297, 33);
            this.lf_Password.TabIndex = 4;
            this.lf_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lf_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lf_Password_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(63, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(63, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.BorderRadius = 0;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Login.Iconimage = null;
            this.btn_Login.Iconimage_right = null;
            this.btn_Login.Iconimage_right_Selected = null;
            this.btn_Login.Iconimage_Selected = null;
            this.btn_Login.IconMarginLeft = 0;
            this.btn_Login.IconMarginRight = 0;
            this.btn_Login.IconRightVisible = true;
            this.btn_Login.IconRightZoom = 0D;
            this.btn_Login.IconVisible = true;
            this.btn_Login.IconZoom = 90D;
            this.btn_Login.IsTab = false;
            this.btn_Login.Location = new System.Drawing.Point(140, 422);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Login.selected = false;
            this.btn_Login.Size = new System.Drawing.Size(151, 44);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.White;
            this.btn_Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(400, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuLogin_FormFadeTransition
            // 
            this.bunifuLogin_FormFadeTransition.Delay = 1;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 501);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lf_Password);
            this.Controls.Add(this.lf_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox lf_Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox lf_UserName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuLogin_FormFadeTransition;
    }
}

