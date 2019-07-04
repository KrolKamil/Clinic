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

        Dictionary<int, string> Doctors { set; }
        int SelectedDoctor { get; }

        Dictionary<int, string> Specialisations { set; }
        int SelectedSpecialisation { get; }

        string UserName { set; get; }
        string UserSurname { set; get; }
    }
}
