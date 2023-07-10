using Arkham.Domain.Shared;
using Volo.Abp.Modularity;
namespace Arkham.Application.Contracts;

[DependsOn(
    typeof(ArkhamDomainSharedModule)
)]
public class ArkhamApplicationContractsModule : AbpModule
{
}
