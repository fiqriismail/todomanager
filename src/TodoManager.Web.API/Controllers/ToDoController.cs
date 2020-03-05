using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoManager.Web.Data.Entities;
using TodoManager.Web.Data.Persistence;

namespace TodoManager.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoDbContext _context;
        private readonly IToDoPersistenceService _toDoPersistenceService;
        private readonly ILogger _logger;

        public ToDoController(ToDoDbContext context, IToDoPersistenceService toDoPersistenceService, ILogger<ToDoController> logger)
        {
            _context = context;
            _toDoPersistenceService = toDoPersistenceService;
            _logger = logger;
        }

        // GET: api/ToDo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDo>>> GetToDos()
        {
            var items = await _toDoPersistenceService.GetToDos();
            return Ok(new StatusMessage { Error = false, Message = string.Empty, Value = items });
        }

        // GET: api/ToDo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDo>> GetToDo(int id)
        {
            var item = await _toDoPersistenceService.GetToDo(id);
            if (item == null)
                return NotFound();
            return Ok(new StatusMessage { Error = false, Message = string.Empty, Value = item });
        }

        // PUT: api/ToDo/5
        [HttpPut]
        public async Task<IActionResult> PutToDo(ToDo toDo)
        {
            await _toDoPersistenceService.UpDateToDo(toDo);
            return Ok(new StatusMessage { Error = false, Message = string.Empty, Value = string.Empty });
        }

        // POST: api/ToDo
        [HttpPost]
        public async Task<ActionResult<ToDo>> PostToDo(ToDo toDo)
        {
            await _toDoPersistenceService.CreateToDo(toDo);
            return CreatedAtAction(nameof(GetToDo), new { id = toDo.Id }, new StatusMessage { Error = false });
        }

        // DELETE: api/ToDo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDo>> DeleteToDo(int id)
        {
            await _toDoPersistenceService.DeleteTodo(id);
            return Ok(new StatusMessage { Error = false,  Value = string.Empty });
        }
    }
}
