using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;

        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto clienteDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(clienteDto);
            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = _serviceProduto.GetAll();
            var produtosDto = _mapperProduto.MapperListProdutosDto(produtos);

            return produtosDto;
        }

        public ProdutoDto GetById(int clienteId)
        {
            var cliente = _serviceProduto.GetById(clienteId);
            var clienteDto = _mapperProduto.MapperEntityToDto(cliente);
            return clienteDto;
        }

        public void Remove(ProdutoDto clienteDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(clienteDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto clienteDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(clienteDto);
            _serviceProduto.Update(produto);
        }
    }
}