using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AdventureWorks.Authorization.Roles;
using AdventureWorks.Authorization.Users;
using AdventureWorks.MultiTenancy;

namespace AdventureWorks.EntityFrameworkCore
{
    public class AdventureWorksDbContext : AbpZeroDbContext<Tenant, Role, User, AdventureWorksDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AdventureWorksDbContext(DbContextOptions<AdventureWorksDbContext> options)
            : base(options)
        {
        }
    }
}
