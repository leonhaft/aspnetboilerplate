using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AdventureWorks.Configuration;
using AdventureWorks.Web;

namespace AdventureWorks.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AdventureWorksDbContextFactory : IDesignTimeDbContextFactory<AdventureWorksDbContext>
    {
        public AdventureWorksDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AdventureWorksDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AdventureWorksDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AdventureWorksConsts.ConnectionStringName));

            return new AdventureWorksDbContext(builder.Options);
        }
    }
}
