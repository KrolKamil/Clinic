﻿using System;
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
    }
}
