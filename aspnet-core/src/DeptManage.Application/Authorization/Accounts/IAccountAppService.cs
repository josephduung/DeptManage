using System.Threading.Tasks;
using Abp.Application.Services;
using DeptManage.Authorization.Accounts.Dto;

namespace DeptManage.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
