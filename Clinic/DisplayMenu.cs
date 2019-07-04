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
    public partial class DisplayMenu : UserControl, IDisplayMenu
    {
        public event Action NewPatientBtnClicked;
        public event Action RegisterBtnClicked;

        private static DisplayMenu instance;
        public static DisplayMenu GetInstance
        {
            get
            {
                return instance ?? (instance = new DisplayMenu());
            }
        }

        private DisplayMenu()
        {
            InitializeComponent();
        }

        private void new_patient_btn_Click(object sender, EventArgs e)
        {
            if(NewPatientBtnClicked != null)
            {
                NewPatientBtnClicked();
            }
        }

        private void patient_registration_btn_Click(object sender, EventArgs e)
        {
            if(RegisterBtnClicked != null)
            {
                RegisterBtnClicked();
            }
        }

        private void show_register_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
