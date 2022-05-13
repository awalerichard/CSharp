using System;
using System.Collections.Generic;
using System.Linq;

using Catalog.Dtos;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers{
    [ApiController]
    [Route("users")]

    public class UserController : ControllerBase{
        private readonly IUsersRepository repository;
        public UserController(IUsersRepository repository){
            this.repository = repository;
        }
        [HttpGet]

        public IEnumerable<UserDto> GetUsers(){
            var users = repository.GetUsers().Select(user => user.AsDto());
            return users;
        }

         //Get /users/{id}
        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser(Guid id){
              var user = repository.GetUser(id);

            if(user is null){
                return NotFound();
            }
            return user.AsDto();

        }

         // Post /items
        [HttpPost]
        public ActionResult<UserDto> CreateItem(CreateUserDto userDto){
            User user =new(){
                Id = Guid.NewGuid(),
                Username = userDto.Username,
                Password= userDto.Password,
                CreatedDate= DateTimeOffset.UtcNow
            };

            repository.CreateUser(user);

            return CreatedAtAction(nameof(GetUser), new {id = user.Id}, user.AsDto());
        }

        [HttpPut("{id}")]

        public ActionResult<UserDto> UpdateUser(Guid id,UpdateUserDto userDto){
            var existingUser = repository.GetUser(id);

            if (existingUser is null){
                return NotFound();
            }
            User updatedUser = existingUser with {
                Password = userDto.Password

            };

            repository.UpdateUser(updatedUser);
            return NoContent();
        }
        //Delete /users/ {id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id){
             var existingUser = repository.GetUser(id);

            if(existingUser is null){
                return NotFound();
            }
            repository.DeleteUser(id);
            return NoContent();

        }
        
        
    }
}