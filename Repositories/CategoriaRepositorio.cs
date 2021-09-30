using LojaLanches.Context;
using LojaLanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLanches.Repositories
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly AppDbContext _context;
        public CategoriaRepositorio(AppDbContext contexto)
        {
            _context = contexto;
        } 

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
