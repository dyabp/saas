using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenant.ViewModels
{
    public class CreateSaasTenantViewModel
    {
        [Display(Name = "SaasTenantName")]
        public string Name { get; set; }

        [Display(Name = "SaasTenantEditionId")]
        public Guid? EditionId { get; set; }
    }
}