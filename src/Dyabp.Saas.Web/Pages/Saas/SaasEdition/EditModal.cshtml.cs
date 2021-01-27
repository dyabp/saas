using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasEdition.ViewModels;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasEdition
{
    public class EditModalModel : SaasPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditSaasEditionViewModel ViewModel { get; set; }

        private readonly ISaasEditionAppService _service;

        public EditModalModel(ISaasEditionAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SaasEditionDto, EditSaasEditionViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditSaasEditionViewModel, UpdateSaasEditionDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}