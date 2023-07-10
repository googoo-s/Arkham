using Arkham.Application.Contracts;

using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Arkham.HttpApi;
[DependsOn(
    typeof(ArkhamApplicationContractsModule),
    typeof(AbpAutoMapperModule)
)]
public class ArkhamHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        Configure<AbpAutoMapperOptions>(options => options.AddMaps<ArkhamHttpApiModule>());
    }
}
