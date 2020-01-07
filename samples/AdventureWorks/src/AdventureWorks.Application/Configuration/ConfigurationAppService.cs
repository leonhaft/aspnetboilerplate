using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AdventureWorks.Configuration.Dto;

namespace AdventureWorks.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdventureWorksAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
