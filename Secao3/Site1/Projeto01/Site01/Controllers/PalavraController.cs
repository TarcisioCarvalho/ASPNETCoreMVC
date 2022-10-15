using Microsoft.AspNetCore.Mvc;
using Site01.DataBase;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site01.Libary.Filters;
using X.PagedList;

namespace Site01.Controllers
{
    [Login]
    public class PalavraController : Controller
    {
        private DataBaseContext _db;
        public PalavraController(DataBaseContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index(int? pages)
        {
            var pageNumber = pages ?? 1;
            var Palavras = _db.Palavras.ToList();
            var resultadoPaginado = Palavras.ToPagedList(pageNumber, 5); 
            return View(resultadoPaginado);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Palavra());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();

                TempData["Mensagem"] = $"A palavra {palavra.Name} foi cadastrada com sucesso !";
                return RedirectToAction(nameof(Index));
            }
          
            return View(palavra);
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Palavra palavra = _db.Palavras.Find(id);
            return View(nameof(Cadastrar),palavra);
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();
                TempData["Mensagem"] = $"A palavra {palavra.Name} foi atualizada com sucesso !";
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Cadastrar),palavra);
        }
        [HttpGet]
        public IActionResult Deletar(int id)
        {
            Palavra palavra = _db.Palavras.Find(id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();
            TempData["Mensagem"] = $"A palavra {palavra.Name} foi excluida com sucesso !";
            return RedirectToAction(nameof(Index));
        }
    }
}
