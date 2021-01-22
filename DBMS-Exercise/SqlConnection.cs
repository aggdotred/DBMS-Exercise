using System;
using System.Collections.Generic;
using System.Text;

namespace DBMS_Exercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string _connectionString) : base(_connectionString)
        {
            ConnectionString = _connectionString;
        }

        public override void closeConnection()
        {
            Console.WriteLine("Closing SQL connection...");
        }

        public override void openConnection()
        {
            Console.WriteLine("Opening SQL connection...");
        }
    }
}
