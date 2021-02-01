using InventoryManagement.Domain.Enumerations;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace InventoryManagement.EntityFrameworkCore
{
    public static class InventoryManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureInventoryManagement(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */
            builder.Entity<Enumeration>(b =>
                        {
                            b.ToTable(InventoryManagementConsts.DbTablePrefix + "Enumerations",
                                      InventoryManagementConsts.DbSchema);
                            b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(128);
                        });
            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(InventoryManagementConsts.DbTablePrefix + "YourEntities", InventoryManagementConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}