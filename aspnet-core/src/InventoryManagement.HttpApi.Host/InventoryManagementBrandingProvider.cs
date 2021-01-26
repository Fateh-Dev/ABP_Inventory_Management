using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace InventoryManagement
{
    [Dependency(ReplaceServices = true)]
    public class InventoryManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "InventoryManagement";
    }
}
