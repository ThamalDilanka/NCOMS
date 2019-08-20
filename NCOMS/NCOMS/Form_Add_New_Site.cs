using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
{
    public partial class Form_Add_New_Site : Form
    {
        Site site = new Site();

        public Form_Add_New_Site()
        {
            InitializeComponent();
            this.ActiveControl = tb_title;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            site.title = tb_title.Text.Trim();
            site.description = tb_description.Text.Trim();
            site.address = tb_address.Text.Trim();
            site.estimated_cost = float.Parse( tb_estimated_cost.Text.Trim());
            site.start_date = dtp_start_date.Value;
            site.deadline = dtp_end_date.Value;

            using (NCOMSEntities db = new NCOMSEntities())
            {
                db.Sites.Add(site);
                db.SaveChanges();
            }

            MessageBox.Show("Record added Successfully");
            this.Close();

            if (Application.OpenForms["Form_ClerkMainWindow"] != null)
            {
                (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_menu_dashboard_Click(null, null);
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tb_title_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.ActiveControl = tb_description;
                break;
            }
                
        }

        private void Tb_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Down)
            {
                this.ActiveControl = tb_address;
            }

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Up)
            {
                this.ActiveControl = tb_title;
            }
        }

        private void Tb_address_KeyDown(object sender, KeyEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Down)
            {
                this.ActiveControl = tb_estimated_cost;
            }

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Up)
            {
                this.ActiveControl = tb_description;
            }
        }

        private void Tb_estimated_cost_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.ActiveControl = dtp_start_date;
                    break;
                case Keys.Up:
                    this.ActiveControl = tb_address;
                    break;
            }
        }

        private void Dtp_start_date_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Down:
                    this.ActiveControl = dtp_end_date;
                    break;
                case Keys.Up:
                    this.ActiveControl = tb_estimated_cost;
                    break;
            }
        }

        private void Dtp_end_date_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Down:
                    Btn_save_Click(sender, e);
                    break;
                case Keys.Up:
                    this.ActiveControl = dtp_start_date;
                    break;
            }
        }

        // Adding a drop shadow to the form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = 0x00020000;
                return createParams;
            }
        }
    }
}
