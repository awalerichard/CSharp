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
            var items = repository.GetItems().Select (item =>new ItemDto {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                CreatedDate = item.CreatedDate
            });
            return items;
            
        }
        //Get /items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item is null){
                return NotFound();
            }
            return item;
        }

    }

}


    
