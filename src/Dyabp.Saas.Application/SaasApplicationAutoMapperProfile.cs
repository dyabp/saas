using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using AutoMapper;

namespace Dyabp.Saas
{
    public class SaasApplicationAutoMapperProfile : Profile
    {
        public SaasApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<SaasEdition, SaasEditionDto>();

            CreateMap<CreateSaasEditionDto, SaasEdition>(MemberList.Source);
            CreateMap<UpdateSaasEditionDto, SaasEdition>(MemberList.Source);
            CreateMap<SaasTenantConnectionString, SaasTenantConnectionStringDto>();
            CreateMap<CreateSaasTenantConnectionStringDto, SaasTenantConnectionString>(MemberList.Source);
            CreateMap<UpdateSaasTenantConnectionStringDto, SaasTenantConnectionString>(MemberList.Source);

            CreateMap<SaasTenant, SaasTenantDto>().MapExtraProperties();
        }
    }
}
