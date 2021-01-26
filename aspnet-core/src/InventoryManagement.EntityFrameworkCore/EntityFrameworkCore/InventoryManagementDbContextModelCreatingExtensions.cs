using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace InventoryManagement.EntityFrameworkCore
{
    public static class InventoryManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureInventoryManagement(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(InventoryManagementConsts.DbTablePrefix + "YourEntities", InventoryManagementConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}