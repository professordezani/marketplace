using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Funcionario : Usuario
   {
       public bool ativo { get; set; }
       public bool principal { get; set; }
       public Empresa empresa { get; set; }
   }
}