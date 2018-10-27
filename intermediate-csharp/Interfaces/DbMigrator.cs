using System;

namespace Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            // Dependancy injection
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            // Some code
            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
        
    }
}
