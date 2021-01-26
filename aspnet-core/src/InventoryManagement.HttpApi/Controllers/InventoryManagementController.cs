using InventoryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class InventoryManagementController : AbpController
    {
        protected InventoryManagementController()
        {
            LocalizationResource = typeof(InventoryManagementResource);
        }
    }
}