using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // return new ContentResult() { Content = "Hello world"};
            return View();
        }

        public string Test()
        {
            return "Test!";
        }
    }
}
