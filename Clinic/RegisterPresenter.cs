using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            this.register.ReturnBtnClicked += BackToMenu;
        }

        public void BackToMenu()
        {
            model.ShowDispayMenu(view.FormControl);
        }
    }
}
