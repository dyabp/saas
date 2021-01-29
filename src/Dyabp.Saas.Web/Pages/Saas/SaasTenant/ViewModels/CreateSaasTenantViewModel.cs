using System.ComponentModel.DataAnnotations;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Validation;

namespace Dyabp.Saas.Web.Pages.Saas.SaasTenant.ViewModels
{
    public class CreateSaasTenantViewModel : ExtensibleObject
    {
        [Required]
        [DynamicStringLength(typeof(SaasTenantConsts), nameof(SaasTenantConsts.MaxNameLength))]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string AdminEmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(128)]
        public string AdminPassword { get; set; }
    }
}