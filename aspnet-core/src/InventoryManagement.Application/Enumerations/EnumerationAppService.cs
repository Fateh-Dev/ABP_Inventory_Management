using System;
using InventoryManagement.Application.Contracts.Enumerations;
using InventoryManagement.Domain.Enumerations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Application.Enumerations
{
    public class EnumerationAppService:
       CrudAppService<
            Enumeration, //The Book entity
            EnumerationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEnumerationDto>, //Used to create/update a book
        IEnumerationAppService //implement the IBookAppService
    {
        public EnumerationAppService(IRepository<Enumeration, Guid> repository)
            : base(repository)
        {
        }
    }
}