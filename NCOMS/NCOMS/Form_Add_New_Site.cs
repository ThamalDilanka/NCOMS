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
    }
}
