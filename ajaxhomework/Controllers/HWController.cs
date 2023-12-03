using ajaxhomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;

namespace ajaxhomework.Controllers
{
    public class HWController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HW1()
        {
           
            return View();
        }

        public IActionResult HW2()
        {

            return View();
        }

        public string CheckAccount(Member m)
        {
            DemoContext context = new DemoContext();
            
            string c = "該姓名可以使用";
            if (context.Members.Any(p=>p.Name== m.Name))
            {
                c = "該用戶已註冊";
            }

            return c;
        }

        public IActionResult HW3() 
        {
            return View();
        }

        public IActionResult Cities()
        {
            DemoContext context = new DemoContext();
            var cities = context.Addresses.Select(c => c.City).Distinct();
            return Json(cities);
        }

        //根據城市名稱讀取不會重複的鄉鎮區名稱
        public IActionResult Districts(string city)
        {
            DemoContext context = new DemoContext();
            var districts = context.Addresses.Where(a => a.City == city).Select(a => a.SiteId).Distinct();
            return Json(districts);
        }

        //根據鄉鎮區讀取路的名稱
        public IActionResult Roads(string siteId)
        {
            DemoContext context = new DemoContext();
            var roads = context.Addresses.Where(a => a.SiteId == siteId).Select(a => a.Road);
            return Json(roads);
        }
    }
}
