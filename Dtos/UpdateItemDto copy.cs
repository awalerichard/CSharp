using System;
using System.ComponentModel.DataAnnotations;


namespace Catalog.Dtos{
public record UpdateItemDto{
       // public Guid Id {get; init;}

       [Required]
        public string Name {get; init;}
        public string Description {get; init;}

        // public enum Status {get; init;}

        
       // public int Id {get; init;}
        //public DateTimeOffset CreatedDate {get; init;}
       // public DateTimeOffset UpdatedDate {get; init;}
       // public enum TaskStatus {get; init;}

        

    }
}