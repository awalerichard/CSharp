using System;
using System.ComponentModel.DataAnnotations;


namespace Catalog.Dtos{
public record CreateItemDto{
       // public Guid Id {get; init;}

       [Required]
        public string Name {get; init;}
        public string Description {get; init;}

    }
}