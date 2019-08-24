namespace NCOMS
{
    partial class UserControl_Tool_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Tool_Item));
            this.label_tool_id = new System.Windows.Forms.Label();
            this.label_date_of_purchase = new System.Windows.Forms.Label();
            this.label_tool_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label_tool_price = new System.Windows.Forms.Label();
            this.label_tool_condition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_tool_id
            // 
            this.label_tool_id.AutoSize = true;
            this.label_tool_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tool_id.Location = new System.Drawing.Point(35, 12);
            this.label_tool_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tool_id.Name = "label_tool_id";
            this.label_tool_id.Size = new System.Drawing.Size(50, 24);
            this.label_tool_id.TabIndex = 6;
            this.label_tool_id.Text = "1000";
            // 
            // label_date_of_purchase
            // 
            this.label_date_of_purchase.AutoSize = true;
            this.label_date_of_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_of_purchase.Location = new System.Drawing.Point(421, 12);
            this.label_date_of_purchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date_of_purchase.Name = "label_date_of_purchase";
            this.label_date_of_purchase.Size = new System.Drawing.Size(100, 24);
            this.label_date_of_purchase.TabIndex = 7;
            this.label_date_of_purchase.Text = "2016.05.22";
            // 
            // label_tool_name
            // 
            this.label_tool_name.AutoSize = true;
            this.label_tool_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tool_name.Location = new System.Drawing.Point(187, 12);
            this.label_tool_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tool_name.Name = "label_tool_name";
            this.label_tool_name.Size = new System.Drawing.Size(92, 24);
            this.label_tool_name.TabIndex = 8;
            this.label_tool_name.Text = "Hand Drill";
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(1409, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(49, 41);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(1347, 4);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(49, 41);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // label_tool_price
            // 
            this.label_tool_price.AutoSize = true;
            this.label_tool_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tool_price.Location = new System.Drawing.Point(708, 12);
            this.label_tool_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tool_price.Name = "label_tool_price";
            this.label_tool_price.Size = new System.Drawing.Size(77, 24);
            this.label_tool_price.TabIndex = 12;
            this.label_tool_price.Text = "Rs.7000";
            // 
            // label_tool_condition
            // 
            this.label_tool_condition.AutoSize = true;
            this.label_tool_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tool_condition.Location = new System.Drawing.Point(1008, 12);
            this.label_tool_condition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tool_condition.Name = "label_tool_condition";
            this.label_tool_condition.Size = new System.Drawing.Size(74, 24);
            this.label_tool_condition.TabIndex = 13;
            this.label_tool_condition.Text = "Optimal";
            // 
            // UserControl_Tool_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_tool_condition);
            this.Controls.Add(this.label_tool_price);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label_tool_name);
            this.Controls.Add(this.label_date_of_purchase);
            this.Controls.Add(this.label_tool_id);
            this.Name = "UserControl_Tool_Item";
            this.Size = new System.Drawing.Size(1461, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tool_id;
        private System.Windows.Forms.Label label_date_of_purchase;
        private System.Windows.Forms.Label label_tool_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label_tool_price;
        private System.Windows.Forms.Label label_tool_condition;
    }
}
