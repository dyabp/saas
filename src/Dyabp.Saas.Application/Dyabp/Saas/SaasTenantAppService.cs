using System;
using Dyabp.Saas.Permissions;
using Dyabp.Saas.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dyabp.Saas
{
    public class SaasTenantAppService : CrudAppService<SaasTenant, SaasTenantDto, Guid, PagedAndSortedResultRequestDto, CreateSaasTenantDto, UpdateSaasTenantDto>,
        ISaasTenantAppService
    {
        protected override string GetPolicyName { get; set; } = SaasPermissions.SaasTenant.Default;
        protected override string GetListPolicyName { get; set; } = SaasPermissions.SaasTenant.Default;
        protected override string CreatePolicyName { get; set; } = SaasPermissions.SaasTenant.Create;
        protected override string UpdatePolicyName { get; set; } = SaasPermissions.SaasTenant.Update;
        protected override string DeletePolicyName { get; set; } = SaasPermissions.SaasTenant.Delete;

        private readonly ISaasTenantRepository _repository;
        
        public SaasTenantAppService(ISaasTenantRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
