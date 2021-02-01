using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Application.Contracts.Enumerations
{
    public class CreateUpdateEnumerationDto
    {
        [Required]
        public int Code { get; set; }

        [Required] 
        public string Value { get; set; }
        public Guid? IdParent { get; set; }
        [Required]
        public string DisplayFr { get; set; }
    }
}