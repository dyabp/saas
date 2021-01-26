using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Dyabp.Saas
{
    public class SaasEditionAppServiceTests : SaasApplicationTestBase
    {
        private readonly ISaasEditionAppService _saasEditionAppService;

        public SaasEditionAppServiceTests()
        {
            _saasEditionAppService = GetRequiredService<ISaasEditionAppService>();
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
