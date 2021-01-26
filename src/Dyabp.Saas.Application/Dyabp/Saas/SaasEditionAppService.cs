using System;
using Dyabp.Saas.Permissions;
using Dyabp.Saas.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dyabp.Saas
{
    public class SaasEditionAppService : CrudAppService<SaasEdition, SaasEditionDto, Guid, PagedAndSortedResultRequestDto, CreateSaasEditionDto, UpdateSaasEditionDto>,
        ISaasEditionAppService
    {
        protected override string GetPolicyName { get; set; } = SaasPermissions.SaasEdition.Default;
        protected override string GetListPolicyName { get; set; } = SaasPermissions.SaasEdition.Default;
        protected override string CreatePolicyName { get; set; } = SaasPermissions.SaasEdition.Create;
        protected override string UpdatePolicyName { get; set; } = SaasPermissions.SaasEdition.Update;
        protected override string DeletePolicyName { get; set; } = SaasPermissions.SaasEdition.Delete;

        private readonly ISaasEditionRepository _repository;
        
        public SaasEditionAppService(ISaasEditionRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
