using System;
using System.Collections.Generic;

namespace Dyabp.Saas.Dtos
{
    [Serializable]
    public class CreateSaasTenantDto
    {
        public string Name { get; set; }

        public Guid? EditionId { get; set; }
    }
}