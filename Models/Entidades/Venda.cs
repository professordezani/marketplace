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
        public Empresa EmpresaId { get; set; }

        [Required]
        public Cliente ClienteId { get; set; }

        [Required]
        public List<VendaItem> VendaItemId { get; set; }

        public Pagamento tpPagamento { get; set; }

    }
}