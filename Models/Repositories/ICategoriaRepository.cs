using Marketplace.Models.Entidades;
using System.Collections.Generic;

namespace Marketplace.Models.Repositories{    
    public interface ICategoriaRepository
    {
        List<Categoria> Read();
    }
} 