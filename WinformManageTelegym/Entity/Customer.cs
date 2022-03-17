using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class Customer
    {
        public string id { get; set; }

        public string name { get; set; }

        public string phone_number { get; set; }

        public string email { get; set; }

        public DateTime? time_enroll { get; set; }

        public DateTime? time_expire { get; set; }

        public bool _expire { get; set; }

        public string exercise_form { get; set; }

        public string membershipCard { get; set; }
    }
}
