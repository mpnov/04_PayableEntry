using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace PayableDAL
{
    public static class InvoiceLineItemDB
    {
        public static List<InvoiceLineItem> GetInvoiceLineItems(int invoiceID)
        {
            List<InvoiceLineItem> items = new List<InvoiceLineItem>();
            string strSelect = "SELECT InvoiceID, InvoiceSequence, li.AccountNo AS AccountNo, Amount, " +
                    "li.Description AS Description, a.Description AS AccountDescription  " +
                "FROM InvoiceLineItems AS li JOIN GLAccounts AS a ON li.AccountNo = a.AccountNo " +
                "WHERE InvoiceID = @InvoiceID " +
                "ORDER BY InvoiceSequence";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            items = connection.Query<InvoiceLineItem>(strSelect, new { InvoiceID = invoiceID }).ToList();

            return items;
        }
    }
}
