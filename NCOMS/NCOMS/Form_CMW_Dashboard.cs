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
        List<String> siteTitles = new List<string>();
        AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

        public Form_CMW_Dashboard()
        {
            InitializeComponent();
        }

        public void Form_CMW_Dashboard_Load(object sender, EventArgs e)
        {
            List<Site> siteList = GetSites();
            AddToTheContainer(siteList);
            autoCompleteStringCollection.AddRange(siteTitles.ToArray());
            this.ActiveControl = tb_search;
        }

        private void AddToTheContainer(List<Site> siteList)
        {
            foreach (Site site in siteList)
            {
                UserControl_Site_Item siteItem = new UserControl_Site_Item();
                siteItem.SiteId = site.site_id;
                siteItem.Title = site.title;
                siteItem.Description = site.description;
                siteItem.Address = site.address;
                siteItem.StartDate = Convert.ToDateTime(site.start_date).ToString("yyyy-MM-dd");
                siteItem.EndDate = Convert.ToDateTime(site.deadline).ToString("yyyy-MM-dd");
                siteItem.EstimatedCost = site.estimated_cost.ToString();

                siteTitles.Add(site.title);

                int totalDays = Convert.ToDateTime(site.deadline).Subtract(Convert.ToDateTime(site.start_date)).Days;
                int pasedDays = Convert.ToDateTime(site.deadline).Subtract(DateTime.Today).Days;
                int percentage;

                if (pasedDays <= 0)
                    percentage = 100;
                else if (Convert.ToDateTime(site.start_date).Subtract(DateTime.Today).Days >= 0)
                    percentage = 0;
                else
                    percentage = 100 - (Convert.ToInt32(((pasedDays / (double)totalDays) * 100)));

                siteItem.TimeLine = percentage;

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

        private void Btn_search_Click(object sender, EventArgs e)
        {
            List<Site> wholeSiteList = GetSites();
            List<Site> matchedSiteList = new List<Site>();

            foreach(Site site in wholeSiteList)
            {
                if (site.title.ToString().Contains(tb_search.Text.ToString()) || site.title.ToString().ToLower().Contains(tb_search.Text.ToString()))
                {
                    matchedSiteList.Add(site);
                }
            }

            if(matchedSiteList.Count != 0)
            {
                flp_site_item_container.Controls.Clear();
                AddToTheContainer(matchedSiteList);
            }

            else
            {
                flp_site_item_container.Controls.Clear();
                UserControl_Container_Message uc_message_box = new UserControl_Container_Message();
                uc_message_box.Margin = new Padding(0, 250, 0, 0);
                uc_message_box.Message = "Sorry! System Could't Find Any Search Result Matching";
                uc_message_box.KeyWord = String.Concat("\"", tb_search.Text.ToString(), "\"");
                flp_site_item_container.Controls.Add(uc_message_box);
                uc_message_box.Visible = true;
            }
        }

        private void Tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_Click(sender, e);
            }
        }

        private void Tb_search_TextChanged(object sender, EventArgs e)
        {
            tb_search.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
    }
}
