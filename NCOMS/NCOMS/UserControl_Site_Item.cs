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

        private string _title;
        private string _address;
        private string _description;
        private string _start_date;
        private string _end_date;
        private double _estimated_cost;
        private int _time_passed;

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
        public double EstimatedCost
        {
            get { return _estimated_cost; }
            set { _estimated_cost = value; label_estimated_cost.Text = value.ToString(); }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
