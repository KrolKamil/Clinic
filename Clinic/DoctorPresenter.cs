using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class DoctorPresenter
    {
        Model model;
        IDoctor doctor;
        IView view;

        public DoctorPresenter(IView view, Model model, IDoctor doctor)
        {
            this.view = view;
            this.model = model;
            this.doctor = doctor;

            LoadDoctors();
            LoadSpecialisations();
            LoadRooms();

            this.doctor.ReturnBtnClicked += BackToMenu;
            this.doctor.AddDoctorBtnClicked += AddDoctor;
            this.doctor.DoctorSelected += LoadSpecsAndRoom;
        }

        private void LoadSpecsAndRoom()
        {
            this.doctor.DoctorSpecialisations = this.model.GetDoctorSpecialisations(this.doctor.SelectedDoctor);
            this.doctor.DoctorRoom = this.model.GetDoctorRoom(this.doctor.SelectedDoctor);
        }

        private void LoadRooms()
        {
            this.doctor.Rooms = this.model.GetRooms();
        }

        private void LoadSpecialisations()
        {
            Dictionary<int, string> specs = this.model.GetSpecialisations();
            specs.Remove(0);
            this.doctor.Specialisations = specs;
        }

        private void AddDoctor()
        {
            model.AddDoctorToDatabase(this.doctor);
        }

        private void LoadDoctors()
        {
            this.doctor.Doctors = this.model.GetDoctors();
        }

        private void BackToMenu()
        {
            model.ShowDispayMenu(view.FormControl);
        }

        //            this.register.ReturnBtnClicked += BackToMenu;
    }
}
