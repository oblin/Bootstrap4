using Microsoft.AspNetCore.Mvc;

namespace Bootstrap4.Controllers
{
    public class HelpersController : Controller
    {
        public IActionResult StaticMethod()
        {
            return View();
        }

        public IActionResult ExtensionMethod()
        {
            return View();
        }

        public IActionResult SelfClosing()
        {
            return View();
        }
    }
}