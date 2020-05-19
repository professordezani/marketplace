using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marketplace.Models.Entidades {
    public class Produto : EntidadeBase {
        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Descricao { get; set; }
        [Required]
        public byte[] Imagem { get; set; }
        public bool Indisponivel { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Valor { get; set; }        
        [Required]
        public Empresa Empresa { get; set; }
    }
}