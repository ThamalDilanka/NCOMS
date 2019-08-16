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
    public partial class Form_ManagerMainWindow : Form
    {
        public Form_ManagerMainWindow()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_signout_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
