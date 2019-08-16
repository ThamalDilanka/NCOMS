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
        Site site = new Site();

        public Form_Update_Site()
        {
            InitializeComponent();
        }

        private void Form_Update_Site_Load(object sender, EventArgs e)
        {
            tb_title.Text = DataExchanger.site.title;
            tb_description.Text = DataExchanger.site.description;
            tb_address.Text = DataExchanger.site.address;
            tb_estimated_cost.Text = DataExchanger.site.estimated_cost.ToString();
            dtp_start_date.Value = Convert.ToDateTime(DataExchanger.site.start_date);
            dtp_end_date.Value = Convert.ToDateTime(DataExchanger.site.deadline);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            site.site_id = DataExchanger.site.site_id;
            site.title = tb_title.Text.Trim();
            site.address = tb_address.Text.Trim();
            site.description = tb_description.Text.Trim();
            site.estimated_cost = float.Parse(tb_estimated_cost.Text.Trim());
            site.start_date = dtp_start_date.Value;
            site.deadline = dtp_end_date.Value;

            using(NCOMSEntities db = new NCOMSEntities())
            {
                db.Entry(site).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show("Record Updated");
            this.Close();

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
