using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DeptManage.Configuration;

namespace DeptManage.Web.Host.Startup
{
    [DependsOn(
       typeof(DeptManageWebCoreModule))]
    public class DeptManageWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DeptManageWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DeptManageWebHostModule).GetAssembly());
        }
    }
}
