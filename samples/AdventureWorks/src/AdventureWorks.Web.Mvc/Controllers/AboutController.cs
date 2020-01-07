using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AdventureWorks.Controllers;

namespace AdventureWorks.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AdventureWorksControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
