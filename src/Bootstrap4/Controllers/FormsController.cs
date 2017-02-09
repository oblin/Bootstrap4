using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap4.Controllers
{

    public class FormsController : Controller
    {
        public IActionResult Basic()
        {
            return View();
        }

        public IActionResult Inline()
        {
            return View();
        }

        public IActionResult Horizontal()
        {
            return View();
        }
    }
}