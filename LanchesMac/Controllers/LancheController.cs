using LanchesMac.Models;
using LanchesMac.Models.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.IdentityModel.Tokens;
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

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                try
                {
                    switch (categoria)
                    {
                        case "normal":
                            lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal", StringComparison.OrdinalIgnoreCase));
                            break;
                        case "natural":
                            lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Natural", StringComparison.OrdinalIgnoreCase));
                            break;
                        default: throw new ArgumentOutOfRangeException(nameof(categoriaAtual), "Valor de categoria é inválido, digite uma categoria válida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha na escolha da categoria", ex.Message);
                    return null;
                }
                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel()
            {
                Lanches = lanches,
                CategoriaAtual = categoria
            };

            return View(lancheListViewModel);
        }
    }
}
