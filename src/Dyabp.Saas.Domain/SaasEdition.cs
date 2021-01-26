using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dyabp.Saas
{
    public class SaasEdition : FullAuditedAggregateRoot<Guid>
    {
        public virtual string DisplayName { get; protected set; }
        protected SaasEdition()
        {
        }
        protected internal SaasEdition(Guid id, [NotNull] string diaplayName)
        {
            Id = id;
            SetDisplayName(diaplayName);
        }
        protected internal virtual void SetDisplayName([NotNull] string diaplayName)
        {
            DisplayName = Check.NotNullOrWhiteSpace(diaplayName, nameof(diaplayName), SaasEditionConsts.MaxNameLength);
        }
    }
}
