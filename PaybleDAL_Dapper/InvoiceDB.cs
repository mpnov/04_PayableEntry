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
    public static class InvoiceDB
    {
        public static List<Invoice> GeVendorInvoices(int vendorID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string strSelect = "SELECT InvoiceID, VendorID, InvoiceNumber, InvoiceDate, InvoiceTotal, PaymentTotal, " +
                "CreditTotal, TermsID, DueDate, PaymentDate " +
                "FROM Invoices " +
                "WHERE VendorID = @VendorID " +
                "ORDER BY InvoiceDate";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            invoices = connection.Query<Invoice>(strSelect, new {vendorID}).ToList();

            return invoices; 
        }
    }
}
