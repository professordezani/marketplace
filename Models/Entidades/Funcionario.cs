using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades 
{
   public class Funcionario : Usuario
   {
       public bool Ativo { get; set; }
       public bool Principal { get; set; }
       public Empresa Empresa { get; set; }
   }
}