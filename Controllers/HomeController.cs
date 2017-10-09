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
            return View(Task.GetAll());
        }

        [HttpPost("/task/list/add"), ActionName("Index")]
        public ActionResult IndexPost()
        {
            if (Request.Form["new-task"] != "")
            {
                Task newTask = new Task (Request.Form["new-task"]);
            }
            return View(Task.GetAll());
        }

        [HttpPost("/task/list/clear"), ActionName("Index")]
        public ActionResult TaskListClear()
        {
            Task.ClearAll();
            return View(Task.GetAll());
        }
    }
}
