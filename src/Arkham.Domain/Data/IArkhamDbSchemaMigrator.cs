namespace Arkham.Domain.Data;

public interface IArkhamDbSchemaMigrator
{
    Task MigrateAsync();
}
