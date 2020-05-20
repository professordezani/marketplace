using System;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades
{
    public class Venda : EntidadeBase
    {
        [Required]
        public DateTime dataVenda { get; set; }

        [Required]
        public Empresa empresaId { get; set; }

        [Required]
        public Cliente clienteId { get; set; }

        [Required]
        public VendaItem vendaItemId { get; set; }

        public int tipoPagamento { get; set; } //0 - Dinheiro ; 1 - Cartão de Crédito;


    }
}