using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Web.Data.Entities;

namespace TodoManager.Web.Data.Persistence
{
    public class ToDoPersistenceService : IToDoPersistenceService
    {

        private readonly ToDoDbContext _context;
        private readonly ILogger _logger;

        public ToDoPersistenceService(ToDoDbContext context, ILogger<ToDoPersistenceService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task CreateToDo(ToDo toDo)
        {
            if(toDo != null)
            {
                await _context.AddAsync(toDo);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError("Error saving data", ex);
                    throw new Exception("Error saving data", ex);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    throw;
                }
            }
        }

        public async Task DeleteTodo(int id)
        {
            ToDo toDo = await _context.ToDos.FindAsync(id);
            _context.ToDos.Remove(toDo);
            await _context.SaveChangesAsync();

            //var toDo = await _context.ToDos.FindAsync(id);
            //if (toDo == null)
            //{
            //    return NotFound();
            //}

            //_context.ToDos.Remove(toDo);
            //await _context.SaveChangesAsync();

            //return toDo;

            //_context.Entry<ToDo>(item).State = EntityState.Deleted;
        }

        public async Task<ToDo> GetToDo(int id)
        {
            ToDo toDo = await _context.ToDos.FindAsync(id);
            return toDo;
        }

        public async Task<List<ToDo>> GetToDos()
        {
            //List<ToDo> items = await _context.ToDos.ToListAsync();
            //return items;
            return await _context.ToDos.ToListAsync();
        }

        public async Task UpDateToDo(ToDo toDo)
        {
            //_context.Update(todo);
            ToDo item = await _context.ToDos.FindAsync(toDo.Id);
            item.Completed = toDo.Completed;
            item.Status = toDo.Status;
            //_context.Entry(toDo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
