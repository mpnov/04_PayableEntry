using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableDAL
{
    public class State
    {
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public int FirstZipCode { get; set; }
        public int LastZipCode { get; set;}
    }
}
