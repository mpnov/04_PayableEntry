using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PayableDAL_ADO
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
            using SqlCommand command = new SqlCommand(strSelect, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Term term = new Term();
                term.TermsID = (int)reader["TermsID"];
                term.Descrtiption = reader["Description"].ToString();
                term.DueDays = Convert.ToInt32(reader["DueDays"]);
                terms.Add(term);
            }

            return terms;
        }
    }
}
