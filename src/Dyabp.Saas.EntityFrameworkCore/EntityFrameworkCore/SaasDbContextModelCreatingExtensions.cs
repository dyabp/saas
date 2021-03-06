using Dyabp.Saas;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Dyabp.Saas.EntityFrameworkCore
{
    public static class SaasDbContextModelCreatingExtensions
    {
        public static void ConfigureSaas(
            this ModelBuilder builder,
            Action<SaasModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SaasModelBuilderConfigurationOptions(
                SaasDbProperties.DbTablePrefix,
                SaasDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<SaasEdition>(b =>
            {
                b.ToTable(options.TablePrefix + "SaasEditions", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<SaasTenantConnectionString>(b =>
            {
                b.ToTable(options.TablePrefix + "SaasTenantConnectionStrings", options.Schema);
                b.ConfigureByConvention(); 
                
                b.HasKey(e => new
                {
                    e.TenantId,
                    e.Name,
                });

                /* Configure more properties here */
            });


            builder.Entity<SaasTenant>(b =>
            {
                b.ToTable(options.TablePrefix + "SaasTenants", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
