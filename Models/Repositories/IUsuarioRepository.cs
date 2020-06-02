using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IUsuarioRepository
    {
        void Create (Usuario usuario);
        Usuario Read(string email, string senha);
        void Update(Usuario usuario);
    }
}