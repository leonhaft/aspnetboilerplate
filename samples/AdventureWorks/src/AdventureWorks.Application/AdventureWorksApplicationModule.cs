using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdventureWorks.Authorization;

namespace AdventureWorks
{
    [DependsOn(
        typeof(AdventureWorksCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AdventureWorksApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AdventureWorksAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AdventureWorksApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
