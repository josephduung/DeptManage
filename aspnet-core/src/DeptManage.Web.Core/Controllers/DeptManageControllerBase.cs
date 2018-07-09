using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DeptManage.Controllers
{
    public abstract class DeptManageControllerBase: AbpController
    {
        protected DeptManageControllerBase()
        {
            LocalizationSourceName = DeptManageConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
