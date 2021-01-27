using System;
using Volo.Abp.Application.Dtos;

namespace Dyabp.Saas.Dtos
{
    public class SaasTenantConnectionStringDto : EntityDto
    {
        public Guid TenantId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}