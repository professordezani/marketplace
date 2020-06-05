using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Cliente : Usuario
   {
       [Required(ErrorMessage="CPF é obrigatório")]
       [MaxLength(11, ErrorMessage="CPF deve ter 11 Caracteres")]
       [MinLength(11, ErrorMessage="CPF deve ter 11 Caracteres")]
       public string Cpf { get; set; }
       
       [Required(ErrorMessage="Endereço é obrigatório")]
       [MaxLength(200, ErrorMessage="Endereço deve conter no máximo 200 caracteres")]
       public string Endereco { get; set; }

   }
}