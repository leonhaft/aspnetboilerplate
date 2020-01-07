using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using AdventureWorks.Authorization;
using AdventureWorks.Controllers;
using AdventureWorks.Roles;
using AdventureWorks.Roles.Dto;
using AdventureWorks.Web.Models.Roles;

namespace AdventureWorks.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class RolesController : AdventureWorksControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        public async Task<IActionResult> Index()
        {
            var roles = (await _roleAppService.GetRolesAsync(new GetRolesInput())).Items;
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new RoleListViewModel
            {
                Roles = roles,
                Permissions = permissions
            };

            return View(model);
        }

        public async Task<ActionResult> EditRoleModal(int roleId)
        {
            var output = await _roleAppService.GetRoleForEdit(new EntityDto(roleId));
            var model = ObjectMapper.Map<EditRoleModalViewModel>(output);

            return View("_EditRoleModal", model);
        }
    }
}
