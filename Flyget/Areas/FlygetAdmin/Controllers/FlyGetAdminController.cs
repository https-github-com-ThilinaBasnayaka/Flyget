using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flyget.Areas.FlygetAdmin.Controllers
{
    public class FlyGetAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}