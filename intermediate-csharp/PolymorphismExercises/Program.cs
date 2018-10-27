using System;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new OracleConnection("abcd"), "Do this");
            command.Execute();
        }
    }
}
