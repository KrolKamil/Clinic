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
    public partial class User : UserControl, IUser
    {
        private static User instance;

        public event Action ReturnBtnClicked;
        public event Action ConfirmClicked;

        String IUser.UserName
        {
            get { return name_input.Text; }
            set { name_input.Text = value; }
        }
        String IUser.UserSurname
        {
            get { return surname_input.Text; }
            set { surname_input.Text = value; }
        }
        String IUser.UserPesel {
            get { return pesel_input.Text; }
            set { pesel_input.Text = value; }
        }
        String IUser.UserTelephone {
            get { return telephone_input.Text; }
            set { telephone_input.Text = value; }
        }

        public static User GetInstance
        {
            get
            {
                return instance ?? (instance = new User());
            }
        }

        private User()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (ReturnBtnClicked != null)
            {
                ReturnBtnClicked();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (ConfirmClicked != null)
            {
                ConfirmClicked();
            }
        }
    }
}
