using System;
using System.Collections.Generic;
using System.Text;

namespace DBMS_Exercise
{
    class DbCommand
    {
        DbConnection Connection;
        String Instruction;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || instruction == "" || instruction == null)
            {
                throw new InvalidOperationException("The Database Connection and Instruction cannot be null or empty.");
            }
            Connection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.openConnection();
            Console.WriteLine("Running instruction: {0}", Instruction);
            Connection.closeConnection();
        }
    }
}
