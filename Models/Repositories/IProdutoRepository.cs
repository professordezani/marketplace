using Marketplace.Models.Entidades;
using System.Collections.Generic;
using System;

namespace Marketplace.Models.Repositories{
    public interface IProdutoRepository
    {
        void Create(Produto produto);
        List<Produto> Read();
        Produto Read(Guid id);
        void Update(Produto produto);
    }
}