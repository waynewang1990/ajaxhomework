using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace ajaxhomework.Controllers
{
    public class HW1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HW1()
        {
           
            return View();
        }
    }
}
