using System;
using System.Threading.Tasks;
using Dyabp.Saas;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Dyabp.Saas.EntityFrameworkCore.Dyabp.Saas
{
    public class SaasEditionRepositoryTests : SaasEntityFrameworkCoreTestBase
    {
        private readonly ISaasEditionRepository _saasEditionRepository;

        public SaasEditionRepositoryTests()
        {
            _saasEditionRepository = GetRequiredService<ISaasEditionRepository>();
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
