﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.Core.Interfaces.Users;

namespace todo_app.Core.Services
{
    public class TodoServices: ITodoDeleteServices, ITodoGetServices, ITodoSetServices, ITodoUpdateServices
    {
    }
}
