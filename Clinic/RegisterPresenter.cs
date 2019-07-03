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
            this.LoadSpecialisations();
            this.LoadDates();
            //this.LoadDates();

            this.register.ReturnBtnClicked += BackToMenu;
            this.register.ConfirmClicked += Test;
            this.register.SpecialisationChanged += LoadDoctorsWithSpecialisations;
            this.register.DoctorSelected += LoadDoctorDates;
        }

        public void LoadDoctorDates()
        {
            this.register.Dates = this.model.GetDoctorAvailableDates(this.register.SelectedDoctor);
        }

        public void LoadDates()
        {
            this.register.Dates = this.model.GetDates();
        }

        public void LoadDoctorsWithSpecialisations()
        {
            int specialisation = this.register.SelectedSpecialisation;
            this.register.Doctors = this.model.GetDoctorsWithSpecialisations(specialisation);
        }

        public void Test()
        {
            Debug.WriteLine(this.register.SelectedUser);
        }

        public void LoadSpecialisations()
        {
            this.register.Specialisations = this.model.GetSpecialisations();
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
