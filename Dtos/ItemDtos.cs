using System;

namespace Catalog.Dtos
{
    public record ItemDto{
        public Guid Id {get; init;}
        public string Name {get; init;}
        public string Description {get; init;}
       // public int Id {get; init;}
        public DateTimeOffset CreatedDate {get; init;}
        public enum Status{ Notstarted, OnGoing, Finished }   
        
            

       // public DateTimeOffset UpdatedDate {get; init;}
       

        

    }
}