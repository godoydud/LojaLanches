using LojaLanches.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        // Construtor para acessar o repositório
        public LancheController(ILancheRepositorio lancheRepositorio, ICategoriaRepositorio categoriaRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
            _categoriaRepositorio = categoriaRepositorio;
        }

        // Método para retornar Lanches
        public IActionResult List()
        {
            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categoria";

            var lanches = _lancheRepositorio.Lanches;
            return View(lanches);
        }
    }
}
