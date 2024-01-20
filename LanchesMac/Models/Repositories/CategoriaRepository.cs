﻿using LanchesMac.Context;
using LanchesMac.Models.Repositories.Interfaces;

namespace LanchesMac.Models.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}