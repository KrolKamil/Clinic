﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    interface IDisplayMenu
    {
        event Action NewPatientBtnClicked;
        event Action RegisterBtnClicked;
        event Action ShowRegisterBtnClicked;
        event Action DoctorBtnClicked;
    }
}
