using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostbankApp.Controllers
{
    public class EmployeePosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
