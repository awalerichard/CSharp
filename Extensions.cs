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

          public static UserDto AsDto(this User user)
        {
            return new UserDto{
                
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                CreatedDate = user.CreatedDate

            };
           
         }
    }
}
