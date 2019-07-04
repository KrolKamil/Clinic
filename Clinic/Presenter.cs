using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Clinic
{
    class Presenter
    {
        Model model;
        IView view;
        IDisplayMenu displayMenu;

        public Presenter(IView view, Model model, IDisplayMenu displayMenu)
        {
            this.view = view;
            this.model = model;
            this.displayMenu = displayMenu;

            this.ShowDispayMenuCaller();

            this.NavigationListener();
        }

        private void NavigationListener()
        {
            this.displayMenu.NewPatientBtnClicked += ShowUserCaller;
            this.displayMenu.RegisterBtnClicked += ShowRegisterCaller;
            this.displayMenu.ShowRegisterBtnClicked += ShowRegisteredUsersCaller;
        }

        private void ShowRegisterCaller()
        {
            model.ShowRegister(this.view.FormControl);
        }

        private void ShowRegisteredUsersCaller()
        {
            model.ShowRegisteredUsers(this.view.FormControl);
        }

        private void ShowUserCaller()
        {
            model.ShowUser(this.view.FormControl);
        }

        private void ShowDispayMenuCaller()
        {
            model.ShowDispayMenu(this.view.FormControl);
        }

    }
}
