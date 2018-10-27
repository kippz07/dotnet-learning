using System;

namespace PolymorphismExercises
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException();
            
            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException();

            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            System.Console.WriteLine(_instruction);
            _dbConnection.Close();
        }
    }
}
