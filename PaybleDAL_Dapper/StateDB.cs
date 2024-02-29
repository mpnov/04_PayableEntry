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
    public static class StateDB
    {
        public static List<State> GetStates()
        {
            List<State> states = new List<State>();
            string strSelect = "SELECT StateCode, StateName, FirstZipCode, LastZipCode " +
                "FROM States " +
                "ORDER BY StateCode";

            using SqlConnection connection = new SqlConnection(PayableDB.ConnectionString);
            states = connection.Query<State>(strSelect).ToList();

            return states;
        }
    }
}
