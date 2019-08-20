namespace NCOMS
{
    partial class UserControl_Container_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Container_Message));
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.label_message = new System.Windows.Forms.Label();
            this.label_key_word = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icon
            // 
            this.pb_icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_icon.Image")));
            this.pb_icon.Location = new System.Drawing.Point(267, 28);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(50, 50);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.Gray;
            this.label_message.Location = new System.Drawing.Point(338, 28);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(526, 24);
            this.label_message.TabIndex = 1;
            this.label_message.Text = "Sorry! System Could\'t Find Any Search Result Matching";
            // 
            // label_key_word
            // 
            this.label_key_word.AutoSize = true;
            this.label_key_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_key_word.ForeColor = System.Drawing.Color.Gray;
            this.label_key_word.Location = new System.Drawing.Point(338, 52);
            this.label_key_word.Name = "label_key_word";
            this.label_key_word.Size = new System.Drawing.Size(101, 24);
            this.label_key_word.TabIndex = 2;
            this.label_key_word.Text = "Key Word";
            // 
            // UserControl_Container_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_key_word);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.pb_icon);
            this.Name = "UserControl_Container_Message";
            this.Size = new System.Drawing.Size(1120, 111);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label label_key_word;
    }
}
