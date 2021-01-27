using System;

using System.ComponentModel.DataAnnotations;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasEdition.ViewModels
{
    public class CreateSaasEditionViewModel
    {
        [Display(Name = "SaasEditionDisplayName")]
        public string DisplayName { get; set; }
    }
}