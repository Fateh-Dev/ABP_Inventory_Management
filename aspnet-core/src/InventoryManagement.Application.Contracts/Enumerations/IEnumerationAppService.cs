using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Application.Contracts.Enumerations
{
    public interface IEnumerationAppService

      : Volo.Abp.Application.Services.ICrudAppService< //Defines CRUD methods
            EnumerationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEnumerationDto> //Used to create/update a book
    {
    }
}