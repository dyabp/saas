using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasEdition.ViewModels;
using AutoMapper;

namespace Dyabp.Saas.Web
{
    public class SaasWebAutoMapperProfile : Profile
    {
        public SaasWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<SaasEditionDto, EditSaasEditionViewModel>();
            CreateMap<CreateSaasEditionViewModel, CreateSaasEditionDto>();
            CreateMap<EditSaasEditionViewModel, UpdateSaasEditionDto>();
        }
    }
}
