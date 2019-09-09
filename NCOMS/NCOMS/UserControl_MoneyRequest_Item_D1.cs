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
    public partial class UserControl_MoneyRequest_Item_D1 : UserControl
    {
        public UserControl_MoneyRequest_Item_D1()
        {
            InitializeComponent();
        }

        #region Properties

        private int _siteId;
        private float _amount;
        private string _siteTitle;
        private string _supervisorName;
        private string _requestedDate;
        private string _requestedTime;
        private string _description;
        private string _status;
        private int _moneyRequestId;

        [Category("MoneyRequest Item")]
        public int SiteId
        {
            get { return _siteId; }
            set { _siteId = value; label_site_id.Text = value.ToString(); }
        }

        [Category("MoneyRequest Item")]
        public int MoneyRequestId
        {
            get { return _moneyRequestId; }
            set { _moneyRequestId = value; }
        }

        [Category("MoneyRequest Item")]
        public float Amount
        {
            get { return _amount; }
            set { _amount = value; label_amount.Text = "Rs. " + value.ToString(); }
        }

        [Category("MoneyRequest Item")]
        public string SiteTitle
        {
            get { return _siteTitle; }
            set { _siteTitle = value; label_title.Text = value; }
        }

        [Category("MoneyRequest Item")]
        public string SupervisorName
        {
            get { return _supervisorName; }
            set { _supervisorName = value; label_supervisor.Text = value; }
        }

        [Category("MoneyRequest Item")]
        public string RequestedDate
        {
            get { return _requestedDate; }
            set { _requestedDate = value; label_requested_date.Text = value; }
        }

        [Category("MoneyRequest Item")]
        public string RequestedTime
        {
            get { return _requestedTime; }
            set { _requestedTime = value; label_requested_time.Text = value; }
        }

        [Category("MoneyRequest Item")]
        public string Description
        {
            get { return _description; }
            set { _description = value; label_description.Text = value; }
        }

        [Category("MoneyRequest Item")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion


    }
}
