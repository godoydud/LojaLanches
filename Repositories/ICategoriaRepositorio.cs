using LojaLanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLanches.Repositories
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
