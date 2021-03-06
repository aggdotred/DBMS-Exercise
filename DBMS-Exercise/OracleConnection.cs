﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBMS_Exercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override void openConnection()
        {
            Console.WriteLine("Opening Oracle connection...");
        }

        public override void closeConnection()
        {
            Console.WriteLine("Closing Oracle connection...");
        }
    }
}
