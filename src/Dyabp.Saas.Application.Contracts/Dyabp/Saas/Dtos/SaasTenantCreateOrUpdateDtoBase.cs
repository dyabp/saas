using System.ComponentModel.DataAnnotations;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Validation;

namespace Dyabp.Saas.Dtos
{
    public abstract class SaasTenantCreateOrUpdateDtoBase : ExtensibleObject
    {
        [Required]
        [DynamicStringLength(typeof(SaasTenantConsts), nameof(SaasTenantConsts.MaxNameLength))]
        [Display(Name = "TenantName")]
        public string Name { get; set; }

        public SaasTenantCreateOrUpdateDtoBase() : base(false)
        {

        }
    }
}