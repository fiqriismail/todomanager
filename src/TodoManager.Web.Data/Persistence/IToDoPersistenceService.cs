using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Web.Data.Entities;

namespace TodoManager.Web.Data.Persistence
{
    public interface IToDoPersistenceService
    {
        Task<List<ToDo>> GetToDos();
        Task<ToDo> GetToDo(int id);
        Task CreateToDo(ToDo toDo);
        Task UpDateToDo(ToDo toDo);
        Task DeleteTodo(int id);
    }
}
