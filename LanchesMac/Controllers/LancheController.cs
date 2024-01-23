using LanchesMac.Models;
using LanchesMac.Models.Repositories;
using LanchesMac.Models.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            var lanchesViewModel = new LancheListViewModel();
            lanchesViewModel.Lanches = _lancheRepository.Lanches;
            lanchesViewModel.CategoriaAtual = "Lanches";

            return View(lanchesViewModel);
        }
    }
}
