using Microsoft.EntityFrameworkCore;

using Volo.Abp.EntityFrameworkCore;

namespace Arkham.EntityFrameworkCore.EntityFrameworkCore;
public class ArkhamDbContext : AbpDbContext<ArkhamDbContext>
{
    public ArkhamDbContext(DbContextOptions<ArkhamDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);
    }
}
