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
using System.Runtime.InteropServices;

namespace NCOMS
{
    public partial class Form_ClerkMainWindow : Form
    {
        // Members to make the form moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Make the header moveable
        private void Panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        public Form_ClerkMainWindow()
        {
            InitializeComponent();

            try
            {
                pb_prifilePicture.Image = ConvertBinaryToImage(Session.sessionMember.profile_picture);
            }

            catch (Exception)
            {

            }

            #region Disabling Defauld Flat Button Behaviour

            btn_signout.FlatAppearance.MouseOverBackColor = btn_signout.BackColor;
            btn_signout.BackColorChanged += (s, e) => {
                btn_signout.FlatAppearance.MouseOverBackColor = btn_signout.BackColor;
            };

            btn_close.FlatAppearance.MouseOverBackColor = btn_close.BackColor;
            btn_close.BackColorChanged += (s, e) => {
                btn_close.FlatAppearance.MouseOverBackColor = btn_close.BackColor;
            };

            btn_minimize.FlatAppearance.MouseOverBackColor = btn_minimize.BackColor;
            btn_minimize.BackColorChanged += (s, e) => {
                btn_minimize.FlatAppearance.MouseOverBackColor = btn_minimize.BackColor;
            };

            #endregion

        }

        // Convert Bynary to image
        private Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                return Image.FromStream(memoryStream);
            }
        }

        // Resetting the navigation buttons to default
        private void resetNavButtons()
        {
            btn_nav_dashboard.BackColor = Color.Transparent;
            btn_nav_dashboard.ForeColor = Color.White;

            btn_nav_vehicle.BackColor = Color.Transparent;
            btn_nav_vehicle.ForeColor = Color.White;
        }

        // Loading the given form into the main window
        private void loadInToMainWindow(Form subForm)
        {
            panel_container.Controls.Clear();
            subForm.TopLevel = false;
            panel_container.Controls.Add(subForm);
            subForm.Show();
        }

        public void Btn_nav_dashboard_Click(object sender, EventArgs e)
        {
            resetNavButtons();
            btn_nav_dashboard.BackColor = Color.AliceBlue;
            btn_nav_dashboard.ForeColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));

            Form_CMW_Dashboard form_CMW_Dashboard = new Form_CMW_Dashboard();
            loadInToMainWindow(form_CMW_Dashboard);
        }

        public void Btn_nav_vehicle_Click(object sender, EventArgs e)
        {
            resetNavButtons();
            btn_nav_vehicle.BackColor = Color.AliceBlue;
            btn_nav_vehicle.ForeColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));

            Form_CMW_Vehicle form_CMW_Vehicle = new Form_CMW_Vehicle();
            loadInToMainWindow(form_CMW_Vehicle);
        }

        private void Btn_close_MouseHover(object sender, EventArgs e)
        {
            btn_close.Image = Properties.Resources.close_16_red;
        }

        private void Btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.Image = Properties.Resources.close_16_ash;
        }

        private void Btn_minimize_MouseHover(object sender, EventArgs e)
        {
            btn_minimize.Image = Properties.Resources.minimize_16_blue;
        }

        private void Btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.Image = Properties.Resources.minimize_16_ash;
        }
    }
}
