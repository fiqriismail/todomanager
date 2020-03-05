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
        //[Route("get")]
        public async Task<ActionResult<IEnumerable<ToDo>>> GetToDos()
        {
            var items = await _toDoPersistenceService.GetToDos();
            return Ok(new StatusMessage { Error = false, Message = string.Empty, Value = items });
        }

        // GET: api/ToDo/5
        [HttpGet("get/{id}")]
        public async Task<ActionResult<ToDo>> GetToDo(int id)
        {
            var item = await _toDoPersistenceService.GetToDo(id);
            if (item == null)
                return NotFound();
            //return item;
            return Ok(new StatusMessage { Error = false, Message = string.Empty, Value = item });
        }

        // PUT: api/ToDo/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDo(int id, ToDo toDo)
        {
            if (id != toDo.Id)
            {
                return BadRequest();
            }
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ToDoExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            await _toDoPersistenceService.UpDateToDo(toDo);
            //return NoContent();
            return Ok(new StatusMessage { Error = false, Message = string.Empty, Value = string.Empty });
        }

        // POST: api/ToDo
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ToDo>> PostToDo(ToDo toDo)
        {
            await _toDoPersistenceService.CreateToDo(toDo);
            //return CreatedAtAction("GetToDo", new { id = toDo.Id }, toDo);
            return CreatedAtAction(nameof(GetToDo), new StatusMessage { Error = false, Value = "Random users created in the memory" });
        }

        // DELETE: api/ToDo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDo>> DeleteToDo(int id)
        {
            await _toDoPersistenceService.DeleteTodo(id);
            //var toDo = await _context.ToDos.FindAsync(id);
            //if (toDo == null)
            //{
            //    return NotFound();
            //}

            //_context.ToDos.Remove(toDo);
            //await _context.SaveChangesAsync();

            //return toDo;
            return Ok(new StatusMessage { Error = false,  Value = string.Empty });
        }

        private bool ToDoExists(int id)
        {
            return _context.ToDos.Any(e => e.Id == id);
        }
    }
}
