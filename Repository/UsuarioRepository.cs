using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;

namespace Marketplace.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dataContext;

        public UsuarioRepository (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Usuario usuario)
        {
            _dataContext.Add(usuario);
            _dataContext.SaveChanges();
        }

        public Usuario Read(string email, string senha)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario usuario)
        {
            _dataContext.Usuarios.Update(usuario);
            _dataContext.SaveChanges();
        }
    }

}