namespace PolymorphismExercises
{
    public class SqlConnection : DbConnection
    {
        private string _connectionString;
        public SqlConnection(string connectionString) 
            : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Close()
        {
            System.Console.WriteLine("Closing SQL connection");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opening SQL connection with string {0}", _connectionString);
        }
    }
}
