using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View(null);
        }

        [HttpPost("/task/list/add"), ActionName("Index")]
        public ActionResult IndexPost()
        {
            Task newTask = new Task (Request.Form["new-task"]);
            newTask.Save();
            List<string> allTasks = Task.GetAll();
            return View(allTasks);
        }

        [HttpPost("/task/list/clear"), ActionName("Index")]
        public ActionResult TaskListClear()
        {
            Task.ClearAll();
            return View(null);
        }
    }
}
