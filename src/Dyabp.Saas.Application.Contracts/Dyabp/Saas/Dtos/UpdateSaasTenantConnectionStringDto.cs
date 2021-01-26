using System;
using System.ComponentModel;

namespace Dyabp.Saas.Dtos
{
    [Serializable]
    public class UpdateSaasTenantConnectionStringDto
    {
        public Guid TenantId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}