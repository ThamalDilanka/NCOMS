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
    public partial class Form_SupervisorMainWindow : Form
    {
        public Form_SupervisorMainWindow()
        {
            InitializeComponent();

            // disable default mosehover behavior
            /*
            btn_menu_dashboard.FlatAppearance.MouseOverBackColor = btn_menu_dashboard.BackColor;
            btn_menu_dashboard.BackColorChanged += (s, e) => {
                btn_menu_dashboard.FlatAppearance.MouseOverBackColor = btn_menu_dashboard.BackColor;
            };
            */
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

        private void Btn_menu_dashboard_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            btn_menu_money_request.BackColor = System.Drawing.Color.White;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            btn_menu_weather_report.BackColor = System.Drawing.Color.White;

            label_header_title.Text = "Dashboard";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
            Form_SMW_Dashboard form_SMW_Dashboard = new Form_SMW_Dashboard();
            form_SMW_Dashboard.TopLevel = false;
            panel_container.Controls.Add(form_SMW_Dashboard);
            form_SMW_Dashboard.Show();
        }

        private void Btn_menu_mat_usage_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            btn_menu_money_request.BackColor = System.Drawing.Color.White;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            btn_menu_weather_report.BackColor = System.Drawing.Color.White;

            label_header_title.Text = "Material Usage";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
        }

        private void Btn_menu_mat_request_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            btn_menu_mat_request.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_money_request.BackColor = System.Drawing.Color.White;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            btn_menu_weather_report.BackColor = System.Drawing.Color.White;

            label_header_title.Text = "Material Request";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
        }

        private void Btn_menu_money_request_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            btn_menu_money_request.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            btn_menu_weather_report.BackColor = System.Drawing.Color.White;

            label_header_title.Text = "Money Request";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
        }

        private void Btn_menu_lab_timesheet_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            btn_menu_money_request.BackColor = System.Drawing.Color.White;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            btn_menu_weather_report.BackColor = System.Drawing.Color.White;

            label_header_title.Text = "Labor Time Sheet";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
        }

        private void Btn_menu_lab_advance_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            btn_menu_money_request.BackColor = System.Drawing.Color.White;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.AliceBlue;
            btn_menu_weather_report.BackColor = System.Drawing.Color.White;

            label_header_title.Text = "Labor Advance";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
        }

        private void Btn_menu_weather_report_Click(object sender, EventArgs e)
        {
            btn_menu_dashboard.BackColor = System.Drawing.Color.White;
            btn_menu_mat_usage.BackColor = System.Drawing.Color.White;
            btn_menu_mat_request.BackColor = System.Drawing.Color.White;
            btn_menu_money_request.BackColor = System.Drawing.Color.White;
            btn_menu_lab_timesheet.BackColor = System.Drawing.Color.White;
            btn_menu_lab_advance.BackColor = System.Drawing.Color.White;
            btn_menu_weather_report.BackColor = System.Drawing.Color.AliceBlue;

            label_header_title.Text = "Weather Report";
            label_header_title.Left = (this.panel_header.Width - label_header_title.Width) / 2;

            panel_container.Controls.Clear();
        }

    }
}
