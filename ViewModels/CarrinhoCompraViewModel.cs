using LojaLanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaLanches.ViewModels
{
    public class CarrinhoCompraViewModel
    {
        //Carrinho de compra
        public CarrinhoCompra CarrinhoCompra { get; set; }
        //Total do carrinho 
        public decimal CarrinhoCompraTotal { get; set; }
    }
}
