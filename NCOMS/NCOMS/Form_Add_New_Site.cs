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
    public partial class Form_Add_New_Site : Form
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

        List<Staff> supervisorList = new List<Staff>();
        Site site = new Site();
        Staff_Allocated_Site staff_Allocated_Site = new Staff_Allocated_Site();

        public Form_Add_New_Site()
        {
            InitializeComponent();
            this.ActiveControl = tb_title;

            // Get supervisor list from the database
            using(NCOMSEntities db = new NCOMSEntities())
            {
                supervisorList = db.Staffs.Where(s => s.user_level == "Supervisor").ToList<Staff>();
            }

            // Add Supervisor's names to combo box
            cb_supervisor.Items.Add("-- Select --");
            foreach (Staff staff in supervisorList)
            {
                cb_supervisor.Items.Add(staff.first_name + " " + staff.last_name);
            }
            cb_supervisor.SelectedIndex = 0;
        }

        // Create a entry in database
        private void Btn_save_Click(object sender, EventArgs e)
        {
            site.title = tb_title.Text.Trim();
            site.description = tb_description.Text.Trim();
            site.address = tb_address.Text.Trim();
            site.estimated_cost = float.Parse( tb_estimated_cost.Text.Trim());
            site.start_date = dtp_start_date.Value;
            site.deadline = dtp_end_date.Value;

            using (NCOMSEntities db = new NCOMSEntities())
            {
                db.Sites.Add(site);
                db.SaveChanges();
            }

            // Inserting supervisor record to staff_allocated_site table
            using (NCOMSEntities db = new NCOMSEntities())
            {
                string firstName = cb_supervisor.Text.ToString().Substring(0, cb_supervisor.Text.ToString().IndexOf(" "));
                Staff selectedSupervisor = db.Staffs.Where(s => s.first_name == firstName).FirstOrDefault();
                staff_Allocated_Site.staff_id = selectedSupervisor.staff_id;

                Site insertedSite = db.Sites.Where(s => s.title == tb_title.Text).FirstOrDefault();
                staff_Allocated_Site.site_id = insertedSite.site_id;
                staff_Allocated_Site.started_date = DateTime.Now;
                staff_Allocated_Site.end_date = insertedSite.deadline;

                db.Staff_Allocated_Site.Add(staff_Allocated_Site);
                db.SaveChanges();
            }

            this.Close();

            // reload the container
            if (Application.OpenForms["Form_ClerkMainWindow"] != null)
            {
                (Application.OpenForms["Form_ClerkMainWindow"] as Form_ClerkMainWindow).Btn_nav_dashboard_Click(null, null);
            }
        }

        // Close the form
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Navigate between User Controls using arrow keys

        private void Tb_title_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.ActiveControl = tb_description;
                    break;
            }

        }

        private void Tb_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Down)
            {
                this.ActiveControl = tb_address;
            }

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Up)
            {
                this.ActiveControl = tb_title;
            }
        }

        private void Tb_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Down)
            {
                this.ActiveControl = tb_estimated_cost;
            }

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Up)
            {
                this.ActiveControl = tb_description;
            }
        }

        private void Tb_estimated_cost_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.ActiveControl = cb_supervisor;
                    break;
                case Keys.Up:
                    this.ActiveControl = tb_address;
                    break;
            }
        }

        private void Cb_supervisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Left)
            {
                this.ActiveControl = dtp_start_date;
            }

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Right)
            {
                this.ActiveControl = tb_estimated_cost;
            }
        }

        private void Dtp_start_date_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Down:
                    this.ActiveControl = dtp_end_date;
                    break;
                case Keys.Up:
                    this.ActiveControl = cb_supervisor;
                    break;
            }
        }

        private void Dtp_end_date_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Btn_save_Click(sender, e);
                    break;
                case Keys.Down:
                    this.ActiveControl = btn_save;
                    break;
                case Keys.Up:
                    this.ActiveControl = dtp_start_date;
                    break;
            }
        }

        #endregion

        // Clear all user controls
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            // setting default values to user controllers
            tb_title.Text = "";
            tb_description.Text = "";
            tb_address.Text = "";
            tb_estimated_cost.Text = "";
            dtp_start_date.Value = DateTime.Today;
            dtp_end_date.Value = DateTime.Today;
            cb_supervisor.SelectedIndex = 0;

            // hide validation messages
            label_prtitle_msg.Visible = false;
            label_description_msg.Visible = false;
            label_csaddress_msg.Visible = false;
            label_estcost_msg.Visible = false;
            label_supervisor_msg.Visible = false;
            label_date_msg.Visible = false;

            this.ActiveControl = tb_title;

        }


        #region Form Validation

        private bool IsValidated()
        {
            if(tb_title.Text.Length != 0 && tb_description.Text.Length != 0 
                && tb_address.Text.Length != 0 && tb_estimated_cost.Text.Length != 0
                && cb_supervisor.SelectedIndex != 0 && DateTime.Compare(dtp_start_date.Value, dtp_end_date.Value) <= 0)
            {
                try
                {
                    float.Parse(tb_estimated_cost.Text);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        private void SetSaveButton()
        {
            if (IsValidated())
                btn_save.Enabled = true;
            else
                btn_save.Enabled = false;
        }

        private void Tb_estimated_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(tb_estimated_cost.Text);
                label_estcost_msg.Visible = false;
            }

            catch (Exception)
            {
                label_estcost_msg.Visible = true;
            }

            SetSaveButton();
        }

        private void Tb_title_Leave(object sender, EventArgs e)
        {
            if (tb_title.Text.Length <= 0)
            {
                label_prtitle_msg.Visible = true;
            }

            else
            {
                label_prtitle_msg.Visible = false;
            }

            SetSaveButton();
        }

        private void Tb_title_TextChanged(object sender, EventArgs e)
        {
            label_prtitle_msg.Visible = false;
            SetSaveButton();
        }

        private void Tb_description_Leave(object sender, EventArgs e)
        {
            if (tb_description.Text.Length <= 0)
            {
                label_description_msg.Visible = true;
            }

            else
            {
                label_description_msg.Visible = false;
            }

            SetSaveButton();
        }

        private void Tb_address_Leave(object sender, EventArgs e)
        {
            if (tb_address.Text.Length <= 0)
            {
                label_csaddress_msg.Visible = true;
            }

            else
            {
                label_csaddress_msg.Visible = false;
            }

            SetSaveButton();
        }

        private void Dtp_end_date_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtp_start_date.Value, dtp_end_date.Value) >= 0)
            {
                label_date_msg.Visible = true;
            }

            else
            {
                label_date_msg.Visible = false;
            }

            SetSaveButton();
        }

        private void Tb_estimated_cost_Leave(object sender, EventArgs e)
        {
            if (tb_estimated_cost.Text.Length <= 0)
            {
                label_estcost_msg.Text = "Please enter the estimated cost";
                label_estcost_msg.Visible = true;
            }

            else
            {
                label_estcost_msg.Text = "Please enter a numeric value";
                Tb_estimated_cost_TextChanged(sender, e);
            }

            SetSaveButton();
        }

        private void Cb_supervisor_Leave(object sender, EventArgs e)
        {
            if(cb_supervisor.Text == "-- Select --")
            {
                label_supervisor_msg.Visible = true;
            }
            else
            {
                label_supervisor_msg.Visible = false;
            }

            SetSaveButton();
        }

        private void Cb_supervisor_TextChanged(object sender, EventArgs e)
        {
            label_supervisor_msg.Visible = false;
            SetSaveButton();
        }

        #endregion

        private void Btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
