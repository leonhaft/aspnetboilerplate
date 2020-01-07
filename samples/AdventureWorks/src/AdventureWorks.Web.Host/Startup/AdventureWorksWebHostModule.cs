using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdventureWorks.Configuration;

namespace AdventureWorks.Web.Host.Startup
{
    [DependsOn(
       typeof(AdventureWorksWebCoreModule))]
    public class AdventureWorksWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AdventureWorksWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdventureWorksWebHostModule).GetAssembly());
        }
    }
}
