using System;
using Volo.Abp.Application.Dtos;

namespace Dyabp.Saas.Dtos
{
    public class SaasTenantDto : ExtensibleEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}