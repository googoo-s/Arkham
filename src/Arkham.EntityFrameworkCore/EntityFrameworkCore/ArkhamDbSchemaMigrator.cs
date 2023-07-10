using Arkham.Domain.Data;
using Arkham.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

public class ArkhamDbSchemaMigrator : IArkhamDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public ArkhamDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ArkhamDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ArkhamDbContext>()
            .Database
            .MigrateAsync();
    }
}
