using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Dtos;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
   //Get //items

    [ApiController]
    [Route("todos")]
    public class TodoController : ControllerBase{

        private readonly IItemsRepository repository;

        public TodoController(IItemsRepository repository){
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<ItemDto> GetItems(){
            var items = repository.GetItems().Select (item => item.AsDto());
            return items;
            
        }
        //Get /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item is null){
                return NotFound();
            }
            return item.AsDto();
        }

        // Post /items
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto){
            Item item =new(){
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Description= itemDto.Description,
                CreatedDate= DateTimeOffset.UtcNow
            };

            repository.CreateItem(item);

            return CreatedAtAction(nameof(GetItem), new {id = item.Id}, item.AsDto());
        }

        // PUT //items
        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDto itemDto){
            var existingItem = repository.GetItem(id);

            if(existingItem is null){
                return NotFound();
            }

            Item updatedItem = existingItem with {
                Name = itemDto.Name,
                Description= itemDto.Description
            };

           repository.UpdateItem(updatedItem);

            return NoContent();
        }
        
        //Delete /items/ {id}
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id){
             var existingItem = repository.GetItem(id);

            if(existingItem is null){
                return NotFound();
            }
            repository.DeleteItem(id);
            return NoContent();

        }
    }

}


    
