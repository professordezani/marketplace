
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades
{
    public class VendaItem : EntidadeBase
    {
        [Required]
        public Venda VendaId { get; set; }

        [Required]
        public Produto ProdutoId { get; set; }

        [Required]
        public int Quantiade { get; set; }
    }
}