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
    public static class GLAccountDB
    {
        public static List<GLAccount> GetAccounts()
        {
            List<GLAccount> accounts = new List<GLAccount>();
            string strSelect = "SELECT AccountNo, Description " +
                "FROM GLAccounts " +
                "ORDER BY Description";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            accounts = connection.Query<GLAccount>(strSelect).ToList();

            return accounts;
        }
    }
}
