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
        private const string USER_LEVEL_1 = "Manager";
        private const string USER_LEVEL_2 = "Clerk";
        private const string USER_LEVEL_3 = "Supervisor";
        private const string USER_LEVEL_4 = "StoreKeeper";

        private Timer timer = new Timer();
        private List<Staff> staffList;

        public Form_Login()
        {
            InitializeComponent();
            this.AcceptButton = btn_signin;
            this.ActiveControl = tb_username;
            staffList = GetStaffs();
        }


        private void Form_Login_Load(object sender, EventArgs e)
        {
            
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        #region Clock
        private void timer_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;

            string time = "";

            if (hh < 10)
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

        #endregion

        private List<Staff> GetStaffs()
        {
            using(NCOMSEntities db = new NCOMSEntities())
            {
                return db.Staffs.ToList<Staff>();
            }
        }

        private void Btn_signin_Click(object sender, EventArgs e)
        {
            if(tb_username.Text.Length == 0)
            {
                label_un_msg.Text = "Please Enter The User Name";
                this.ActiveControl = tb_username;
                label_un_msg.Visible = true;
                return;
            }

            else if (tb_password.Text.Length == 0)
            {
                label_pswd_msg.Text = "Please Enter The Password";
                this.ActiveControl = tb_password;
                label_pswd_msg.Visible = true;
                return;
            }

            if (IsExist(tb_username.Text.ToString()))
            {
                if (IsValidPassword(tb_username.Text.ToString(), tb_password.Text.ToString()))
                {
                    if (Session.sessionMember.user_level.Equals(USER_LEVEL_1))
                    {
                        Form_ManagerMainWindow form_ManagerMainWindow = new Form_ManagerMainWindow();
                        form_ManagerMainWindow.Show();
                    }

                    else if (Session.sessionMember.user_level.Equals(USER_LEVEL_2))
                    {
                        Form_ClerkMainWindow form_ClerkMainWindow = new Form_ClerkMainWindow();
                        form_ClerkMainWindow.Show();
                    }

                    else if (Session.sessionMember.user_level.Equals(USER_LEVEL_3))
                    {
                        Form_SupervisorMainWindow form_SupervisorMainWindow = new Form_SupervisorMainWindow();
                        form_SupervisorMainWindow.Show();
                    }

                    else if (Session.sessionMember.user_level.Equals(USER_LEVEL_4))
                    {
                        Form_StoreKeeperMainWindow form_StoreKeeperMainWindow = new Form_StoreKeeperMainWindow();
                        form_StoreKeeperMainWindow.Show();
                    }
                }

                else
                {
                    label_pswd_msg.Text = "Incorect Password";
                    label_pswd_msg.Visible = true;
                }
            }

            else
            {
                label_un_msg.Text = "User Doesn\' t Exist";
                label_un_msg.Visible = true;
            }
        }

        // Check wheather user name is exist in the staff table
        private bool IsExist(String userName)
        {
            foreach(Staff staffMember in staffList)
            {
                if (staffMember.user_name.Equals(userName))
                    return true;
            }
            return false;
        }

        // Check wheather given password is match with the user name
        private bool IsValidPassword(String userName, String password)
        {
            foreach (Staff staffMember in staffList)
            {
                if (staffMember.user_name.Equals(userName) && staffMember.password.Equals(password))
                {
                    Session.sessionMember = staffMember;
                    return true;
                }
                    
            }
            return false;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.ActiveControl = tb_password;
                    break;
            }
        }

        private void Tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.ActiveControl = btn_signin;
                    break;
                case Keys.Up:
                    this.ActiveControl = tb_username;
                    break;
                case Keys.Enter:
                    Btn_signin_Click(sender, e);
                    break;
            }
        }

        private void Tb_username_TextChanged(object sender, EventArgs e)
        {
            label_un_msg.Visible = false;
        }

        private void Tb_password_TextChanged(object sender, EventArgs e)
        {
            label_pswd_msg.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
