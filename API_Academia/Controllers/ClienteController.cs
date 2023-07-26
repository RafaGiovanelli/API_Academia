using API_Academia.Application.Clientes;
using API_Academia.Models.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace API_Academia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost("InserirCliente")]
        public string InserirCliente(Cliente infoCliente)
        {
            return new ClienteApplication().CadastroDeCliente(infoCliente);
        }

        [HttpGet("ListaCliente")]
        public List<Cliente> ListaClientes()
        {
            return new ClienteApplication().ListarClientes();
        }

        [HttpPut("EditaCliente")]
        public Cliente EditaCliente(Cliente infoCliente)
        {
            return new ClienteApplication().EditarInfoClientes(infoCliente);
        }

        [HttpPost("PagamentoMensalidade")]
        public bool PagaMensalidade(int Id)
        {
            return new ClienteApplication().PagamentoMensalidade(Id);
        }

        [HttpDelete("InativaCliente")]
        public bool InativaCliente(int Id)
        {
            return new ClienteApplication().InativarCliente(Id);
        }

    }
}