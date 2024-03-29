﻿using LanchesMac.Context;
using LanchesMac.Models.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Models.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
                                                        Where(p => p.IsLanchePreferido).
                                                        Include(c => c.Categoria);
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(i => i.LancheId == lancheId);
        }
    }
}
