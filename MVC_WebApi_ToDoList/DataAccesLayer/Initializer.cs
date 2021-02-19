using MVC_WebApi_ToDoList.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_WebApi_ToDoList.DataAccesLayer
{
    public class Initializer : DropCreateDatabaseAlways<ToDoListContext>
    {
        public static void SeedLibrary(ToDoListContext context)
        {
            var toDoList = new List<ToDoList>
            {
            new ToDoList() { Title = "Title1", Description = "Example description1", IsCompleted = false},
            new ToDoList() { Title = "Title2", Description = "Example description2", IsCompleted = false},
            new ToDoList() { Title = "Title3", Description = "Example description3", IsCompleted = false},
            };
            toDoList.ForEach(i => context.ToDoList.Add(i));
            context.SaveChanges();
        }
    }
}