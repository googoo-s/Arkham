using Arkham.Domain.Shared;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Arkham.Domain;
[DependsOn(
    typeof(ArkhamDomainSharedModule),
    typeof(AbpAutoMapperModule)
)]
public class ArkhamDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<ArkhamDomainModule>());
    }
}
