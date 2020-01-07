using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AdventureWorks.MultiTenancy.Dto;

namespace AdventureWorks.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

