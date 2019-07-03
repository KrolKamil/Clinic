using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Clinic
{
    class RegisterPresenter
    {
        Model model;
        IRegister register;
        IView view;

        public RegisterPresenter(IView view, Model model, IRegister register)
        {
            this.view = view;
            this.model = model;
            this.register = register;

            this.LoadUsers();
            this.LoadDoctors();

            this.register.ReturnBtnClicked += BackToMenu;
            this.register.ConfirmClicked += Test;
        }

        public void Test()
        {
            Debug.WriteLine(this.register.SelectedUser);
        }

        public void LoadUsers()
        {
            this.register.Users = this.model.GetUsers();
        }

        public void LoadDoctors()
        {
            this.register.Doctors = this.model.GetDoctors();
        }

        public void BackToMenu()
        {
            model.ShowDispayMenu(view.FormControl);
        }
    }
}
