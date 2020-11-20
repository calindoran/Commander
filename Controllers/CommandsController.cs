using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{

    // api/[commands] pops CommandsController to here i.e. wildcard
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository) // Dependency injection - value repository
        {
            _repository = repository;
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET that responds to api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands(); // Updated from GetAppCommands

            return Ok(commandItems);
        }

        // GET that responds to api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}

// dotnet run to start