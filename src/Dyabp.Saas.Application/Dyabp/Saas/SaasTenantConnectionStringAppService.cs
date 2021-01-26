using System;
using System.Linq;
using System.Threading.Tasks;
using Dyabp.Saas.Permissions;
using Dyabp.Saas.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dyabp.Saas
{
    public class SaasTenantConnectionStringAppService : AbstractKeyCrudAppService<SaasTenantConnectionString, SaasTenantConnectionStringDto, SaasTenantConnectionStringKey, PagedAndSortedResultRequestDto, CreateSaasTenantConnectionStringDto, UpdateSaasTenantConnectionStringDto>,
        ISaasTenantConnectionStringAppService
    {
        protected override string GetPolicyName { get; set; } = SaasPermissions.SaasTenantConnectionString.Default;
        protected override string GetListPolicyName { get; set; } = SaasPermissions.SaasTenantConnectionString.Default;
        protected override string CreatePolicyName { get; set; } = SaasPermissions.SaasTenantConnectionString.Create;
        protected override string UpdatePolicyName { get; set; } = SaasPermissions.SaasTenantConnectionString.Update;
        protected override string DeletePolicyName { get; set; } = SaasPermissions.SaasTenantConnectionString.Delete;

        private readonly ISaasTenantConnectionStringRepository _repository;
        
        public SaasTenantConnectionStringAppService(ISaasTenantConnectionStringRepository repository) : base(repository)
        {
            _repository = repository;
        }
        
        protected override Task DeleteByIdAsync(SaasTenantConnectionStringKey id)
        {
            // TODO: AbpHelper generated
            return _repository.DeleteAsync(e =>
                e.TenantId == id.TenantId &&
                e.Name == id.Name
            );
        }

        protected override async Task<SaasTenantConnectionString> GetEntityByIdAsync(SaasTenantConnectionStringKey id)
        {
            // TODO: AbpHelper generated
            return await AsyncExecuter.FirstOrDefaultAsync(
                _repository.Where(e =>
                    e.TenantId == id.TenantId &&
                    e.Name == id.Name
                )
            ); 
        }
    }
}
