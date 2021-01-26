using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace InventoryManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(InventoryManagementEntityFrameworkCoreModule)
        )]
    public class InventoryManagementEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<InventoryManagementMigrationsDbContext>();
        }
    }
}
