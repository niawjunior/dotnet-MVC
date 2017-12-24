using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //public string Index()
        //{
        //    return "This string is from MVC Controller";
        //}
        public ActionResult Index()
        {
            var E = new Employee() { Eid = 1, EmpName = "pasupol" };

            return View(E);
        }
    }
}