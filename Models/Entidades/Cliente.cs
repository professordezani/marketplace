using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Cliente : Usuario
   {
       [Required]
       [MaxLength(9)]
       [MinLength(9)]
       public string Cpf { get; set; }
       public string Endereco { get; set; }

   }
}