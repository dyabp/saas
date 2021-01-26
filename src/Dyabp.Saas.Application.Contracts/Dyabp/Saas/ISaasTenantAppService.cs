using System;
using Dyabp.Saas.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dyabp.Saas
{
    public interface ISaasTenantAppService :
        ICrudAppService< 
            SaasTenantDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateSaasTenantDto,
            UpdateSaasTenantDto>
    {

    }
}