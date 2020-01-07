using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AdventureWorks.Controllers
{
    public abstract class AdventureWorksControllerBase: AbpController
    {
        protected AdventureWorksControllerBase()
        {
            LocalizationSourceName = AdventureWorksConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
