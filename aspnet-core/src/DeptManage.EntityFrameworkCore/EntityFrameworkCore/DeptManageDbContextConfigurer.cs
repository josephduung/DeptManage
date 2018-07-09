using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DeptManage.EntityFrameworkCore
{
    public static class DeptManageDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DeptManageDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DeptManageDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
