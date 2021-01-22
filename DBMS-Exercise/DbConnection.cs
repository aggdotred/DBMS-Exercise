using System;

namespace DBMS_Exercise
{
    public abstract class DbConnection 
    { 
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string _connectionString)
        {
            if ( _connectionString == "" || _connectionString == null)
            {
                throw new InvalidOperationException();
            } else
            {
                ConnectionString = _connectionString;
            }
        }

        public abstract void openConnection();
        public abstract void closeConnection();
    }
}
