using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
{
    public partial class UserControl_Site_Item : UserControl
    {

        public UserControl_Site_Item()
        {
            InitializeComponent();
        }

        #region Properties

        private int _site_id;
        private string _title;
        private string _address;
        private string _description;
        private string _start_date;
        private string _end_date;
        private string _estimated_cost;
        private int _time_passed;

        [Category("Site Item")]
        public int SiteId
        {
            get { return _site_id; }
            set { _site_id = value; label_site_id.Text = value.ToString(); }
        }

        [Category("Site Item")]
        public string Title
        {
            get { return _title; }
            set { _title = value; label_title.Text = value; }
        }

        [Category("Site Item")]
        public string Address
        {
            get { return _address; }
            set { _address = value; label_address.Text = value; }
        }

        [Category("Site Item")]
        public string EstimatedCost
        {
            get { return _estimated_cost; }
            set { _estimated_cost = value; label_estimated_cost.Text = value; }
        }

        [Category("Site Item")]
        public string Description
        {
            get { return _description; }
            set { _description = value; label_description.Text = value; }
        }

        [Category("Site Item")]
        public string StartDate
        {
            get { return _start_date; }
            set { _start_date = value; label_start_date.Text = value; }
        }

        [Category("Site Item")]
        public string EndDate
        {
            get { return _end_date; }
            set { _end_date = value; label_end_date.Text = value; }
        }

        [Category("Site Item")]
        public int TimeLine
        {
            get { return _time_passed; }
            set { _time_passed = value; pb_time_line.Value = Convert.ToInt32( value ); }
        }

        #endregion

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Site site = new Site();

            site.site_id = _site_id;
            site.title = _title;
            site.address = _address;
            site.description = _description;
            site.estimated_cost = float.Parse(_estimated_cost.ToString());
            site.start_date = Convert.ToDateTime(_start_date);
            site.deadline = Convert.ToDateTime(_end_date);

            DataExchanger.site = site;

            Form_Update_Site form_Update_Site = new Form_Update_Site();
            form_Update_Site.Show();
        }

        private void Btn_more_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Delete This Record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using(NCOMSEntities db = new NCOMSEntities())
                {
                    Site site = new Site();

                    site.site_id = _site_id;
                    site.title = _title;
                    site.address = _address;
                    site.description = _description;
                    site.estimated_cost = float.Parse(_estimated_cost.ToString());
                    site.start_date = Convert.ToDateTime(_start_date);
                    site.deadline = Convert.ToDateTime(_end_date);

                    var entry = db.Entry(site);
                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Sites.Attach(site);
                    }

                    db.Sites.Remove(site);
                    db.SaveChanges();

                    if(Application.OpenForms["Form_ClerkMainWindow"] != null)
                    {
                        (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_menu_dashboard_Click(null, null);
                    }
                }
            }
        }
    }
}
