using System;

namespace Catalog.Entities
{
    //public enum TaskStatus {notStarted, onGoing, completed}
    public record Item{
        
        public Guid Id {get; init;}
        public string Name {get; init;}
        public string Description {get; init;}
       // public int Id {get; init;}
        public DateTimeOffset CreatedDate {get; init;}

        //public TaskStatus Status {get; init;}
        //public DateTimeOffset UpdatedDate {get; init;}
        


        

    }
}