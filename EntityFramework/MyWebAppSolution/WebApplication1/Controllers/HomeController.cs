﻿using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _repository;

        public HomeController(IProdutoRepository repository)
        {
            this._repository = repository;
        }

        public IActionResult Index()
        {
            return View(this._repository.ListarProdutos());
        }

        public string Obter()
        {
            return "Teste2";
        }
    }
}
