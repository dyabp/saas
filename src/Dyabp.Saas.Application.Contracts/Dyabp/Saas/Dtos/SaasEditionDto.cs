using System;
using Volo.Abp.Application.Dtos;

namespace Dyabp.Saas.Dtos
{
    public class SaasEditionDto : FullAuditedEntityDto<Guid>
    {
        public string DisplayName { get; set; }
    }
}