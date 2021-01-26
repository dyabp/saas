using System;
using System.Threading.Tasks;
using Dyabp.Saas;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Dyabp.Saas.EntityFrameworkCore.Dyabp.Saas
{
    public class SaasTenantRepositoryTests : SaasEntityFrameworkCoreTestBase
    {
        private readonly ISaasTenantRepository _saasTenantRepository;

        public SaasTenantRepositoryTests()
        {
            _saasTenantRepository = GetRequiredService<ISaasTenantRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
