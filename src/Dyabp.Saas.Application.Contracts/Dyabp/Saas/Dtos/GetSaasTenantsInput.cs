using Volo.Abp.Application.Dtos;

namespace Dyabp.Saas.Dtos
{
    public class GetSaasTenantsInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}