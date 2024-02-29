using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace PayableDAL
{
    public static class TermDB
    {
        public static List<Term> GetTerms()
        {
            List<Term> terms = new List<Term>();
            string strSelect = "SELECT TermsID, Description, DueDays " +
                "FROM Terms " +
                "ORDER BY DueDays";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            terms = connection.Query<Term>(strSelect).ToList();

            return terms;
        }
    }
}
