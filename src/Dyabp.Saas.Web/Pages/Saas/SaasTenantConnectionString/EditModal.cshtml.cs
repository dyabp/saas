using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenantConnectionString.ViewModels;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenantConnectionString
{
    public class EditModalModel : SaasPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public SaasTenantConnectionStringKey Id { get; set; }

        [BindProperty]
        public EditSaasTenantConnectionStringViewModel ViewModel { get; set; }

        private readonly ISaasTenantConnectionStringAppService _service;

        public EditModalModel(ISaasTenantConnectionStringAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SaasTenantConnectionStringDto, EditSaasTenantConnectionStringViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditSaasTenantConnectionStringViewModel, UpdateSaasTenantConnectionStringDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}