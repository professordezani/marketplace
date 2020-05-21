using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Usuario : EntidadeBase 
   {
       [Required]
       public string Nome { get; set; }       
       [Required]
       public string Email { get; set; }
       [Required]
       public string Senha { get; set; }
   }
}