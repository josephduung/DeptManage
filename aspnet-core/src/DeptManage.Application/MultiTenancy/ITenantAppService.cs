using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DeptManage.MultiTenancy.Dto;

namespace DeptManage.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
