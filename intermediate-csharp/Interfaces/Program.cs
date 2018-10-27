using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger("/Users/jjohns944/Documents/Other/dotnet/intermediate-csharp/Interfaces/log.txt"));
            dbMigrator.Migrate();
        }
    }
}
