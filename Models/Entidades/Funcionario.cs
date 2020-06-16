namespace Marketplace.Models.Entidades 
{
   public class Funcionario : Usuario
   {
       public bool Principal { get; set; }
       public Empresa Empresa { get; set; }
   }
}