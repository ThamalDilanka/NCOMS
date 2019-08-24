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
    public partial class Form_MMW_Staff : Form
    {
        public Form_MMW_Staff()
        {
            InitializeComponent();
        }

        //get a list of staff using this function
        private List<Staff> GetStaff()
        {
            using (NCOMSEntities db = new NCOMSEntities())
            {
                return db.Staffs.ToList<Staff>();
            }
        }

        //load the staff to the container in staff dashboard
        private void AddToTheContainer(List<Staff> staffList)
        {
            foreach(Staff staffMember in staffList)
            {
                UserControl_Staff_Item staffItem = new UserControl_Staff_Item();
                staffItem.StaffId = staffMember.staff_id;
                staffItem.StaffName = staffMember.first_name + " " + staffMember.last_name;
                staffItem.Dob = Convert.ToDateTime(staffMember.date_of_birth).ToString("yyyy-MM-dd");
                staffItem.Designation = staffMember.designation;
                staffItem.NIC = staffMember.nic;
                staffItem.JoinOn = Convert.ToDateTime(staffMember.join_on).ToString("yyyy-MM-dd");
                staffItem.Email = staffMember.email;
                staffItem.Address = staffMember.address;

                flp_staff_item_container.Controls.Add(staffItem);

            }
        }

        private void Form_MMW_Staff_Load(object sender, EventArgs e)
        {
            List<Staff> staffLiist = GetStaff();

            AddToTheContainer(staffLiist);
        }
    }
}
