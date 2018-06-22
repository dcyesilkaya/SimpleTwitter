using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleTwitter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //index html çağrıldığı zaman kök dizindeki(wwwroot) un altındaki index htmlini çalıştır dedik
            return File("~/index.html", "text/html");
        }
    }
}