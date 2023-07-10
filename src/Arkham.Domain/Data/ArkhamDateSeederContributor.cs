using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Arkham.Domain.Data;

public class ArkhamDataSeederContributor : IDataSeedContributor, ITransientDependency
{
    public Task SeedAsync(DataSeedContext context)
    {
        throw new NotImplementedException();

        // todo 数据种子
    }
}
