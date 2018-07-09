using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DeptManage.Authorization.Roles;
using DeptManage.Authorization.Users;
using DeptManage.MultiTenancy;

namespace DeptManage.EntityFrameworkCore
{
    public class DeptManageDbContext : AbpZeroDbContext<Tenant, Role, User, DeptManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DeptManageDbContext(DbContextOptions<DeptManageDbContext> options)
            : base(options)
        {
        }
    }
}
