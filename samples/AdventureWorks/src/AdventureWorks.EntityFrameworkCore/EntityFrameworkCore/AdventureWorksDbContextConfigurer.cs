using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.EntityFrameworkCore
{
    public static class AdventureWorksDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AdventureWorksDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AdventureWorksDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
