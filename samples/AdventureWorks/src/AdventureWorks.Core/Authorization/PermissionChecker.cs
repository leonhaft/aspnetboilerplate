using Abp.Authorization;
using AdventureWorks.Authorization.Roles;
using AdventureWorks.Authorization.Users;

namespace AdventureWorks.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
