using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public abstract class Usuario : EntidadeBase 
   {
       [Required(ErrorMessage="Nome é obrigatório")]
       public string Nome { get; set; }       
       [Required(ErrorMessage="E-mail é obrigatório")]
       public string Email { get; set; }
       [Required(ErrorMessage="Senha é obrigatório")]
       [MinLength(5,ErrorMessage="Senha Deve Ter no Mínimo 5 Caracteres")]
       public string Senha { get; set; }
   }
}