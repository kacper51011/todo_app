using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.Core.DTOs.Todos;

namespace todo_app.Core.Interfaces.Users
{
    internal interface ITodoGetServices
    {
        TodosResponse getTodos(GetTodosRequest getTodosRequest);
    }
}
