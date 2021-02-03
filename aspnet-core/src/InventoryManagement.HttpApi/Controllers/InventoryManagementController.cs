using System.Collections.Generic;
using InventoryManagement.Application.Contracts.Enumerations;
using InventoryManagement.Localization;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public ActionResult<IEnumerable<EnumerationDto>> GetAllEnumerations()
        {
            return Ok();
        }
    }
}