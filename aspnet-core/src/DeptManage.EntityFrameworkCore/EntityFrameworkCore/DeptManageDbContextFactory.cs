using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DeptManage.Configuration;
using DeptManage.Web;

namespace DeptManage.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DeptManageDbContextFactory : IDesignTimeDbContextFactory<DeptManageDbContext>
    {
        public DeptManageDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DeptManageDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DeptManageDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DeptManageConsts.ConnectionStringName));

            return new DeptManageDbContext(builder.Options);
        }
    }
}
