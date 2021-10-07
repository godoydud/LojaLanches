using LojaLanches.Context;
using LojaLanches.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLanches.Repositories
{
    public class LancheRepositorio : ILancheRepositorio
    {
        private readonly AppDbContext _context;

        public LancheRepositorio(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
    }
}
