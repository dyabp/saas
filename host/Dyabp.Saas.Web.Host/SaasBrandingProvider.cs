using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dyabp.Saas
{
    [Dependency(ReplaceServices = true)]
    public class SaasBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Saas";
    }
}
