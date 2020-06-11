using Marketplace.Models.Entidades;
using System.Collections.Generic;
using System;

namespace Marketplace.Models.Repositories{    
    public interface ICategoriaRepository
    {
        List<Categoria> Read();
        Categoria Read(Guid id);        
    }
} 