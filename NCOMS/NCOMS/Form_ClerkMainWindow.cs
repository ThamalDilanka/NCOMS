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
    public partial class Form_ClerkMainWindow : Form
    {
        public Form_ClerkMainWindow()
        {
            InitializeComponent();

            btn_menu_dashboard.BackColor = System.Drawing.Color.AliceBlue;

            panel_container.Controls.Clear();
            Form_CMW_Dashboard form_CMW_Dashboard = new Form_CMW_Dashboard();
            form_CMW_Dashboard.TopLevel = false;
            panel_container.Controls.Add(form_CMW_Dashboard);
            form_CMW_Dashboard.Show();
        }

        private void Form_ClerkMainWindow_Load(object sender, EventArgs e)
        {
            
        }

        public void Btn_menu_dashboard_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_vehicle.BackColor = System.Drawing.Color.White;

            panel_container.Controls.Clear();
            Form_CMW_Dashboard form_CMW_Dashboard = new Form_CMW_Dashboard();
            form_CMW_Dashboard.TopLevel = false;
            panel_container.Controls.Add(form_CMW_Dashboard);
            form_CMW_Dashboard.Show();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_signout_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        public void Btn_menu_vehicle_Click(object sender, EventArgs e)
        {
            btn_menu_vehicle.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;

            panel_container.Controls.Clear();
            Form_CMW_Vehicle form_CMW_Vehicle = new Form_CMW_Vehicle();
            form_CMW_Vehicle.TopLevel = false;
            panel_container.Controls.Add(form_CMW_Vehicle);
            form_CMW_Vehicle.Show();
        }
    }
}
