using System.Collections.Generic;
using AdventureWorks.Roles.Dto;
using AdventureWorks.Users.Dto;

namespace AdventureWorks.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
