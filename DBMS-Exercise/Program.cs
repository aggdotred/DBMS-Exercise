using System;

namespace DBMS_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("sqlconnection");
            OracleConnection oracleConnection = new OracleConnection("oracleconnection");

            oracleConnection.openConnection();
            sqlConnection.openConnection();

            oracleConnection.closeConnection();
            sqlConnection.closeConnection();
        }
    }
}
