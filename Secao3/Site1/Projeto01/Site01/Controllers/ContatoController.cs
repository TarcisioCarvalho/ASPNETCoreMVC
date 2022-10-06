using Microsoft.AspNetCore.Mvc;
using Site01.Libary.Mail;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }

        public IActionResult Register([FromForm]Contato contato)
        {
            if (!ModelState.IsValid) 
            {
                ViewBag.Contato = contato;
                return View(nameof(Index));
            };

            SendMails.SendMessageContact(contato);
            ViewBag.Contato = new Contato();
            ViewBag.Message = "Messagem enviada com sucesso!";
            string content =  contato.ToString();
            return  View(nameof(Index));
        }
    }
}
