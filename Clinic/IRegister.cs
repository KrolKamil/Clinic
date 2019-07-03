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

        Dictionary<int, string> Users { set; }
        int SelectedUser { get; }
    }
}
