using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableDAL
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string? Phone {  get; set; }
        public string? ContactLName { get; set; }
        public string? ContactFName { get; set; }
        public int DefaultTermsID { get; set; }
        public int DefaultAccountNo { get; set; }
        public string LongAddress => $"{Name}.{Address1}." + ((Address2 != null) ? $"{Address2}.":"") + $"{City}.{State} {ZipCode}";
    }
}
