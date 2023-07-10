using Arkham.Application.Contracts;
using Arkham.Domain;
using Arkham.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Arkham.DbMigrator;

[DependsOn(
    typeof(ArkhamDomainModule),
    typeof(ArkhamApplicationContractsModule),
    typeof(ArkhamEntityFrameworkCoreModule),
    typeof(AbpAutofacModule)
)]
public class ArkhamDbMigratorModule : AbpModule
{
}
