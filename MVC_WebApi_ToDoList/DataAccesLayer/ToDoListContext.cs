using MVC_WebApi_ToDoList.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_WebApi_ToDoList.DataAccesLayer
{
    public class ToDoListContext: DbContext
    {
        public ToDoListContext() : base("ToDoListContext")
        {
        }
        public DbSet<ToDoList> ToDoList { get; set; }

        static ToDoListContext()
        {
            Database.SetInitializer<ToDoListContext>(new Initializer());
        }
    }
}