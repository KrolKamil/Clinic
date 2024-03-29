﻿using System;
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
            this.LoadDoctorDates();
            //this.LoadDates();
            //this.LoadDates();

            this.register.ReturnBtnClicked += BackToMenu;
            this.register.ConfirmClicked += RegisterUser;
            this.register.SpecialisationChanged += LoadDoctorsWithSpecialisations;
            this.register.DoctorSelected += LoadDoctorDates;
        }

        public void RegisterUser()
        {
            this.model.RegisterUser(this.register, this.view);
        }

        public void LoadDoctorDates()
        {
            if(this.register.SelectedDoctor != 0)
            {
                this.register.Dates = this.model.GetDoctorAvailableDates(this.register.SelectedDoctor);
            }
            else
            {
                this.register.Dates = null;
            }
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
