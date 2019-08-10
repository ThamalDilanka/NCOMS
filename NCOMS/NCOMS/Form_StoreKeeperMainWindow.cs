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
    public partial class Form_StoreKeeperMainWindow : Form
    {
        public Form_StoreKeeperMainWindow()
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
