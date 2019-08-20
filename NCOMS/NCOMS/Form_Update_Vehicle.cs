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
    public partial class Form_Update_Vehicle : Form
    {
        Vehicle vehicle = new Vehicle();

        public Form_Update_Vehicle()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Update_Vehicle_Load(object sender, EventArgs e)
        {
            tb_registration_no.Text = DataExchanger.vehicle.reg_no;
            tb_description.Text = DataExchanger.vehicle.description;
            dtp_date_of_purchase.Value = Convert.ToDateTime(DataExchanger.vehicle.date_of_purchase);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            vehicle.vehicle_id = DataExchanger.vehicle.vehicle_id;
            vehicle.reg_no = tb_registration_no.Text.Trim();
            vehicle.description = tb_description.Text.Trim();
            vehicle.date_of_purchase = dtp_date_of_purchase.Value;

            using(NCOMSEntities db = new NCOMSEntities())
            {
                db.Entry(vehicle).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show("Record Updated");
            this.Close();

            if (Application.OpenForms["Form_ClerkMainWindow"] != null)
            {
                (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_menu_vehicle_Click(null, null);
            }
        }

        // Adding a drop shadow to the form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = 0x00020000;
                return createParams;
            }
        }
    }
}
