using System;
using Volo.Abp.Application.Dtos;

namespace Dyabp.Saas.Dtos
{
    public class SaasTenantDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public Guid? EditionId { get; set; }
    }
}