using Catalog.Entities;
using Catalog.Dtos;

namespace Catalog{

    public static class Extenstions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                CreatedDate = item.CreatedDate

            };
           
         }
    }
}
