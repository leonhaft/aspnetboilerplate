using System.Threading.Tasks;
using Abp.Application.Services;
using AdventureWorks.Sessions.Dto;

namespace AdventureWorks.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
