using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Clinic
{
    class UserPresenter
    {
        Model model;
        IUser user;
        IView view;

        public UserPresenter(IView view, Model model, IUser user)
        {
            this.view = view;
            this.model = model;
            this.user = user;

            this.user.ReturnBtnClicked += BackToMenu;
            this.user.ConfirmClicked += AddUser;
        }

        public void BackToMenu()
        {
            model.ShowDispayMenu(view.FormControl);
        }

        public void AddUser()
        {
            model.AddUserToDatabase(user, view.FormControl);
            
        }
    }
}
