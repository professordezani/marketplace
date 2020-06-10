using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);        
    }
}