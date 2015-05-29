using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace DatabaseConnectie
{
    public class newDataBaseConnection
    {
        public newDataBaseConnection()
        {
        }
        public string Procedure_ASSERT_EQUALS(string actual, string expected)
        {
            using (OracleConnection conn = new OracleConnection("User Id=system;Password=root;Data Source=//127.0.0.1:1521/XE;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                OracleCommand cmd = new OracleCommand("ASSERT_EQUALS", conn);


                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new OracleParameter("@actual", actual));
                cmd.Parameters.Add(new OracleParameter("@expected", expected));

                // execute the command
                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    return "gelukt";
                }

            }
        }
    }
}

