using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableDAL
{
    public class Term
    {
        public int TermsID { get; set; }
        public string Description { get; set; }
        public int DueDays { get; set; }
    }
}
