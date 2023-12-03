using ajaxhomework.Models;
using Microsoft.AspNetCore.Mvc;

namespace ajaxhomework.Controllers
{
    public class APIController : Controller
    {
        private readonly IWebHostEnvironment _host;
        private readonly DemoContext _context;
        public APIController(IWebHostEnvironment host, DemoContext context)
        {
            _host = host;
            _context = context;
        }

       
    }
}
