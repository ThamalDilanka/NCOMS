﻿namespace NCOMS
{
    partial class Form_Update_Site
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_Site));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_supervisor_msg = new System.Windows.Forms.Label();
            this.label_csaddress_msg = new System.Windows.Forms.Label();
            this.label_date_msg = new System.Windows.Forms.Label();
            this.label_description_msg = new System.Windows.Forms.Label();
            this.label_prtitle_msg = new System.Windows.Forms.Label();
            this.label_estcost_msg = new System.Windows.Forms.Label();
            this.cb_supervisor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_estimated_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(593, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 24;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(416, 578);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 36);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gold;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(279, 578);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 36);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(79, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 34);
            this.label8.TabIndex = 59;
            this.label8.Text = "Update Site";
            // 
            // label_supervisor_msg
            // 
            this.label_supervisor_msg.AutoSize = true;
            this.label_supervisor_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supervisor_msg.ForeColor = System.Drawing.Color.Red;
            this.label_supervisor_msg.Location = new System.Drawing.Point(331, 471);
            this.label_supervisor_msg.Name = "label_supervisor_msg";
            this.label_supervisor_msg.Size = new System.Drawing.Size(130, 13);
            this.label_supervisor_msg.TabIndex = 58;
            this.label_supervisor_msg.Text = "Please select a supervisor";
            this.label_supervisor_msg.Visible = false;
            // 
            // label_csaddress_msg
            // 
            this.label_csaddress_msg.AutoSize = true;
            this.label_csaddress_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_csaddress_msg.ForeColor = System.Drawing.Color.Red;
            this.label_csaddress_msg.Location = new System.Drawing.Point(82, 401);
            this.label_csaddress_msg.Name = "label_csaddress_msg";
            this.label_csaddress_msg.Size = new System.Drawing.Size(204, 13);
            this.label_csaddress_msg.TabIndex = 57;
            this.label_csaddress_msg.Text = "Please enter the construction site address";
            this.label_csaddress_msg.Visible = false;
            // 
            // label_date_msg
            // 
            this.label_date_msg.AutoSize = true;
            this.label_date_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_msg.ForeColor = System.Drawing.Color.Red;
            this.label_date_msg.Location = new System.Drawing.Point(82, 543);
            this.label_date_msg.Name = "label_date_msg";
            this.label_date_msg.Size = new System.Drawing.Size(164, 13);
            this.label_date_msg.TabIndex = 56;
            this.label_date_msg.Text = "Start date is earlier than End date";
            this.label_date_msg.Visible = false;
            // 
            // label_description_msg
            // 
            this.label_description_msg.AutoSize = true;
            this.label_description_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description_msg.ForeColor = System.Drawing.Color.Red;
            this.label_description_msg.Location = new System.Drawing.Point(85, 279);
            this.label_description_msg.Name = "label_description_msg";
            this.label_description_msg.Size = new System.Drawing.Size(164, 13);
            this.label_description_msg.TabIndex = 55;
            this.label_description_msg.Text = "Please enter a project description";
            this.label_description_msg.Visible = false;
            // 
            // label_prtitle_msg
            // 
            this.label_prtitle_msg.AutoSize = true;
            this.label_prtitle_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prtitle_msg.ForeColor = System.Drawing.Color.Red;
            this.label_prtitle_msg.Location = new System.Drawing.Point(82, 117);
            this.label_prtitle_msg.Name = "label_prtitle_msg";
            this.label_prtitle_msg.Size = new System.Drawing.Size(129, 13);
            this.label_prtitle_msg.TabIndex = 54;
            this.label_prtitle_msg.Text = "Please enter a project title";
            this.label_prtitle_msg.Visible = false;
            // 
            // label_estcost_msg
            // 
            this.label_estcost_msg.AutoSize = true;
            this.label_estcost_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estcost_msg.ForeColor = System.Drawing.Color.Red;
            this.label_estcost_msg.Location = new System.Drawing.Point(82, 470);
            this.label_estcost_msg.Name = "label_estcost_msg";
            this.label_estcost_msg.Size = new System.Drawing.Size(144, 13);
            this.label_estcost_msg.TabIndex = 53;
            this.label_estcost_msg.Text = "Please enter a numeric value";
            this.label_estcost_msg.Visible = false;
            // 
            // cb_supervisor
            // 
            this.cb_supervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_supervisor.FormattingEnabled = true;
            this.cb_supervisor.Location = new System.Drawing.Point(333, 442);
            this.cb_supervisor.Name = "cb_supervisor";
            this.cb_supervisor.Size = new System.Drawing.Size(201, 26);
            this.cb_supervisor.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(331, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Supervisor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(331, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Date to Be Completed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(82, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Start Date";
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end_date.Location = new System.Drawing.Point(334, 517);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.Size = new System.Drawing.Size(200, 24);
            this.dtp_end_date.TabIndex = 48;
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.CustomFormat = "yyyy-MM-dd";
            this.dtp_start_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start_date.Location = new System.Drawing.Point(85, 517);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.Size = new System.Drawing.Size(201, 24);
            this.dtp_start_date.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(82, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Estimated Cost";
            // 
            // tb_estimated_cost
            // 
            this.tb_estimated_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estimated_cost.Location = new System.Drawing.Point(85, 442);
            this.tb_estimated_cost.Name = "tb_estimated_cost";
            this.tb_estimated_cost.Size = new System.Drawing.Size(201, 24);
            this.tb_estimated_cost.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(82, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Construction Site Address";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(85, 318);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_address.Size = new System.Drawing.Size(449, 80);
            this.tb_address.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(82, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Description";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(85, 154);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(449, 122);
            this.tb_description.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Project Title";
            // 
            // tb_title
            // 
            this.tb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.Location = new System.Drawing.Point(85, 90);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(449, 24);
            this.tb_title.TabIndex = 39;
            // 
            // Form_Update_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_supervisor_msg);
            this.Controls.Add(this.label_csaddress_msg);
            this.Controls.Add(this.label_date_msg);
            this.Controls.Add(this.label_description_msg);
            this.Controls.Add(this.label_prtitle_msg);
            this.Controls.Add(this.label_estcost_msg);
            this.Controls.Add(this.cb_supervisor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_end_date);
            this.Controls.Add(this.dtp_start_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_estimated_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Update_Site";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_New_Site";
            this.Load += new System.EventHandler(this.Form_Update_Site_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_supervisor_msg;
        private System.Windows.Forms.Label label_csaddress_msg;
        private System.Windows.Forms.Label label_date_msg;
        private System.Windows.Forms.Label label_description_msg;
        private System.Windows.Forms.Label label_prtitle_msg;
        private System.Windows.Forms.Label label_estcost_msg;
        private System.Windows.Forms.ComboBox cb_supervisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end_date;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_estimated_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_title;
    }
}