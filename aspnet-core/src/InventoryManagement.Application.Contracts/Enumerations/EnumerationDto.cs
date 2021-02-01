using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Application.Contracts.Enumerations
{
    public class EnumerationDto: AuditedEntityDto<Guid>
    {
        public int Code { get; set; }
        public string Value { get; set; }
        [ForeignKey("Enumeration")]
        public Guid? IdParent { get; set; }
        public string DisplayFr { get; set; }
    }
}