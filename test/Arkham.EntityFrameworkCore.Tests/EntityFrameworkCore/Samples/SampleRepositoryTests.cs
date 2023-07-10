using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Arkham.EntityFrameworkCore.EntityFrameworkCore.Samples;

/* This is just an example test class.
 * Normally, you don't test ABP framework code
 * (like default AppUser repository IRepository<AppUser, Guid> here).
 * Only test your custom repository methods.
 */
public class SampleRepositoryTests : ArkhamEntityFrameworkCoreTestBase
{
    public SampleRepositoryTests()
    {
    }

    [Fact]
    public async Task Should_Query_AppUser()
    {
        /* Need to manually start Unit Of Work because
         * FirstOrDefaultAsync should be executed while db connection / context is available.
         */
        await WithUnitOfWorkAsync(async () =>
        {
        });
    }
}
