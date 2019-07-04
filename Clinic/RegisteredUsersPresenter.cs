using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class RegisteredUsersPresenter
    {
        Model model;
        IRegisteredUsers registeredUsers;
        IView view;

        public RegisteredUsersPresenter(IView view, Model model, IRegisteredUsers registeredUsers)
        {
            this.view = view;
            this.model = model;
            this.registeredUsers = registeredUsers;

            this.SetRegistered();

            this.registeredUsers.ReturnBtnClicked += BackToMenu;
        }

        private void SetRegistered()
        {
            this.registeredUsers.Registered = this.model.GetRegistered();
        }

        private void BackToMenu()
        {
            model.ShowDispayMenu(view.FormControl);
        }
    }
}
