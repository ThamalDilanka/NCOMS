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
    public partial class Form_CMW_Vehicle : Form
    {
        Vehicle vehicle = new Vehicle();

        public Form_CMW_Vehicle()
        {
            InitializeComponent();
        }

        private void Form_CMW_Vehicle_Load(object sender, EventArgs e)
        {
            List<Vehicle> vehicles = GetVehicles();
            foreach(Vehicle vehicle in vehicles)
            {
                UserControl_Vehicle_Item vehicleItem = new UserControl_Vehicle_Item();
                vehicleItem.VehicleId = vehicle.vehicle_id;
                vehicleItem.DateOfPurchase = Convert.ToDateTime(vehicle.date_of_purchase).ToString("yyyy-MM-dd");
                vehicleItem.RegistrationNo = vehicle.reg_no.ToString();
                vehicleItem.Description = vehicle.description.ToString();
                flp_vehicle_table.Controls.Add(vehicleItem);
            }
            
        }

        private List<Vehicle> GetVehicles()
        {
            using(NCOMSEntities db = new NCOMSEntities())
            {
                List<Vehicle> vehicleList = db.Vehicles.ToList<Vehicle>();
                return vehicleList;
            }
        }

        private void Btn_add_new_Click(object sender, EventArgs e)
        {
            Form_Add_New_Vehicle form_Add_New_Vehicle = new Form_Add_New_Vehicle();
            form_Add_New_Vehicle.Show();
        }
    }
}
