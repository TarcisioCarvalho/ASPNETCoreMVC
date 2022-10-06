using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Atualizar()
        {
            return View(nameof(Cadastrar));
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View(nameof(Cadastrar));
        }
        [HttpGet]
        public IActionResult Deletar([FromForm] Palavra palavra)
        {
            // TODO 
            return RedirectToAction();
        }
    }
}
