using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades {
   public class Empresa : EntidadeBase {
        [Required]
        [MaxLength(100)]
        public string NomeFantasia { get; set; }
        [Required]
        [MaxLength(100)]
        public string RazaoSocial { get; set; }
        [Required]
        [MaxLength(14)]
        public string Cnpj { get; set; }
        [Required]
        public Categoria Categoria { get; set; }
   }
} 