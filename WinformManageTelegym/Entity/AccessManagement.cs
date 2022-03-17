using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class AccessManagement
    {
        public string id { get; set; }

        public DateTime time_checkin { get; set; }

        public bool _checkout { get; set; }

        public DateTime? time_checkout { get; set; }

        public DateTime updated_time { get; set; }

        public string id_generalClass { get; set; }

        public string id_customer { get; set; }
    }
}
