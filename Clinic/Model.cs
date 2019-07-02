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
    }
}
