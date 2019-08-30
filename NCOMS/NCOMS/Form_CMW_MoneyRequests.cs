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
                   
                }
            }
        }

        private List<Money_Request> GetMoneyRequests()
        {
            using (NCOMSEntities db = new NCOMSEntities())
            {
                return db.Money_Request.ToList<Money_Request>();
            }
        }
    }
}
