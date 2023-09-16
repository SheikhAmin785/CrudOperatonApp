using CrudOperatonApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperatonApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;
        public EmployeeController(ApplicationContext context)
        {
            this.context=context;
        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }
    }
}
