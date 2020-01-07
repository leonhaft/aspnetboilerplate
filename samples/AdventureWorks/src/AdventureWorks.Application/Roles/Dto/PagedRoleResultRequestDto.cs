using Abp.Application.Services.Dto;

namespace AdventureWorks.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

