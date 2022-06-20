using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
