using Abp.AspNetCore.Mvc.ViewComponents;

namespace AdventureWorks.Web.Views
{
    public abstract class AdventureWorksViewComponent : AbpViewComponent
    {
        protected AdventureWorksViewComponent()
        {
            LocalizationSourceName = AdventureWorksConsts.LocalizationSourceName;
        }
    }
}
