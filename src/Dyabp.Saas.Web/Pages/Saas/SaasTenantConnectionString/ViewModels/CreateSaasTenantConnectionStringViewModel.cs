using System;

using System.ComponentModel.DataAnnotations;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenantConnectionString.ViewModels
{
    public class CreateSaasTenantConnectionStringViewModel
    {
        [Display(Name = "SaasTenantConnectionStringTenantId")]
        public Guid TenantId { get; set; }

        [Display(Name = "SaasTenantConnectionStringName")]
        public string Name { get; set; }

        [Display(Name = "SaasTenantConnectionStringValue")]
        public string Value { get; set; }
    }
}