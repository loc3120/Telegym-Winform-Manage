using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Entity
{
    public class MembershipCard
    {
        public string id { get; set; }

        public string cardname { get; set; }

        public int level_card { get; set; }

        public string description { get; set; }

        public long minprice { get; set; }
    }
}
