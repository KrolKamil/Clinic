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
    public partial class Register : UserControl, IRegister
    {
        private static Register instance;

        public event Action ReturnBtnClicked;
        public event Action ConfirmClicked;


        public string[] Users
        {
            set
            {
                if(value != null)
                {
                    foreach (var d in value)
                        user_box.Items.Add(d);
                }
            }
        }

        public string SelectedUser
        {
            get { return user_box.GetItemText(user_box.SelectedItem); }
        }

        public Register()
        {
            InitializeComponent();
        }

        public static Register GetInstance
        {
            get
            {
                return instance ?? (instance = new Register());
            }
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
