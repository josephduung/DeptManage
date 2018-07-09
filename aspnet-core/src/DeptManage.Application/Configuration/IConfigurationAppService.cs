using System.Threading.Tasks;
using DeptManage.Configuration.Dto;

namespace DeptManage.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
