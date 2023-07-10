using Arkham.Domain;
using Arkham.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace Arkham.EntityFrameworkCore;

[DependsOn(
    typeof(ArkhamDomainModule),
    typeof(AbpEntityFrameworkCoreMySQLModule)
)]
public class ArkhamEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        _ = context.Services.AddAbpDbContext<ArkhamDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            _ = options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also ArkhamMigrationsDbContextFactory for EF Core tooling. */
            options.UseMySQL();
        });
    }
}
