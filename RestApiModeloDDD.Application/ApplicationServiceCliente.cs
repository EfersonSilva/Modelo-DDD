using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;

        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientesDto = _serviceCliente.GetAll();

            var clientes = _mapperCliente.MapperListClientesDto(clientesDto);

            return clientes;
        }

        public ClienteDto GetById(int clienteId)
        {
            var cliente = _serviceCliente.GetById(clienteId);

            var clienteDto = _mapperCliente.MapperEntityToDto(cliente);
            return clienteDto;
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}