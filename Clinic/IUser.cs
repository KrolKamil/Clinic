using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    interface IUser
    {
        event Action ReturnBtnClicked;
        event Action ConfirmClicked;

        String UserName { get; set; }
        String UserSurname { get; set; }
        String UserPesel { get; set; }
        String UserTelephone { get; set; }
    }
}
