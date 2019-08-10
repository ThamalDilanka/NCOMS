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
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
