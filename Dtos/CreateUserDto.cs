using System;
using System.ComponentModel.DataAnnotations;


namespace Catalog.Dtos{
public record CreateUserDto{
       // public Guid Id {get; init;}

       [Required]
        public string Username {get; init;}
        public string Password {get; init;}

    }
}