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
    public partial class UserControl_Staff_Item : UserControl
    {
       
        public UserControl_Staff_Item()
        {
            InitializeComponent();
        }

        #region Properties 
        private int _staff_id;
        private string _name;
        private string _dob;
        private string _gender;
        private string _designation;
        private string _nic;
        private string _joinOn;
        private string _email;
        private string _address;


        [Category("Staff Item")]
        public int StaffId
        {
            get { return _staff_id; }
            set { _staff_id = value; label_staff_id.Text = value.ToString(); }
        }


        [Category("Staff Item")]
        public string StaffName
        {
            get { return _name; }
            set { _name = value; lable_name.Text = value; }
        }

        [Category("Staff Item")]
        public string Dob
        {
            get { return _dob; }
            set { _dob  = value; lable_dob.Text = value; }
        }


        [Category("Staff Item")]
        public string Gender
        {
            get { return _gender; }
            set { _gender  = value; label_gender.Text  = value; }
        }

        [Category("Staff Item")]
        public string Designation
        {
            get { return _designation; }
            set { _designation  = value; label_designation.Text = value; }
        }

        [Category("Staff Item")]
        public string NIC
        {
            get { return _nic; }
            set { _nic  = value; label_nic.Text = value; }
        }

        [Category("Staff Item")]
        public string JoinOn
        {
            get { return _joinOn; }
            set { _joinOn  = value; label_join_on.Text = value; }
        }

        [Category("Staff Item")]
        public string Email
        {
            get { return _email; }
            set { _email  = value; label_email.Text = value; }
        }

        [Category("Staff Item")]
        public string Address
        {
            get { return _address; }
            set { _address  = value; label_address.Text = value; }
        }
        #endregion

    }
}
