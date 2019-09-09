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
    public partial class Form_CMW_MoneyRequests : Form
    {

        public Form_CMW_MoneyRequests()
        {
            InitializeComponent();
        }

        private void AddToTheContainer(List<Money_Request> moneyRequestList)
        {
            foreach (Money_Request moneyRequest in moneyRequestList)
            {
                UserControl_MoneyRequest_Item_D1 moneyRequestItem = new UserControl_MoneyRequest_Item_D1();

                using (NCOMSEntities db = new NCOMSEntities())
                {
                    moneyRequestItem.SiteTitle = db.Sites.Where(m => m.site_id == moneyRequest.site_id).FirstOrDefault().title.ToString();
                    Staff_Allocated_Site staff_Allocated_Site = db.Staff_Allocated_Site.Where(m => m.site_id == moneyRequest.site_id).FirstOrDefault();
                    Staff supervisor = db.Staffs.Where(m => m.staff_id == staff_Allocated_Site.staff_id).FirstOrDefault();
                    moneyRequestItem.SupervisorName = supervisor.first_name + " " + supervisor.last_name;
                }

                moneyRequestItem.SiteId = moneyRequest.site_id;
                moneyRequestItem.Amount = float.Parse(moneyRequest.amount.ToString());
                moneyRequestItem.RequestedDate = Convert.ToDateTime(moneyRequest.requested_on).ToString("yyyy-MM-dd");
                moneyRequestItem.RequestedTime = moneyRequest.requested_at.ToString();
                moneyRequestItem.Description = moneyRequest.description;
                moneyRequestItem.MoneyRequestId = moneyRequest.request_id;

                flp_money_request_item_container.Controls.Add(moneyRequestItem);
            }
        }

        private List<Money_Request> GetMoneyRequests()
        {
            using (NCOMSEntities db = new NCOMSEntities())
            {
                return db.Money_Request.ToList<Money_Request>();
            }
        }

        private void Form_CMW_MoneyRequests_Load(object sender, EventArgs e)
        {
            AddToTheContainer(GetMoneyRequests());
        }
    }
}
