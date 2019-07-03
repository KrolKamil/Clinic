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
        public List<DateTime> Dates
        {
            set
            {
                this.date_box.DataSource = value;
            }
        }

        public DateTime SelectedDate
        {
            get
            {
                return (DateTime)this.date_box.SelectedItem;
            }
        }

        private static Register instance;

        public event Action ReturnBtnClicked;
        public event Action ConfirmClicked;
        public event Action SpecialisationChanged;
        public event Action DoctorSelected;

        public Dictionary<int, string> Specialisations
        {
            set
            {
                this.specialisations_comboBox.DataSource = new BindingSource(value, null);
                this.specialisations_comboBox.DisplayMember = "Value";
                this.specialisations_comboBox.ValueMember = "Key";
            }
        }

        public int SelectedSpecialisation
        {
            get
            {
                return (int)specialisations_comboBox.SelectedValue;
            }
        }

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
                //this.doctor_box.DataSource = null;
                if(value.Count == 0)
                {
                    this.doctor_box.DataSource = null;
                }
                else
                {
                    this.doctor_box.DataSource = new BindingSource(value, null);
                    this.doctor_box.DisplayMember = "Value";
                    this.doctor_box.ValueMember = "Key";
                }
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

        private void specialisations_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SpecialisationChanged != null)
            {
                SpecialisationChanged();
            }
        }

        private void doctor_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoctorSelected != null)
            {
                DoctorSelected();
            }
        }

        private void date_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
