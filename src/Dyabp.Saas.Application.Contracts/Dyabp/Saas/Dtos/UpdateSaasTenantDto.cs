using System;
using System.ComponentModel;

namespace Dyabp.Saas.Dtos
{
    [Serializable]
    public class UpdateSaasTenantDto
    {
        public string Name { get; set; }

        public Guid? EditionId { get; set; }
    }
}