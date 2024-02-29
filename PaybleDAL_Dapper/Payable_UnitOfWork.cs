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

            //insert InvoiceLineItem command
            string strInsertItem = "INSERT InvoiceLineItems (" +
                "InvoiceID, InvoiceSequence, AccountNo, Amount, Description) " +
                "VALUES (" +
                "@InvoiceID, @InvoiceSequence, @AccountNo, @Amount, @Description)";

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                //insert Invoice
                int InvoiceID = connection.Query<int>(strInsertInvoice, invoice, transaction:  transaction).FirstOrDefault();

                if (InvoiceID > 0)
                {
                    // Insert all LineItems
                    foreach (var item in items)
                    {
                        item.InvoiceID = InvoiceID;//set InvoiceID
                        int countLineItem = connection.Execute(strInsertItem, item, transaction: transaction);
                        if (countLineItem == 0)
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
