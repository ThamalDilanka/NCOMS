namespace NCOMS
{
    partial class Form_Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Loading));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loading_Timer1 = new System.Windows.Forms.Timer(this.components);
            this.loading_Message = new System.Windows.Forms.Label();
            this.loading_Timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loading_Timer1
            // 
            this.loading_Timer1.Interval = 1000;
            this.loading_Timer1.Tick += new System.EventHandler(this.Loading_Timer_Tick);
            // 
            // loading_Message
            // 
            this.loading_Message.AutoSize = true;
            this.loading_Message.BackColor = System.Drawing.Color.Transparent;
            this.loading_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_Message.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loading_Message.Location = new System.Drawing.Point(124, 126);
            this.loading_Message.Name = "loading_Message";
            this.loading_Message.Size = new System.Drawing.Size(164, 20);
            this.loading_Message.TabIndex = 3;
            this.loading_Message.Text = "Checking Connectivity";
            this.loading_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading_Timer2
            // 
            this.loading_Timer2.Interval = 1000;
            this.loading_Timer2.Tick += new System.EventHandler(this.Loading_Timer2_Tick);
            // 
            // Form_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(419, 182);
            this.Controls.Add(this.loading_Message);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading_Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Loading_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer loading_Timer1;
        private System.Windows.Forms.Label loading_Message;
        private System.Windows.Forms.Timer loading_Timer2;
    }
}