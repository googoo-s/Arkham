using Arkham.Application.Contracts;

using Volo.Abp.Modularity;

namespace Arkham.HttpApi.Client;
[DependsOn(
    typeof(ArkhamApplicationContractsModule)
)]
public class ArkhamHttpApiClientModule : AbpModule
{
}
