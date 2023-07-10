using Arkham.Domain;
using Volo.Abp.Modularity;

namespace Arkham.Application;

[DependsOn(
    typeof(ArkhamApplicationModule),
    typeof(ArkhamDomainTestModule)
    )]
public class ArkhamApplicationTestModule : AbpModule
{
}
