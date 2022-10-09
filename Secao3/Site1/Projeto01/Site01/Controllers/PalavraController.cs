﻿using Microsoft.AspNetCore.Mvc;
using Site01.DataBase;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        private DataBaseContext _db;
        public PalavraController(DataBaseContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var Palavras = _db.Palavras.ToList();
            return View(Palavras);
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
                var palavras = _db.Palavras.ToList();
                return View(nameof(Index),palavras);
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
                var palavras = _db.Palavras.ToList();
                return View(nameof(Index), palavras);
            }
            return View(nameof(Cadastrar),palavra);
        }
        [HttpGet]
        public IActionResult Deletar(int id)
        {
            Palavra palavra = _db.Palavras.Find(id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
