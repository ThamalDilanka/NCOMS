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
        public Form_Login()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
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

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loging successful");
        }
        
    }
}
