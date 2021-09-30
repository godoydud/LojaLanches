using LojaLanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLanches.Repositories
{
    public interface ILancheRepositorio
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        ILancheRepositorio GetLacheById(int lancheId);
    }
}
