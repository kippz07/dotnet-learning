using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two ways to inisialise the logger
            // One to initialise straight in the parameters
            var dbMigrator = new DbMigrator(new Logger());

            // One to create a new variable and pass it in the parameters
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
