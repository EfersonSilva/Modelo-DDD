using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System.Collections.Generic;

namespace RestApiModeloDDD.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Add(produtoDto);

                return Ok("Produto Cadastrado com Sucesso!");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto removido com sucesso!");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}