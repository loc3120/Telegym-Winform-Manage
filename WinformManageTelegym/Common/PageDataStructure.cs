using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Common
{
    public class PageDataStructure
    {
        public Object data { get; set; }
        public int totalPages { get; set; }
        public long totalElements { get; set; }
        public bool hasNext { get; set; }
    }
}
