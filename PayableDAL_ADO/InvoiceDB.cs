using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

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
            using SqlCommand command = new SqlCommand(strSelect, connection);
            command.Parameters.AddWithValue("@VendorID", vendorID);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Invoice invoice = new Invoice();
                invoice.InvoiceID = (int)reader["InvoiceID"];
                invoice.VendorID = (int)reader["VendorID"];
                invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                invoice.InvoiceDate = Convert.ToDateTime(reader["InvoiceDate"]);
                invoice.InvoiceTotal = Convert.ToDecimal(reader["InvoiceTotal"]);
                invoice.PaymentTotal = Convert.ToDecimal(reader["PaymentTotal"]);
                invoice.CreditTotal = Convert.ToDecimal(reader["CreditTotal"]);
                invoice.TermsID = (int)reader["TermsID"];
                invoice.DueDate = Convert.ToDateTime(reader["DueDate"]);
                invoice.PaymentDate = reader["PaymentDate"] == DBNull.Value ? new DateTime() : Convert.ToDateTime(reader["PaymentDate"]);
                invoices.Add(invoice);
            }

            return invoices; 
        }
    }
}
