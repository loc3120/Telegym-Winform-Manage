using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformManageTelegym.Common
{
    public class ResponseStructure
    {
        public string status { get; set; }
        public string message { get; set; }
        public Object dataResponse { get; set; }
    }
}
