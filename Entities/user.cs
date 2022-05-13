using System;

namespace Catalog.Entities
{

    public record User{
        
        public Guid Id {get; init;}
        public string Username {get; init;}
        public string Password {get; init;}

        public DateTimeOffset CreatedDate {get; init;}
       
       public DateTimeOffset UpdatedDate {get; init;}


    }
}