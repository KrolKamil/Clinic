using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    interface IRegister
    {
        event Action ReturnBtnClicked;
        event Action ConfirmClicked;
        event Action SpecialisationChanged;

        Dictionary<int, string> Users { set; }
        int SelectedUser { get; }

        Dictionary<int, string> Doctors { set; }
        int SelectedDoctor { get; }

        Dictionary<int, string> Specialisations { set; }
        int SelectedSpecialisation { get; }

        List<DateTime> Dates { set; }
        DateTime SelectedDate { get; }
    }
}
