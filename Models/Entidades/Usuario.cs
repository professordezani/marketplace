using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public abstract class Usuario : EntidadeBase 
   {
       [Required(ErrorMessage="Este campo é obrigatório")]
       [MaxLength(50)]
       public string Nome { get; set; }       
       [Required(ErrorMessage="Este campo é obrigatório")]
       [MaxLength(50)]
       public string Email { get; set; }
       [Required(ErrorMessage="Este campo é obrigatório")]
       [MinLength(6,ErrorMessage="Senha deve ter no mínimo 6 caracteres")]
       [MaxLength(25)]
       public string Senha { get; set; }
   }
}