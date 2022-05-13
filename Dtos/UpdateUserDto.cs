using System;
using System.ComponentModel.DataAnnotations;


namespace Catalog.Dtos{
public record UpdateUserDto{
      

       [Required]
      
        public string Password {get; init;}
        //public DateTimeOffset UpdatedDate {get; init;}



        

    }
}