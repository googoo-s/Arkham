using Arkham.EntityFrameworkCore.EntityFrameworkCore;

using Volo.Abp.Modularity;

namespace Arkham.Domain;

[DependsOn(
    typeof(ArkhamEntityFrameworkCoreTestModule)
    )]
public class ArkhamDomainTestModule : AbpModule
{
}
