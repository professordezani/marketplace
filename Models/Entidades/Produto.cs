using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marketplace.Models.Entidades {
    public class Produto : EntidadeBase {
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(50)]
        public string Titulo { get; set; }
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(1000)]
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public bool Indisponivel { get; set; }
        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(0.05, 99999.99, ErrorMessage="O valor deve estar entre R$0,05 e R$99999,99")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal? Valor { get; set; }        
        public Empresa Empresa { get; set; }
    }
}