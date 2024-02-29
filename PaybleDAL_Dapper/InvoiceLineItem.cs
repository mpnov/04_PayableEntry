using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableDAL
{
    public class InvoiceLineItem
    {
        public int InvoiceID { get; set; }
        public int InvoiceSequence { get; set; }
        public int AccountNo { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string AccountDescription { get; set; }
    }
}
