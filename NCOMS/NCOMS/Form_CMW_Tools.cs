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
    public partial class Form_CMW_Tools : Form
    {
        public Form_CMW_Tools()
        {
            InitializeComponent();
        }

        private List<Tool> GetTools()
        {
            using (NCOMSEntities db = new NCOMSEntities())
            {
                return db.Tools.ToList<Tool>();
            }
        }

        private void AddToTheContainer(List<Tool> toolList)
        {
            foreach(Tool tool in toolList)
            {
                UserControl_Tool_Item tool_Item = new UserControl_Tool_Item();
                tool_Item.ToolId = tool.tool_id;
                tool_Item.ToolName = tool.name;
                tool_Item.DateOfPurchase = Convert.ToDateTime(tool.date_of_purchase).ToString("yyyy-MM-dd");
                tool_Item.ToolPrice = tool.price.ToString();
                tool_Item.ToolCondition = tool.condition;

                flp_tool_item_container.Controls.Add(tool_Item);
            }
        }

        private void Form_CMW_Tools_Load(object sender, EventArgs e)
        {
            List<Tool> toolList = GetTools();
            AddToTheContainer(toolList);

        }
    }
}
