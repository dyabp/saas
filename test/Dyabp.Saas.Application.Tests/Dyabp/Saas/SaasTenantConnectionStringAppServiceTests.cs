using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Dyabp.Saas
{
    public class SaasTenantConnectionStringAppServiceTests : SaasApplicationTestBase
    {
        private readonly ISaasTenantConnectionStringAppService _saasTenantConnectionStringAppService;

        public SaasTenantConnectionStringAppServiceTests()
        {
            _saasTenantConnectionStringAppService = GetRequiredService<ISaasTenantConnectionStringAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
