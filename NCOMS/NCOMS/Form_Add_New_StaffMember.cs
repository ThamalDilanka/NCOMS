using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
{
    public partial class Form_Add_New_StaffMember : Form
    {
        #region Form Shadow

        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }

        #endregion

        const String level1 = "Manager";
        const String level2 = "Supervisor";
        const String level3 = "Clerk";
        const String level4 = "StoreKeeper";

        const String desig1 = "Manager";
        const String desig2 = "Supervisor";
        const String desig3 = "Clerk";
        const String desig4 = "Store Keeper";

        Staff staffMember = new Staff();
        Staff_Mobile mobileOne;
        Staff_Mobile mobileTwo;

        String fileName;


        public Form_Add_New_StaffMember()
        {
            InitializeComponent();

            string[] designationList = { desig1, desig2, desig3, desig4 };
            cb_designation.Items.Add("-- Select --");
            cb_designation.Items.AddRange(designationList);
            cb_designation.SelectedIndex = 0;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Btn_save_Click(object sender, EventArgs e)
        {
            staffMember.first_name = tb_firstName.Text.Trim();
            staffMember.last_name = tb_lastName.Text.Trim();
            staffMember.nic = tb_nicNumber.Text.Trim();
            staffMember.email = tb_email.Text.Trim();
            staffMember.address = tb_address.Text.Trim();
            staffMember.date_of_birth = dtp_dateOfBirth.Value;
            staffMember.join_on = dtp_joinOn.Value;
            staffMember.user_name = tb_userName.Text.Trim();
            staffMember.password = tb_tempPasword.Text.Trim();

            if (rb_female.Checked)
                staffMember.gender = "F";
            else if (rb_male.Checked)
                staffMember.gender = "M";

            staffMember.designation = cb_designation.Text.ToString();

            switch (cb_designation.Text.ToString())
            {
                case desig1:
                    staffMember.user_level = level1;
                    break;
                case desig2:
                    staffMember.user_level = level2;
                    break;
                case desig3:
                    staffMember.user_level = level3;
                    break;
                case desig4:
                    staffMember.user_level = level4;
                    break;
            }

            staffMember.profile_picture = ConvertImageToBinary(pb_profile.Image);

            using (NCOMSEntities db = new NCOMSEntities())
            {
                db.Staffs.Add(staffMember);
                await db.SaveChangesAsync();
            }

            // adding multivalued mobile number

            using(NCOMSEntities db = new NCOMSEntities())
            {
                Staff insertedStaffMember = db.Staffs.Where(s => s.first_name == tb_firstName.Text.Trim() && s.last_name == tb_lastName.Text.Trim()).FirstOrDefault();

                if (tb_mobile_one.Text.ToString().Length != 0)
                {
                    mobileOne = new Staff_Mobile();
                    mobileOne.staff_id = insertedStaffMember.staff_id;
                    mobileOne.mobile = tb_mobile_one.Text.Trim();
                }

                if (tb_mobile_two.Text.ToString().Length != 0)
                {
                    mobileTwo = new Staff_Mobile();
                    mobileTwo.staff_id = insertedStaffMember.staff_id;
                    mobileTwo.mobile = tb_mobile_two.Text.Trim();
                }

                db.Staff_Mobile.Add(mobileOne);
                db.Staff_Mobile.Add(mobileTwo);
                db.SaveChanges();
            }

            MessageBox.Show("Record Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_chooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    pb_profile.Image = Image.FromFile(fileName);
                }
            }
        }

        private byte[] ConvertImageToBinary(Image image)
        {
            using(MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }
    }
}
