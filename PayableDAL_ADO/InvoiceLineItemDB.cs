using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PayableDAL_ADO
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
            using SqlCommand command = new SqlCommand(strSelect, connection);
            command.Parameters.AddWithValue("InvoiceID", invoiceID);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while(reader.Read())
            {
                InvoiceLineItem item = new InvoiceLineItem();
                item.InvoiceID = (int)reader["InvoiceID"];
                item.InvoiceSequence = Convert.ToInt32(reader["InvoiceSequence"]);
                item.AccountNo = (int)reader["AccountNo"];
                item.Amount = Convert.ToDecimal(reader["Amount"]);
                item.Description = reader["Description"].ToString();
                item.AccountDescription = reader["AccountDescription"].ToString();
                items.Add(item);
            }
            return items;
        }
    }
}
