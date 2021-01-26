using System;
using Dyabp.Saas.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dyabp.Saas
{
    public interface ISaasTenantConnectionStringAppService :
        ICrudAppService< 
            SaasTenantConnectionStringDto, 
            SaasTenantConnectionStringKey, 
            PagedAndSortedResultRequestDto,
            CreateSaasTenantConnectionStringDto,
            UpdateSaasTenantConnectionStringDto>
    {

    }
}