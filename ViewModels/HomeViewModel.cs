
using LojaLanches.Models;
using System.Collections.Generic;


namespace LojaLanches.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
