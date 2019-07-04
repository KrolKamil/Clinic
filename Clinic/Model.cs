using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Clinic
{
    class Model
    {
        public void ShowDispayMenu(Control.ControlCollection FormControls)
        {
            if(!FormControls.Contains(DisplayMenu.GetInstance))
            {
                FormControls.Add(DisplayMenu.GetInstance);
                DisplayMenu.GetInstance.Dock = DockStyle.Fill;
            }
            DisplayMenu.GetInstance.BringToFront();
        }

        public void ShowRegister(Control.ControlCollection FormControls)
        {
            if (!FormControls.Contains(Register.GetInstance))
            {
                FormControls.Add(Register.GetInstance);
                Register.GetInstance.Dock = DockStyle.Fill;
            }
            Register.GetInstance.BringToFront();
        }

        public void ShowUser(Control.ControlCollection FormControls)
        {
            if (!FormControls.Contains(User.GetInstance))
            {
                FormControls.Add(User.GetInstance);
                User.GetInstance.Dock = DockStyle.Fill;
            }
            User.GetInstance.BringToFront();
        }

        public void ShowRegisteredUsers(Control.ControlCollection FormControls)
        {
            if (!FormControls.Contains(RegisteredUsers.GetInstance))
            {
                FormControls.Add(RegisteredUsers.GetInstance);
                RegisteredUsers.GetInstance.Dock = DockStyle.Fill;
            }
            RegisteredUsers.GetInstance.BringToFront();
        }

        public void ShowDoctor(Control.ControlCollection FormControls)
        {
            if (!FormControls.Contains(Doctor.GetInstance))
            {
                FormControls.Add(Doctor.GetInstance);
                Doctor.GetInstance.Dock = DockStyle.Fill;
            }
            Doctor.GetInstance.BringToFront();
        }

        
        public void AddDoctorToDatabase(IDoctor doctor)
        {
            string name = doctor.UserName;
            string surname = doctor.UserSurname;

            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"INSERT INTO `lekarze` VALUES('', '{name}', '{surname}')", conn))
                    {
                        command.ExecuteNonQuery();
                        doctor.UserName = "";
                        doctor.UserSurname = "";
                    }

                    doctor.Doctors = this.GetDoctors();
                    Register RG = Register.GetInstance;
                    RG.Doctors = this.GetDoctors();

                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
        }

        public void AddUserToDatabase(IUser user, Control.ControlCollection FormControls)
        {
            String name = user.UserName;
            String surname = user.UserSurname;
            String pesel = user.UserPesel;
            String telephone = user.UserTelephone;

            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"INSERT INTO pacjenci VALUES('', '{name}', '{surname}', '{pesel}', '{telephone}')", conn))
                    {
                        command.ExecuteNonQuery();
                        user.UserName = "";
                        user.UserSurname = "";
                        user.UserPesel = "";
                        user.UserTelephone = "";
                        this.ShowDispayMenu(FormControls);
                    }

                    Register RG = Register.GetInstance;
                    RG.Users = this.GetUsers();

                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
        }

        public Dictionary<int, string> GetRooms()
        {
            Dictionary<int, string> Rooms = new Dictionary<int, string>();
            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT id_g, nazwa FROM `gabinety` WHERE id_l IS NULL", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                int id_p = (int)dataReader["id_g"];
                                string room = (string)dataReader["nazwa"];

                                Rooms.Add(id_p, room);
                            }
                        }
                    }
                    conn.Close();
                    return Rooms;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }

        public Dictionary<int, string> GetUsers()
        {
            //List<String> Users = new List<String>();
            Dictionary<int, string> Users = new Dictionary<int, string>();
            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT id_p, imie, nazwisko FROM `pacjenci`", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                int id_p = (int)dataReader["id_p"];
                                var name = dataReader["imie"];
                                var surname = dataReader["nazwisko"];

                                Users.Add(id_p, name + ", " + surname);
                            }
                        }
                    }
                    conn.Close();
                    return Users;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }

        public Dictionary<int, string> GetDoctors()
        {
            //List<String> Users = new List<String>();
            Dictionary<int, string> Doctors = new Dictionary<int, string>();
            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT id_l, imie, nazwisko FROM `lekarze`", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                int id_l = (int)dataReader["id_l"];
                                var name = dataReader["imie"];
                                var surname = dataReader["nazwisko"];

                                Doctors.Add(id_l, name + ", " + surname);
                            }
                        }
                    }
                    conn.Close();
                    return Doctors;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }



        public Dictionary<int, string> GetSpecialisations()
        {
            //List<String> Users = new List<String>();
            Dictionary<int, string> Specialisations = new Dictionary<int, string>();
            Specialisations.Add(0, "brak");
            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT id_s, nazwa FROM `specjalizacje`", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                int id_s = (int)dataReader["id_s"];
                                var name = dataReader["nazwa"];

                                Specialisations.Add(id_s, (string)name);
                            }
                        }
                    }
                    conn.Close();
                    return Specialisations;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }

        public Dictionary<int, string> GetDoctorsWithSpecialisations(int id_s)
        {
            if(id_s == 0)
            {
                return GetDoctors();
            }
            //List<String> Users = new List<String>();
            Dictionary<int, string> Doctors = new Dictionary<int, string>();
            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(
                        $"SELECT lekarze.id_l, imie, nazwisko FROM `lekarze`" +
                        $" JOIN `posiadaja` ON lekarze.id_l = posiadaja.id_l" +
                        $" JOIN `specjalizacje` ON specjalizacje.id_s = posiadaja.id_s" +
                        $" WHERE specjalizacje.id_s = {id_s} ", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                int id_l = (int)dataReader["id_l"];
                                var name = dataReader["imie"];
                                var surname = dataReader["nazwisko"];

                                Doctors.Add(id_l, name + ", " + surname);
                            }
                        }
                    }
                    conn.Close();
                    return Doctors;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }

        public void RegisterUser(IRegister register, IView view)
        {
            if (register.SelectedDate != null)
            {
                int userId = register.SelectedUser;
                int doctorId = register.SelectedDoctor;

                DateTime visitDate = (DateTime)register.SelectedDate;
                var formatForMySql = visitDate.ToString("yyyy-MM-dd HH:mm:ss");
                //DateTime visitDate = DateTime.Now;
                using (MySqlConnection conn = DatabaseConnection.Connection())
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand($"INSERT INTO `umowienia` VALUES('', '{formatForMySql}', '{doctorId}', '{userId}' )", conn))
                        {
                            command.ExecuteNonQuery();
                            this.ShowDispayMenu(view.FormControl);
                        }
                        conn.Close();
                        register.Dates = GetDoctorAvailableDates(register.SelectedDoctor);

                        RegisteredUsers RU = RegisteredUsers.GetInstance;
                        RU.Registered = this.GetRegistered();

                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("ERROR: " + exc.Message);
                    }
                }
            }
            
        }

        public List<DateTime> GetDoctorAvailableDates(int id_l)
        {
            List<DateTime> allDates = GetDates();
            List<DateTime> busyDates = GetDoctorDates(id_l);
            if(busyDates != null)
            {
                foreach (var element in busyDates)
                {
                    allDates.Remove(element);
                }
            }

            if (allDates.Count > 0)
                return allDates;

            return null;
        }

        public List<DateTime> GetDoctorDates(int id_l)
        {
            List<DateTime> doctorDates = new List<DateTime>();

            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT data FROM `umowienia` WHERE id_l = {id_l};", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                DateTime doctorDate = (DateTime)dataReader["data"];
                                doctorDates.Add(doctorDate);
                            }
                        }
                    }
                    conn.Close();
                    return doctorDates;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }

        public List<DateTime> GetDates()
        {
            List<DateTime> dateTimes = new List<DateTime>();

            DateTime dateTimeHelper = SetValidDate(DateTime.Now);
            DateTime nowDate = DateTime.Now;
            DateTime endDay = nowDate.AddDays(7);

            while(dateTimeHelper.Date < endDay)
            {
                while ((8 <= dateTimeHelper.Hour) && (dateTimeHelper.Hour <= 16))
                {
                    dateTimes.Add(dateTimeHelper);
                    dateTimeHelper = dateTimeHelper.AddMinutes(30);
                }

                dateTimeHelper = setNextDay(dateTimeHelper);

            }
            return dateTimes;
        }

        public DateTime setNextDay(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, 8, input.Minute, 0).AddDays(1);
        }

        public DateTime SetValidDate(DateTime input)
        {
           return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0).AddMinutes(input.Minute % 30 == 0 ? 0 : 30 - input.Minute % 30);
        }

        public List<string> GetRegistered()
        {
            List<string> registered = new List<string>();

            using (MySqlConnection conn = DatabaseConnection.Connection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT pacjenci.imie, pacjenci.nazwisko, lekarze.imie, lekarze.nazwisko, umowienia.data, gabinety.nazwa FROM pacjenci JOIN umowienia ON pacjenci.id_p = umowienia.id_p JOIN lekarze ON lekarze.id_l = umowienia.id_l JOIN gabinety on lekarze.id_l = gabinety.id_l WHERE umowienia.data > NOW(); ", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                string userName = (string)dataReader[0];
                                string userSurname = (string)dataReader[1];

                                string doctorName = (string)dataReader[2];
                                string doctorSurname = (string)dataReader[3];

                                DateTime date = (DateTime)dataReader[4];

                                string room = (string)dataReader[5];

                                string record = $"{userName} {userSurname} do {doctorName} {doctorSurname} na {date} w {room}.";

                                registered.Add(record);
                            }
                        }
                    }
                    conn.Close();
                    return registered;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
            return null;
        }

    }
}
