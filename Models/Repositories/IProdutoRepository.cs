using Marketplace.Models.Entidades;
using System.Collections.Generic;
using System;

namespace Marketplace.Models.Repositories{
    public interface IProdutoRepository
    {
        void Create(Produto produto);
        List<Produto> ReadByEmpresa(Guid id);
        Produto Read(Guid id);
        void Update(Produto produto);
        List<Produto> ReadDisponivel(Guid? id);
    }
}