using System;

namespace Catalog.Entities
{
    public record Item{
        public Guid Id {get; init;}
        public string Name {get; init;}
        public string Description {get; init;}
       // public int UserId {get; init;}
        public DateTimeOffset CreatedDate {get; init;}
       // public DateTimeOffset UpdatedDate {get; init;}
       // public enum TaskStatus {get; init;}

        

    }
}