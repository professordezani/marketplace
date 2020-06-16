using System;
using System.Linq;
using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;

namespace Marketplace.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dataContext;
        public UsuarioRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Usuario Login(string email, string senha)
        {
            return _dataContext.Usuarios.Where(x => x.Email == email && x.Senha == senha).FirstOrDefault();
        }

        public Usuario Read(Guid id)
        {
             return _dataContext.Usuarios.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}