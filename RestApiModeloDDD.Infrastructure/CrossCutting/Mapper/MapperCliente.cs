using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            Cliente cliente = new Cliente()
            {
                Id = (int)clienteDto.Id,
                Nome = clienteDto.Nome,
                Email = clienteDto.Email,
                Sobrenome = clienteDto.Sobrenome
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            ClienteDto clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dtos = clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email
            });

            return dtos;
        }
    }
}