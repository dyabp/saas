using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Dyabp.Saas
{
    public class SaasTenantAppServiceTests : SaasApplicationTestBase
    {
        private readonly ISaasTenantAppService _saasTenantAppService;

        public SaasTenantAppServiceTests()
        {
            _saasTenantAppService = GetRequiredService<ISaasTenantAppService>();
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
