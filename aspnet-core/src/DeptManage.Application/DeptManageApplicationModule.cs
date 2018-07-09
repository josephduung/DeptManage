using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DeptManage.Authorization;

namespace DeptManage
{
    [DependsOn(
        typeof(DeptManageCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DeptManageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DeptManageAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DeptManageApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
