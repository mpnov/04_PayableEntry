using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PayableDAL
{
    public static class Payable_UnitOfWork
    {
        public static bool AddInvoiceWithLineItems(Invoice invoice, List<InvoiceLineItem> items)
        {
            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            SqlTransaction transaction = null;

            //insert Invoice command
            string strInsertInvoice = "INSERT Invoices (" +
                "VendorID, InvoiceNumber, InvoiceDate, InvoiceTotal, PaymentTotal, CreditTotal, TermsID, DueDate, PaymentDate) " +
                "VALUES (" +
                "@VendorID, @InvoiceNumber, @InvoiceDate, @InvoiceTotal, @PaymentTotal, @CreditTotal, @TermsID, @DueDate, @PaymentDate);" +
                "SELECT SCOPE_IDENTITY();";
            using SqlCommand commandInvoice = new SqlCommand(strInsertInvoice, connection);
            commandInvoice.Parameters.AddWithValue("@VendorID", invoice.VendorID);
            commandInvoice.Parameters.AddWithValue("@InvoiceNumber", invoice.InvoiceNumber);
            commandInvoice.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
            commandInvoice.Parameters.AddWithValue("@InvoiceTotal", invoice.InvoiceTotal);
            commandInvoice.Parameters.AddWithValue("@PaymentTotal", invoice.PaymentTotal);
            commandInvoice.Parameters.AddWithValue("@CreditTotal", invoice.CreditTotal);
            commandInvoice.Parameters.AddWithValue("@TermsID", invoice.TermsID);
            commandInvoice.Parameters.AddWithValue("@DueDate", invoice.DueDate);            
            commandInvoice.Parameters.AddWithValue("@PaymentDate", invoice.PaymentDate == null ? DBNull.Value : invoice.PaymentDate);

            //insert InvoiceLineItem command
            string strInsertItem = "INSERT InvoiceLineItems (" +
                "InvoiceID, InvoiceSequence, AccountNo, Amount, Description) " +
                "VALUES (" +
                "@InvoiceID, @InvoiceSequence, @AccountNo, @Amount, @Description)";
            using SqlCommand commandItem = new SqlCommand(strInsertItem, connection);

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                //insert Invoice
                commandInvoice.Transaction = transaction;
                int InvoiceID = Convert.ToInt32( commandInvoice.ExecuteScalar());
                if(InvoiceID > 0 )
                {
                    // Insert all LineItems
                    commandItem.Transaction = transaction;
                    foreach(var item in items)
                    {
                        item.InvoiceID = InvoiceID;//set InvoiceID
                        //clear all previous Parameters
                        commandItem.Parameters.Clear();
                        //add parameters
                        commandItem.Parameters.AddWithValue("@InvoiceID", item.InvoiceID);
                        commandItem.Parameters.AddWithValue("@InvoiceSequence", item.InvoiceSequence);
                        commandItem.Parameters.AddWithValue("@AccountNo", item.AccountNo);
                        commandItem.Parameters.AddWithValue("@Amount", item.Amount);
                        commandItem.Parameters.AddWithValue("@Description", item.Description);
                        //insert LineItem
                        int countLineItem = commandItem.ExecuteNonQuery();
                        if(countLineItem == 0 ) 
                        {
                            transaction.Rollback();
                            throw new Exception($"Unable to insert Line Item No - {item.InvoiceSequence}");
                            return false;
                        }
                    }
                    //Invoice and all Line items are inserted
                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }            
        }
    }
}
