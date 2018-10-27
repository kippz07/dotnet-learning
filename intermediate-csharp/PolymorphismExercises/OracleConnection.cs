namespace PolymorphismExercises
{
    public class OracleConnection : DbConnection
    {
        private string _connectionString;
        
        public OracleConnection(string connectionString) 
            : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Close()
        {
            System.Console.WriteLine("Closing Oracle connection");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opening Oracle connection with string {0}", _connectionString);
        }
    }
}
