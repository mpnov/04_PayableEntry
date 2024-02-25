using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PayableDAL_ADO
{
    public static class GLAccountDB
    {
        public static List<GLAccount> GetAccounts()
        {
            List<GLAccount> accounts = new List<GLAccount>();
            string strSelect = "SELECT AccountNo, Description " +
                "FROM GLAccounts " +
                "ORDER BY Description";
            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            using SqlCommand command = new SqlCommand(strSelect, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                GLAccount account = new GLAccount();
                account.AccountNo = (int)reader["AccountNo"];
                account.Description = reader["Description"].ToString();
                accounts.Add(account);
            }

            return accounts;
        }
    }
}
