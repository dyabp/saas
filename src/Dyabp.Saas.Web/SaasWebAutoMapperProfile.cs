using AutoMapper;
using Volo.Abp.AutoMapper;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.SaasEdition.ViewModels;
using Dyabp.Saas.Web.Pages.Saas.SaasTenant.ViewModels;
using Dyabp.Saas.Web.Pages.Saas.SaasTenantConnectionString.ViewModels;

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

            CreateMap<SaasTenantConnectionStringDto, EditSaasTenantConnectionStringViewModel>();
            CreateMap<CreateSaasTenantConnectionStringViewModel, CreateSaasTenantConnectionStringDto>();
            CreateMap<EditSaasTenantConnectionStringViewModel, UpdateSaasTenantConnectionStringDto>();

            CreateMap<SaasTenantDto, EditSaasTenantViewModel>();
            CreateMap<CreateSaasTenantViewModel, CreateSaasTenantDto>()
                .MapExtraProperties();
            CreateMap<EditSaasTenantViewModel, UpdateSaasTenantDto>()
                .MapExtraProperties();
        }
    }
}
