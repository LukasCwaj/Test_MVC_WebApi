using MVC_WebApi_ToDoList.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApi_ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private ToDoListContext db = new ToDoListContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
