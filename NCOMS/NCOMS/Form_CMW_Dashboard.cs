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
    public partial class Form_CMW_Dashboard : Form
    {
        Site site = new Site();
        public Form_CMW_Dashboard()
        {
            InitializeComponent();
        }

        private void Form_CMW_Dashboard_Load(object sender, EventArgs e)
        {
            List<Site> siteList = GetSites();
            foreach(Site site in siteList)
            {
                UserControl_Site_Item siteItem = new UserControl_Site_Item();
                siteItem.Title = site.title;
                flp_site_item_container.Controls.Add(siteItem);
            }
        }

        private List<Site> GetSites()
        {
            using(NCOMSEntities db = new NCOMSEntities())
            {
                List<Site> siteList = db.Sites.ToList<Site>();
                return siteList;
            }
        }

        private void Btn_add_new_Click(object sender, EventArgs e)
        {
            Form_Add_New_Site form_Add_New_Site = new Form_Add_New_Site();
            form_Add_New_Site.Show();
        }
    }
}
