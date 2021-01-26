using System;
using System.Threading.Tasks;
using Dyabp.Saas;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Dyabp.Saas.EntityFrameworkCore.Dyabp.Saas
{
    public class SaasTenantConnectionStringRepositoryTests : SaasEntityFrameworkCoreTestBase
    {
        private readonly ISaasTenantConnectionStringRepository _saasTenantConnectionStringRepository;

        public SaasTenantConnectionStringRepositoryTests()
        {
            _saasTenantConnectionStringRepository = GetRequiredService<ISaasTenantConnectionStringRepository>();
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
