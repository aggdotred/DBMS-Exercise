using System;

namespace DBMS_Exercise
{
    public abstract class DbConnection 
    { 
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if (connectionString == "" || connectionString == null)
            {
                throw new InvalidOperationException("The connection string cannot be empty or null");
            } else
            {
                ConnectionString = connectionString;
            }
        }

        public abstract void openConnection();
        public abstract void closeConnection();
    }
}
