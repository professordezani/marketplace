using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Usuario : EntidadeBase 
   {
       [Required]
       public string nome { get; set; }       
       [Required]
       public string email { get; set; }
       [Required]
       public string senha { get; set; }
   }
}