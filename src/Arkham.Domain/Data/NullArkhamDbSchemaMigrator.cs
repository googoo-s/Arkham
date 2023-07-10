using Volo.Abp.DependencyInjection;

namespace Arkham.Domain.Data;

public class NullArkhamDbSchemaMigrator : IArkhamDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
