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


        public Dictionary<int, string> Users
        {
            set
            {
                this.user_box.DataSource = new BindingSource(value, null);
                this.user_box.DisplayMember = "Value";
                this.user_box.ValueMember = "Key";
            }
        }

        public int SelectedUser
        {
            get { return (int)user_box.SelectedValue; }
        }

        public Dictionary<int, string> Doctors
        {
            set
            {
                doctor_box.Items.Clear();
                this.doctor_box.DataSource = new BindingSource(value, null);
                this.doctor_box.DisplayMember = "Value";
                this.doctor_box.ValueMember = "Key";
            }
        }

        public int SelectedDoctor
        {
            get { return (int)doctor_box.SelectedValue; }
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
