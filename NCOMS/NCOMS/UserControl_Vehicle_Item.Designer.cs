﻿namespace NCOMS
{
    partial class UserControl_Vehicle_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Vehicle_Item));
            this.label_vehicle_id = new System.Windows.Forms.Label();
            this.label_date_of_purchase = new System.Windows.Forms.Label();
            this.label_registration_number = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_vehicle_id
            // 
            this.label_vehicle_id.AutoSize = true;
            this.label_vehicle_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vehicle_id.Location = new System.Drawing.Point(23, 22);
            this.label_vehicle_id.Name = "label_vehicle_id";
            this.label_vehicle_id.Size = new System.Drawing.Size(40, 18);
            this.label_vehicle_id.TabIndex = 0;
            this.label_vehicle_id.Text = "1000";
            // 
            // label_date_of_purchase
            // 
            this.label_date_of_purchase.AutoSize = true;
            this.label_date_of_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_of_purchase.Location = new System.Drawing.Point(69, 22);
            this.label_date_of_purchase.Name = "label_date_of_purchase";
            this.label_date_of_purchase.Size = new System.Drawing.Size(80, 18);
            this.label_date_of_purchase.TabIndex = 1;
            this.label_date_of_purchase.Text = "2016.05.22";
            // 
            // label_registration_number
            // 
            this.label_registration_number.AutoSize = true;
            this.label_registration_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registration_number.Location = new System.Drawing.Point(155, 22);
            this.label_registration_number.Name = "label_registration_number";
            this.label_registration_number.Size = new System.Drawing.Size(66, 18);
            this.label_registration_number.TabIndex = 2;
            this.label_registration_number.Text = "NC 4733";
            // 
            // label_description
            // 
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(239, 11);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(746, 40);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "Text messaging, or texting, is the act of composing and sending electronic messag" +
    "es, typically consisting of alphabetic and numeric characters, between two or mo" +
    "re users of mobile devices";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(1054, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(37, 33);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(1007, 15);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(37, 33);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // UserControl_Vehicle_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_registration_number);
            this.Controls.Add(this.label_date_of_purchase);
            this.Controls.Add(this.label_vehicle_id);
            this.Name = "UserControl_Vehicle_Item";
            this.Size = new System.Drawing.Size(1120, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_vehicle_id;
        private System.Windows.Forms.Label label_date_of_purchase;
        private System.Windows.Forms.Label label_registration_number;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}
