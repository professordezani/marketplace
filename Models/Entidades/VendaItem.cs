
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades
{
    public class VendaItem : EntidadeBase
    {
        [Required]
        public Venda Venda { get; set; }

        [Required]
        public Produto Produto { get; set; }

        [Required]
        public int Quantidade { get; set; }
    }
}