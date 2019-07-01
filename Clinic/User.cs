using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class User : UserControl
    {
        private static User instance;
        public static User GetInstance
        {
            get
            {
                return instance ?? (instance = new User());
            }
        }

        private User()
        {
            InitializeComponent();
        }
    }
}
