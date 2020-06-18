using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Views
{
      
    public class CarrinhoView
    {
        public  List<Produto> ProdutosCart { get; set; }
      
      public Decimal valorTotal { get; set; }

      // public FormaPagamento FormaPagamento { get; set; }

      public int quantidade { get; set; }

        public CarrinhoView()
        {
           ProdutosCart = new List<Produto>();
        }
    }
}