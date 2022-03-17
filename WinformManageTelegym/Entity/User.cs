using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class User
    {
        public string id { get; set; }

        public string name { get; set; }

        public string username { get; set; }

        public string pass { get; set; }

        public string tokenValue { get; set; }

        public bool delete { get; set; }

        public string role { get; set; }
    }
}
