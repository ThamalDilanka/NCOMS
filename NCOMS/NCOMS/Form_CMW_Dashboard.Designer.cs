namespace NCOMS
{
    partial class Form_CMW_Dashboard
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
            this.flp_site_item_container = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_site_item_container
            // 
            this.flp_site_item_container.AutoScroll = true;
            this.flp_site_item_container.Location = new System.Drawing.Point(29, 79);
            this.flp_site_item_container.Margin = new System.Windows.Forms.Padding(4);
            this.flp_site_item_container.Name = "flp_site_item_container";
            this.flp_site_item_container.Size = new System.Drawing.Size(1461, 756);
            this.flp_site_item_container.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(1015, 21);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(341, 30);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.Tb_search_TextChanged);
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_search_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1365, 21);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 34);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Construction Sites";
            // 
            // btn_add_new
            // 
            this.btn_add_new.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new.ForeColor = System.Drawing.Color.DimGray;
            this.btn_add_new.Location = new System.Drawing.Point(259, 21);
            this.btn_add_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(100, 32);
            this.btn_add_new.TabIndex = 4;
            this.btn_add_new.Text = "Add New";
            this.btn_add_new.UseVisualStyleBackColor = false;
            this.btn_add_new.Click += new System.EventHandler(this.Btn_add_new_Click);
            // 
            // Form_CMW_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1507, 849);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.flp_site_item_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CMW_Dashboard";
            this.Text = "Form_CMW_Dashboard";
            this.Load += new System.EventHandler(this.Form_CMW_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_site_item_container;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_new;
    }
}