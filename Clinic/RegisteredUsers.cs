using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class RegisteredUsers : UserControl, IRegisteredUsers
    {
        private static RegisteredUsers instance;

        private RegisteredUsers()
        {
            InitializeComponent();
        }

        public static RegisteredUsers GetInstance
        {
            get
            {
                return instance ?? (instance = new RegisteredUsers());
            }
        }

        public List<string> Registered
        {
            set
            {
                this.register_box.DataSource = value;
            }
        }

        public event Action ReturnBtnClicked;

        private void back_btn_Click(object sender, EventArgs e)
        {
            if(ReturnBtnClicked != null)
            {
                ReturnBtnClicked();
            }
        }
    }
}
