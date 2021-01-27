using System.ComponentModel.DataAnnotations;
using Volo.Abp.Validation;

namespace Dyabp.Saas.Dtos
{
    public class CreateSaasTenantDto : SaasTenantCreateOrUpdateDtoBase
    {
        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public virtual string AdminEmailAddress { get; set; }

        [Required]
        [MaxLength(128)]
        public virtual string AdminPassword { get; set; }
    }
}