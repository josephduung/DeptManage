using System.Threading.Tasks;
using Abp.Application.Services;
using DeptManage.Sessions.Dto;

namespace DeptManage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
