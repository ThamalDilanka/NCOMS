using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
{
    public partial class UserControl_Container_Message : UserControl
    {
        public UserControl_Container_Message()
        {
            InitializeComponent();
        }

        #region Properties

        private Image _icon;
        private string _message;
        private string _keyWord;

        [Category("Message Box")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; if (value != null) { pb_icon.Image = value; } }
        }

        [Category("Message Box")]
        public string Message
        {
            get { return _message; }
            set { _message = value; label_message.Text = value; }
        }

        [Category("Message Box")]
        public string KeyWord
        {
            get { return _keyWord; }
            set { _keyWord = value; label_key_word.Text = value; }
        }

        #endregion
    }
}
