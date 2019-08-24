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
    public partial class UserControl_Tool_Item : UserControl
    {
        public UserControl_Tool_Item()
        {
            InitializeComponent();
        }
        #region Properties
        private int _tool_id;
        private string _tool_name;
        private string _date_of_purchase;
        private string _tool_price;
        private string _tool_condition;

        [Category("Tool Item")]
        public int ToolId
        {
            get { return _tool_id; }
            set { _tool_id = value; label_tool_id.Text = value.ToString(); }
        }

        [Category("Tool Item")]
        public string ToolName
        {
            get { return _tool_name; }
            set { _tool_name = value; label_tool_name.Text =value ; }
        }

        [Category("Tool Item")]
        public string DateOfPurchase
        {
            get { return _date_of_purchase; }
            set { _date_of_purchase = value; label_date_of_purchase.Text = value ; }
        }

        [Category("Tool Item")]
        public string ToolPrice
        {
            get { return _tool_price; }
            set { _tool_price = value; label_tool_price.Text = value ; }
        }

        [Category("Tool Item")]
        public string ToolCondition
        {
            get { return _tool_condition; }
            set { _tool_condition = value; label_tool_condition.Text = value ; }
        }





        #endregion

        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
