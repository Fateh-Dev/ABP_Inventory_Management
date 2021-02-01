using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagement.Domain.Enumerations
{
    public class Enumeration: AuditedAggregateRoot<Guid>
    {
        public int Code { get; set; }
        public string Value { get; set; }
        [ForeignKey("Enumeration")]
        public Guid? IdParent { get; set; }
        public string DisplayFr { get; set; }
    }
}