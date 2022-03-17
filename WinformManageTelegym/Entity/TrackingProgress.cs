using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class TrackingProgress
    {
        public string id { get; set; }
        public DateTime? time_checkin { get; set; }
        public PrivateClass privateClass = new PrivateClass();

        public TrackingProgress(string id_privateClass)
        {
            this.privateClass.id = id_privateClass; 
        }
    }
}
