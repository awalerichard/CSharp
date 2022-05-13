using System;

namespace Catalog.Dtos
{
    public record UserDto{
        public Guid Id {get; init;}
        public string Username {get; init;}
        public string Password {get; init;}
       
        public DateTimeOffset CreatedDate {get; init;}
      

        

    }
}