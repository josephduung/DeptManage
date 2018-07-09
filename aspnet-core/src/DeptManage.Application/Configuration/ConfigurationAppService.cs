using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DeptManage.Configuration.Dto;

namespace DeptManage.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DeptManageAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
