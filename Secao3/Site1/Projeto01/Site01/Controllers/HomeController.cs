using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;
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
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if(user.Email == "tarcisio@tarcisio.com" && user.Password == "123456")
            {
                HttpContext.Session.SetString("Login", "True");
                return RedirectToAction("Index","Palavra");
            }

            ViewBag.Message = "Invalid Email or Password";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }
    }
}
