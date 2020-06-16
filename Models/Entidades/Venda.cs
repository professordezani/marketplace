using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Marketplace.Models.Enums;

namespace Marketplace.Models.Entidades
{
    public class Venda : EntidadeBase
    {
        [Required]
        public DateTime DataVenda { get; set; }

        [Required]
        public Empresa Empresa { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public List<VendaItem> Itens { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        public Decimal valorTotalVenda { get; set; }

    }
}