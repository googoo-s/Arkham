using Arkham.Application.Contracts;
using Arkham.Domain;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Arkham.Application;

[DependsOn(
    typeof(ArkhamDomainModule),
    typeof(ArkhamApplicationContractsModule),
    typeof(AbpAutoMapperModule)
)]
public class ArkhamApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<ArkhamApplicationModule>());
    }
}
