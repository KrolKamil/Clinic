using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    interface IDoctor
    {
        event Action ReturnBtnClicked;
        event Action AddDoctorBtnClicked;
        event Action DoctorSelected;
        event Action AddDoctorSpecialisationBtnClicked;

        Dictionary<int, string> DoctorSpecialisations { set; }
        int SelectedDoctorSpecialisation { get; }

        Dictionary<int, string> DoctorRoom { set; }
        int DoctorAssignedRoom { get; }

        Dictionary<int, string> Doctors { set; }
        int SelectedDoctor { get; }

        Dictionary<int, string> Specialisations { set; }
        int SelectedSpecialisation { get; }

        Dictionary<int, string> Rooms { set; }
        int SelectedRoom { get; }

        string UserName { set; get; }
        string UserSurname { set; get; }
    }
}
