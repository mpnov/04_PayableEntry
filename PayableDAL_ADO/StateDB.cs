using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PayableDAL_ADO
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
            using SqlCommand command = new SqlCommand(strSelect, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while(reader.Read())
            {
                State state = new State();
                state.StateCode = reader["StateCode"].ToString();
                state.StateName = reader["StateName"].ToString();
                state.FirstZipCode = (int)reader["FirstZipCode"];
                state.LastZipCode = (int)reader["LastZipCode"];
                states.Add(state);
            }

            return states;
        }
    }
}
