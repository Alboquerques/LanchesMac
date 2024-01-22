using LanchesMac.Models;
using LanchesMac.Models.Repositories;
using LanchesMac.Models.Repositories.Interfaces;
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
            ViewBag.Titulo = "Todos os lanches";
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
