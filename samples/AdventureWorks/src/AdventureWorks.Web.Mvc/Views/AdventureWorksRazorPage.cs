using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AdventureWorks.Web.Views
{
    public abstract class AdventureWorksRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AdventureWorksRazorPage()
        {
            LocalizationSourceName = AdventureWorksConsts.LocalizationSourceName;
        }
    }
}
