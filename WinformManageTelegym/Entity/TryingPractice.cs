using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class TryingPractice
    {
        public string id { get; set; }

        public string name { get; set; }

        public string phone_number { get; set; }

        public string email { get; set; }

        public DateTime? time_sent { get; set; }

        public bool _contacted { get; set; }

        public DateTime? time_reply { get; set; }

        public string reply_by { get; set; }
    }
}
