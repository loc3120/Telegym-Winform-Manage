using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class PrivateClass
    {
        public string id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int number_sessions { get; set; }

        public int remaining_sessions { get; set; }

        public string created_by { get; set; }

        public string customer { get; set; }

        public string coach { get; set; }
    }
}
