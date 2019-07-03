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
                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine("ERROR: " + exc.Message);
                }
            }
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

        public List<DateTime> GetDates()
        {
            List<DateTime> dateTimes = new List<DateTime>();

            DateTime dateTimeHelper = SetValidDate(DateTime.Now);

            while( (8 <= dateTimeHelper.Hour) && (dateTimeHelper.Hour <= 16) )
            {
                dateTimes.Add(dateTimeHelper);
                dateTimeHelper = dateTimeHelper.AddMinutes(30);
                dateTimeHelper = SetValidDate(dateTimeHelper);
            }

            return dateTimes;
        }

        public DateTime SetValidDate(DateTime input)
        {
            DateTime dT;

           dT = new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0).AddMinutes(input.Minute % 30 == 0 ? 0 : 30 - input.Minute % 30);
            return dT;

            //if (input.Minute < 30)
            //{
            //    dT = new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0)
            //    .AddMinutes(input.Minute % 30 == 0 ? 0 : 30 - input.Minute % 30);
            //}
            //else
            //{
            //    dT = new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0).AddMinutes(-input.Minute % 30);
            //    dT.AddHours(1);
            //}

            return dT;
        }

    }
}
