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
    public partial class Form_Add_New_Vehicle : Form
    {
        Vehicle vehicle = new Vehicle();

        public Form_Add_New_Vehicle()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            vehicle.reg_no = tb_registration_no.Text.Trim();
            vehicle.date_of_purchase = dtp_date_of_purchase.Value;
            vehicle.description = tb_description.Text.Trim();

            using(NCOMSEntities db = new NCOMSEntities())
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }

            MessageBox.Show("Record Added Successfully");
            this.Close();

            if (Application.OpenForms["Form_ClerkMainWindow"] != null)
            {
                (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_menu_vehicle_Click(null, null);
            }
        }
    }
}
