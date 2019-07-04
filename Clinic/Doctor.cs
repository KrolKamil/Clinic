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
    public partial class Doctor : UserControl, IDoctor
    {
        private static Doctor instance;

        public event Action ReturnBtnClicked;
        public event Action AddDoctorBtnClicked;
        public event Action DoctorSelected;

        string IDoctor.UserName
        {
            get { return name_input.Text; }
            set { name_input.Text = value; }
        }
        string IDoctor.UserSurname
        {
            get { return surname_input.Text; }
            set { surname_input.Text = value; }
        }

        public static Doctor GetInstance
        {
            get
            {
                return instance ?? (instance = new Doctor());
            }
        }

        public Dictionary<int, string> DoctorRoom
        {
            set
            {
                if ((value == null) || (value.Count == 0))
                {
                    this.doctor_room_box.DataSource = null;
                }
                else
                {
                    this.doctor_room_box.DataSource = new BindingSource(value, null);
                    this.doctor_room_box.DisplayMember = "Value";
                    this.doctor_room_box.ValueMember = "Key";
                }
            }
        }

        public int DoctorAssignedRoom
        {
            get
            {
                if (doctor_room_box.SelectedValue == null)
                    return 0;
                return (int)doctor_room_box.SelectedValue;
            }
        }

        public Dictionary<int, string> DoctorSpecialisations
        {
            set
            {
                if ((value == null) || (value.Count == 0))
                {
                    this.doctor_spec_box.DataSource = null;
                }
                else
                {
                    this.doctor_spec_box.DataSource = new BindingSource(value, null);
                    this.doctor_spec_box.DisplayMember = "Value";
                    this.doctor_spec_box.ValueMember = "Key";
                }
            }
        }

        public int SelectedDoctorSpecialisation
        {
            get
            {
                if (doctor_spec_box.SelectedValue == null)
                    return 0;
                return (int)doctor_spec_box.SelectedValue;
            }
        }


        public Dictionary<int, string> Doctors
        {
            set
            {
                if (value.Count == 0)
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
            get
            {
                if (doctor_box.SelectedValue == null)
                    return 0;
                return (int)doctor_box.SelectedValue;
            }
        }

        public Dictionary<int, string> Specialisations
        {
            set
            {
                if (value.Count == 0)
                {
                    this.all_spec_box.DataSource = null;
                }
                else
                {
                    this.all_spec_box.DataSource = new BindingSource(value, null);
                    this.all_spec_box.DisplayMember = "Value";
                    this.all_spec_box.ValueMember = "Key";
                }
            }
        }

        public int SelectedSpecialisation
        {
            get
            {
                if (all_spec_box.SelectedValue == null)
                    return 0;
                return (int)all_spec_box.SelectedValue;
            }
        }

        public Dictionary<int, string> Rooms
        {
            set
            {
                if (value.Count == 0)
                {
                    this.available_room_box.DataSource = null;
                }
                else
                {
                    this.available_room_box.DataSource = new BindingSource(value, null);
                    this.available_room_box.DisplayMember = "Value";
                    this.available_room_box.ValueMember = "Key";
                }
            }
        }

        public int SelectedRoom
        {
            get
            {
                if (available_room_box.SelectedValue == null)
                    return 0;
                return (int)available_room_box.SelectedValue;
            }
        }

        private Doctor()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if(ReturnBtnClicked != null)
            {
                ReturnBtnClicked();
            }
        }

        private void add_doctor_btn_Click(object sender, EventArgs e)
        {
            if(AddDoctorBtnClicked != null)
            {
                AddDoctorBtnClicked();
            }
        }

        private void doctor_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DoctorSelected != null)
            {
                DoctorSelected();
            }
        }
    }
}
