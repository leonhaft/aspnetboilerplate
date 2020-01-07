using System.Threading.Tasks;
using AdventureWorks.Configuration.Dto;

namespace AdventureWorks.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
