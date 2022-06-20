using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System.Collections.Generic;

namespace RestApiModeloDDD.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Add(clienteDto);

                return Ok("Cliente Cadastrado com Sucesso!");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente Atualizado com sucesso");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente removido com sucesso");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}