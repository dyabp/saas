using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.SaasEdition.ViewModels;

namespace Dyabp.Saas.Web.Pages.Saas.SaasEdition
{
    public class CreateModalModel : SaasPageModel
    {
        [BindProperty]
        public CreateSaasEditionViewModel ViewModel { get; set; }

        private readonly ISaasEditionAppService _service;

        public CreateModalModel(ISaasEditionAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateSaasEditionViewModel, CreateSaasEditionDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}