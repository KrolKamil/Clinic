using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    interface IRegisteredUsers
    {
        event Action ReturnBtnClicked;

        List<string> Registered { set; }
    }
}
