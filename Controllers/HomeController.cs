using LojaLanches.Repositories;
using LojaLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace LojaLanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;

        public HomeController(ILancheRepositorio lancheRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepositorio.LanchesPreferidos
            };

            return View(homeViewModel);
        }
    }
}
