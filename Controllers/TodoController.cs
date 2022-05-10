using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
   //Get //items

    [ApiController]
    [Route("todos")]
    public class TodoController : ControllerBase{

        private readonly InMemItemsRepository repository;

        public TodoController(){
            repository = new InMemItemsRepository();
        }

    }

}


    
