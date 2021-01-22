using System;

namespace DBMS_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("sqlconnection");
            OracleConnection oracleConnection = new OracleConnection("oracleconnection");

            DbCommand sqlCommand = new DbCommand(sqlConnection, "run sql");
            DbCommand oracleCommand = new DbCommand(oracleConnection, "run oracle");

            sqlCommand.Execute();
            oracleCommand.Execute();
        }
    }
}
