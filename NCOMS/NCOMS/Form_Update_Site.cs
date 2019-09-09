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
    public partial class Form_Update_Site : Form
    {
        private Site site = new Site();
        private Staff supervisor = new Staff();
        private Staff_Allocated_Site staff_Allocated_Site = new Staff_Allocated_Site();
        List<Staff> supervisorList = new List<Staff>();

        public Form_Update_Site()
        {
            InitializeComponent();
            this.ActiveControl = tb_title;

            // Get supervisor list from the database
            using (NCOMSEntities db = new NCOMSEntities())
            {
                supervisorList = db.Staffs.Where(s => s.user_level == "Supervisor").ToList<Staff>();
            }

            // Add Supervisor's names to combo box
            foreach (Staff staff in supervisorList)
            {
                cb_supervisor.Items.Add(staff.first_name + " " + staff.last_name);
            }

            cb_supervisor.SelectedIndex = 0;
        }

        // Setting values to the user controllers when form loading
        private void Form_Update_Site_Load(object sender, EventArgs e)
        {
            tb_title.Text = DataExchanger.site.title;
            tb_description.Text = DataExchanger.site.description;
            tb_address.Text = DataExchanger.site.address;
            tb_estimated_cost.Text = DataExchanger.site.estimated_cost.ToString();
            dtp_start_date.Value = Convert.ToDateTime(DataExchanger.site.start_date);
            dtp_end_date.Value = Convert.ToDateTime(DataExchanger.site.deadline);

            using(NCOMSEntities db = new NCOMSEntities())
            {
                supervisor = db.Staffs.Where(s => s.staff_id == DataExchanger.staff_Allocated_Site.staff_id).FirstOrDefault();
                cb_supervisor.SelectedItem = supervisor.first_name + " " + supervisor.last_name;
            }
        }

        // Update the selected entry
        private void Btn_update_Click(object sender, EventArgs e)
        {
            site.site_id = DataExchanger.site.site_id;
            site.title = tb_title.Text.Trim();
            site.address = tb_address.Text.Trim();
            site.description = tb_description.Text.Trim();
            site.estimated_cost = float.Parse(tb_estimated_cost.Text.Trim());
            site.start_date = dtp_start_date.Value;
            site.deadline = dtp_end_date.Value;

            using (NCOMSEntities db = new NCOMSEntities())
            {
                string firstName = cb_supervisor.Text.ToString().Substring(0, cb_supervisor.Text.ToString().IndexOf(" "));
                Staff selectedSupervisor = db.Staffs.Where(s => s.first_name == firstName).FirstOrDefault();
                staff_Allocated_Site.staff_id = selectedSupervisor.staff_id;
                staff_Allocated_Site.site_id = DataExchanger.site.site_id;
                staff_Allocated_Site.staff_allocated_site_id = DataExchanger.staff_Allocated_Site.staff_allocated_site_id;
                staff_Allocated_Site.started_date = DateTime.Now;
                staff_Allocated_Site.end_date = DataExchanger.staff_Allocated_Site.end_date;

                db.Entry(staff_Allocated_Site).State = System.Data.Entity.EntityState.Modified;
                db.Entry(site).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show(String.Concat(site.title, " Record Updated"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            if (Application.OpenForms["Form_ClerkMainWindow"] != null)
            {
                (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_nav_dashboard_Click(null, null);
            }

        }

        // Close the form
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #region Navigate between User Controls using arrow keys

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
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Down)
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
                    Btn_update_Click(sender, e);
                    break;
                case Keys.Down:
                    this.ActiveControl = btn_update;
                    break;

                case Keys.Up:
                    this.ActiveControl = dtp_start_date;
                    break;
            }
        }

        #endregion

        // Clear all user controls
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            tb_title.Text = "";
            tb_description.Text = "";
            tb_address.Text = "";
            tb_estimated_cost.Text = "";
            dtp_start_date.Value = DateTime.Today;
            dtp_end_date.Value = DateTime.Today;
        }

    }
}
