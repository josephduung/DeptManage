using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DeptManage.Roles.Dto;
using DeptManage.Users.Dto;

namespace DeptManage.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
