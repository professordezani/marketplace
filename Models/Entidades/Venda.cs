using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Marketplace.Models.Entidades
{
    public class Venda : EntidadeBase
    {
        [Required]
        public DateTime DataVenda { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public Produto Produto { get; set; }

        public int FormaPagamento { get; set; }
        public decimal ValorTotalVenda { get; set; }

    }
}