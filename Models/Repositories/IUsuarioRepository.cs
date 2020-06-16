using System;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Read(Guid id);
        Usuario Login(string email, string senha);        
    }
}