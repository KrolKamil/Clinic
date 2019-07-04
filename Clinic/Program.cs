using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Clinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();

            IView view = new Form1();
            IDisplayMenu displayMenu = DisplayMenu.GetInstance;
            IUser user = User.GetInstance;
            IRegister register = Register.GetInstance;
            IRegisteredUsers registeredUsers = RegisteredUsers.GetInstance;
            IDoctor doctor = Doctor.GetInstance;

            Presenter presenter = new Presenter(view, model, displayMenu);
            RegisterPresenter RegisterPresenter = new RegisterPresenter(view, model, register);
            UserPresenter UserPresenter = new UserPresenter(view, model, user);
            RegisteredUsersPresenter RegisteredUsersPresenter = new RegisteredUsersPresenter(view, model, registeredUsers);
            DoctorPresenter DoctorPresenter = new DoctorPresenter(view, model, doctor);

            Debug.WriteLine(DateTime.Now);

            Application.Run((Form1)view);
        }
    }
}
