using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Cliente : Usuario
   {
       [Required(ErrorMessage="CPF é obrigatório")]
       [MaxLength(9)]
       [MinLength(9)]
       public string Cpf { get; set; }
       
       [Required(ErrorMessage="Endereço é obrigatório")]
       [MaxLength(200)]
       public string Endereco { get; set; }

   }
}