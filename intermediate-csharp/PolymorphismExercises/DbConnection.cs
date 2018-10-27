using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException();

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}