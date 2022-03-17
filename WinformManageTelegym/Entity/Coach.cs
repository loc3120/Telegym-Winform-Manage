using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class Coach
    {
        public string id { get; set; }

        public string name { get; set; }

        public DateTime? dateOfBirth { get; set; }

        public string email { get; set; }

        public string phone_number { get; set; }

        public string description { get; set; }

        public float rating { get; set; }

        public bool _deleted { get; set; }
    }
}
