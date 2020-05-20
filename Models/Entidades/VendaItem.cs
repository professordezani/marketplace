
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades
{
    public class VendaItem : EntidadeBase
    {
        [Required]
        public Venda vendaId { get; set; }

        [Required]
        public Produto produtoId { get; set; }

        [Required]
        public decimal quantiade { get; set; }
    }
}