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
    public partial class Form_Login : Form
    {
        Timer timer = new Timer();

        public Form_Login()
        {
            InitializeComponent();
        }


        private void Form_Login_Load(object sender, EventArgs e)
        {
            
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();

            bunifuLogin_FormFadeTransition.ShowAsyc(this);
        }

        private void Lf_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                lf_Password.Focus();
            }

            if(e.KeyCode == Keys.Delete)
            {
                lf_UserName.Text = "";
            }
        }

        private void Lf_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                lf_UserName.Focus();
            }

            if(e.KeyCode == Keys.Delete)
            {
                lf_Password.Text = "";
            }

            if(e.KeyCode == Keys.Enter)
            {
                Btn_Login_Click(sender, e);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;

            string time = "";

            if(hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            lbl_clock.Text = time;
            lbl_clock.Left = (this.panel_clock.Width - lbl_clock.Width) / 2;

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            // this should be login process with database
            // MessageBox.Show("Loging successful");
            this.Close();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
