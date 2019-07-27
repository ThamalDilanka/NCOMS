using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
{
    public partial class Form_Loading : Form
    {
        public Form_Loading()
        {
            InitializeComponent();
            loading_Timer1.Start();
        }

        private void Loading_Timer_Tick(object sender, EventArgs e)
        {
            if (!Connectivity.CheckForInternetConnection())
            {
                loading_Message.Text = "Please Check The Internet Connection";
                loading_Message.ForeColor = System.Drawing.Color.Red;
                loading_Message.Left = (this.ClientSize.Width - loading_Message.Width) / 2;
            }
            else
            {
                if (loading_Message.Visible)
                {
                    loading_Timer2.Start();
                   
                    loading_Message.Text = "Conneting";
                    loading_Message.ForeColor = System.Drawing.Color.Green;
                    loading_Message.Left = (this.ClientSize.Width - loading_Message.Width) / 2;
                }
            }
        }

        private void Loading_Timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Loading_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("This is for server configuration");
            }
        }
    }
}
