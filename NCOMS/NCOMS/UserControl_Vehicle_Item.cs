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
    public partial class UserControl_Vehicle_Item : UserControl
    {
        public UserControl_Vehicle_Item()
        {
            InitializeComponent();
        }

        #region Properties

        private int _vehicle_id;
        private string _date_of_purchase;
        private string _registration_number;
        private string _description;

        [Category("Vehicle Item")]
        public int VehicleId
        {
            get { return _vehicle_id; }
            set { _vehicle_id = value; label_vehicle_id.Text = value.ToString(); }
        }

        [Category("Vehicle Item")]
        public string DateOfPurchase
        {
            get { return _date_of_purchase; }
            set { _date_of_purchase = value; label_date_of_purchase.Text = value; }
        }

        [Category("Vehicle Item")]
        public string RegistrationNo
        {
            get { return _registration_number; }
            set { _registration_number = value; label_registration_number.Text = value; }
        }

        [Category("Vehicle Item")]
        public string Description
        {
            get { return _description; }
            set { _description = value; label_description.Text = value; }
        }

        #endregion

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.vehicle_id = _vehicle_id;
            vehicle.date_of_purchase = Convert.ToDateTime(_date_of_purchase);
            vehicle.description = _description;
            vehicle.reg_no = _registration_number;

            DataExchanger.vehicle = vehicle;

            Form_Update_Vehicle form_Update_Vehicle = new Form_Update_Vehicle();
            form_Update_Vehicle.Show();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure to delete this record?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(NCOMSEntities db = new NCOMSEntities())
                {
                    Vehicle vehicle = new Vehicle();

                    vehicle.vehicle_id = _vehicle_id;
                    vehicle.date_of_purchase = Convert.ToDateTime(_date_of_purchase);
                    vehicle.description = _description;
                    vehicle.reg_no = _registration_number;

                    var entry = db.Entry(vehicle);
                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Vehicles.Attach(vehicle);
                    }

                    db.Vehicles.Remove(vehicle);
                    db.SaveChanges();

                    if(Application.OpenForms["Form_ClerkMainWindow"] != null)
                    {
                        (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_nav_vehicle_Click(null, null);
                    }
                }
            }

        }
    }
}
