using Volo.Abp.Application.Dtos;

namespace Dyabp.Saas.Dtos
{
    public class GetSaasEditionsInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}