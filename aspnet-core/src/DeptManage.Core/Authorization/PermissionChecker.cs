using Abp.Authorization;
using DeptManage.Authorization.Roles;
using DeptManage.Authorization.Users;

namespace DeptManage.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
