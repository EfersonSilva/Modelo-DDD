using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto clienteDto);

        void Update(ProdutoDto clienteDto);

        void Remove(ProdutoDto clienteDto);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int clienteId);
    }
}